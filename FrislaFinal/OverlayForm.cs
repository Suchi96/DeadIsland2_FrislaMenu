using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

using static FrislaFinal.SigScan;
using static FrislaFinal.Bools;
using static FrislaFinal.ActorStuff;
using System.Diagnostics;
using System.Threading;

namespace FrislaFinal // RIP Fridl 9.5.2023
{
    public partial class Overlay : Form
    {

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private List<MenuItem> menuItems;
        private int previousSelectedIndex = -1;
        private int selectedIndex;

        private GlobalKeyboardHook keyboardHook;



        private async Task AttemptOpenProcess()
        {
            if (!IsProcessOpen && !IsConnectionAttempting)
            {
                IsConnectionAttempting = true;
                if (MemLib.OpenProcess("DeadIsland-Win64-Shipping"))
                {
                    IsProcessOpen = true;
                    await ConnectWorld();
                    DI2_PROCESS = MemLib.mProc.Process;
              

                }
                IsConnectionAttempting = false;
            }
        }


        public Overlay()
        {
            InitializeComponent();
            
            this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width, 0);
            this.StartPosition = FormStartPosition.Manual;
            this.AllowTransparency = true;
            this.BackColor = Color.Wheat;
            CheckForIllegalCrossThreadCalls = false;
            this.TransparencyKey = Color.Wheat;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            int initialStyle = Imps.GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x8000 | 0x20);
            keyboardHook = new GlobalKeyboardHook();
            keyboardHook.KeyDown += KeyboardHook_KeyDown;
            keyboardHook.KeyUp += KeyboardHook_KeyUp;
            MenuPanel.DrawMode = DrawMode.OwnerDrawFixed;
            MenuPanel.DrawItem += MenuPanel_DrawItem;
            Thread EC = new Thread(ExitCheat);
            EC.Start();
            selectedIndex = 0; // Set the selectedIndex to 0

            var T = "";
            Task.Run(async () =>
            {
                while (true)
                {
                    if (DI2_PROCESS != null)
                    {
                        if (DI2_PROCESS.HasExited)
                        {
                            DI2_PROCESS = null;
                            IsProcessOpen = false;
                        }
                    }
                    AttemptOpenProcess();

                   
                    T = IsProcessOpen ? "Frisla Menu v1.1" : "-ERROR-";
                    if (ConnectionText.Text != T)
                        ConnectionText.Text = T;
                    ConnectionText.ForeColor = IsProcessOpen ? Color.OliveDrab : Color.White;
                    await Task.Delay(100);
                }
            });

            this.Focus();
        }

        void ExitCheat()
        {
            while (true)
            {
              
              
                if (GetAsyncKeyState(Keys.Delete) < 0) // UNLOAD
                {
                    Environment.Exit(0);
                   
                }
                
            }
        }

        private void InitializeMenuItems()
        {
            menuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Name = "Godmode",
                    IsToggled = false,
                 
                },
                new MenuItem
                {
                    Name = "Inf Ammo",
                    IsToggled = false,
                    BytesOn = "90 90 90 90 90 90",
                    BytesOff = "89 8B 04 01 00 00"
                },
                 new MenuItem
                {
                    Name = "Inf Stamina+Fury",
                    IsToggled = false,
                   
                },
                  new MenuItem
                {
                    Name = "No Fall Damage",
                    IsToggled = false,

                },
                   new MenuItem
                {
                    Name = "Super Jump+Speed",
                    IsToggled = false,

                },
                      new MenuItem
                {
                    Name = "Increase All Damage",
                    IsToggled = false,

                },
                         new MenuItem
                {
                    Name = "Free Shopping",
                    IsToggled = false,
                    BytesOn = "90 90 90 90",
                    BytesOff = "44 89 42 20"
                },
                 new MenuItem
                {
                    Name = "Noclip",
                    IsToggled = false,
                   
                },
                  new MenuItem
                {
                    Name = "Debug Mode",
                    IsToggled = false,

                }
            };

            selectedIndex = 0;

            foreach (MenuItem item in menuItems)
            {
                MenuPanel.Items.Add($"{item.Name} [OFF]");
            }
        }

        private void MoveListBoxSelectionUp()
        {
            if (selectedIndex > 0)
            {
                selectedIndex--;
                MenuPanel.SelectedIndex = selectedIndex;
            }
        }

        private void MoveListBoxSelectionDown()
        {
            if (selectedIndex < MenuPanel.Items.Count - 1)
            {
                selectedIndex++;
                MenuPanel.SelectedIndex = selectedIndex;
            }
        }

        private void ToggleListBoxSelection()
        {
            if (selectedIndex >= 0 && selectedIndex < MenuPanel.Items.Count)
            {
                MenuItem selectedItem = menuItems[selectedIndex];
                selectedItem.IsToggled = !selectedItem.IsToggled;

               
                MenuPanel.Items[selectedIndex] = $"{selectedItem.Name} [{(selectedItem.IsToggled ? "ON" : "OFF")}]";

        
                MenuPanel.Invalidate(MenuPanel.GetItemRectangle(selectedIndex));

               
                if (selectedItem.Name == "Inf Ammo")
                {
                    string bytes = selectedItem.IsToggled ? selectedItem.BytesOn : selectedItem.BytesOff;
                    MemLib.WriteMemory("DeadIsland-Win64-Shipping.exe+16559B6", "bytes", bytes);
                }
                else if (selectedItem.Name == "Godmode")
                {
                    GlobalDamageMultiplier = selectedItem.IsToggled ? 0 : 1;
                    HitDetectionRadius = selectedItem.IsToggled ? 0 : 60;
                    HitDetectionHeight = selectedItem.IsToggled ? 0 : 200;
                    Health = selectedItem.IsToggled ? 69420 : 5000;
                }
                else if (selectedItem.Name == "Inf Stamina+Fury")
                {
                    bIsInfiniteFury = selectedItem.IsToggled ? 1 : 0;
                    bInfiniteStaminaExpressionValue = selectedItem.IsToggled ? 1 : 0;
                 
                }
                else if (selectedItem.Name == "No Fall Damage")
                {
                    FallCriticalImpactHeight = selectedItem.IsToggled ? 694200 : 700;
                    FallDamagingImpactHeight = selectedItem.IsToggled ? 694200 : 450;

                }
                else if (selectedItem.Name == "Super Jump+Speed")
                {
                    MaxBackwardSpeed = selectedItem.IsToggled ? 2500 : 200;
                    MovementSpeed = selectedItem.IsToggled ? 2500 : 0;
                    JumpVelocityZ = selectedItem.IsToggled ? 2000 : 0;
                }
                else if (selectedItem.Name == "Increase All Damage")
                {
                    DefaultValueOverride = selectedItem.IsToggled ? 25 : 1;
                    bOverrideDefaultValue = selectedItem.IsToggled ? 25 : 1;
                    MaxValueLimit = selectedItem.IsToggled ? 25 : 2;
                }
                if (selectedItem.Name == "Free Shopping")
                {
                    string bytes = selectedItem.IsToggled ? selectedItem.BytesOn : selectedItem.BytesOff;
                    MemLib.WriteMemory("DeadIsland-Win64-Shipping.exe+3FF00DE", "bytes", bytes);
                }
                else if (selectedItem.Name == "Noclip")
                {
                    bActorEnableCollision = selectedItem.IsToggled ? 67 : 68;
                    MovementMode = selectedItem.IsToggled ? 5 : 2;
                }
                else if (selectedItem.Name == "Debug Mode")
                {
                    bShowDebugInfo = selectedItem.IsToggled ? 6 : 2;
                    bShowOverlay = selectedItem.IsToggled ? 8 : 0;
                }
                
            }
        }

        private void KeyboardHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (!this.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.NumPad8:
                        MoveListBoxSelectionUp();
                        break;
                    case Keys.NumPad2:
                        MoveListBoxSelectionDown();
                        break;
                    case Keys.NumPad5:
                        ToggleListBoxSelection();
                        break;
                }
            }
        }

        private void KeyboardHook_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void MenuPanel_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                MenuItem menuItem = menuItems[e.Index];
                string itemText = $"{menuItem.Name} [{(menuItem.IsToggled ? "ON" : "OFF")}]";
                Color textColor = menuItem.IsToggled ? Color.DarkGreen : Color.Yellow;

                e.DrawBackground();

               
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    textColor = Color.White;
                }

            
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                }

              
                int textX = e.Bounds.Left + (e.Bounds.Width - (int)e.Graphics.MeasureString(itemText, e.Font).Width) / 2;
                int textY = e.Bounds.Top + (e.Bounds.Height - (int)e.Graphics.MeasureString(itemText, e.Font).Height) / 2;

            
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    
                    e.Graphics.DrawString(itemText, e.Font, textBrush, textX, textY);
                }

                e.DrawFocusRectangle();
            }
        }





        private void onTickMods_Tick(object sender, EventArgs e)
        {
            if (selectedIndex != previousSelectedIndex)
            {
                MenuPanel.SetSelected(selectedIndex, true);
                previousSelectedIndex = selectedIndex;
            }

           
            foreach (MenuItem item in menuItems)
            {
                if (item.Name == "Godmode")
                {
                    if (item.IsToggled)
                    {
                        Health = 69420;
                    }
                }
                else if (item.Name == "Noclip")
                {
                    if (item.IsToggled)
                    {
                        VelocityZ = 0;

                        if (GetAsyncKeyState(Keys.Space) < 0)
                        {
                            VelocityZ = 555;
                        }
                        else if (GetAsyncKeyState(Keys.LControlKey) < 0)
                        {
                            VelocityZ = -555;
                        }
                    }
                }
                
            }
        }

        private void Overlay_Load(object sender, EventArgs e)
        {
            InitializeMenuItems();
            onTickMods.Tick += onTickMods_Tick;
            onTickMods.Start();
            selectedIndex = 0;
            MenuPanel.SelectedIndex = selectedIndex;
            this.DoubleBuffered = true;
            InventoryEditorForm MenuForm = new InventoryEditorForm();
            MenuForm.Show();

        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            onTickMods.Stop();
        }
    }


  

    public class MenuItem
    {
        public string Name { get; set; }
        public bool IsToggled { get; set; }
        public string BytesOn { get; set; }
        public string BytesOff { get; set; }
    }
}
