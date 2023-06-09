using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using static FrislaFinal.InventoryStuff;
using static FrislaFinal.ActorStuff;
using static FrislaFinal.Bools;
using static FrislaFinal.SigScan;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FrislaFinal
{
    public partial class InventoryEditorForm : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);
        Point dragCursorPoint;
        Point dragFormPoint;



        public InventoryEditorForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TopMost = true;
            CheckForIllegalCrossThreadCalls = false;
            Thread shm = new Thread(ShowHideMenu);
            shm.Start();
        }
        void ShowHideMenu()
        {
            while (true)
            {
                if (GetAsyncKeyState(Keys.Insert) < 0 && showing == true) //HIDE
                {
                    this.Hide();
                    Process[] p = Process.GetProcessesByName("DeadIsland-Win64-Shipping");
                    if (p.Length > 0)
                    {
                        SetForegroundWindow(p[0].MainWindowHandle);
                    }
                    showing = false;
                    Thread.Sleep(120);
                }
                else if (GetAsyncKeyState(Keys.Insert) < 0 && showing == false) // SHOW
                {
                    this.Show();
                    Cursor.Position = new Point(this.Location.X + this.Size.Width / 2, this.Location.Y + this.Size.Height / 2);
                    SetForegroundWindow(this.Handle);
                    this.Activate();
                    this.Focus();
                    showing = true;
                    Thread.Sleep(120);
                }

                Thread.Sleep(70);
            }
        }

        private void InventoryEditorForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void InventoryEditorForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void InventoryEditorForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragCursorPoint = Cursor.Position;
                dragFormPoint = this.Location;
            }
        }

        private void TutorialButton_Click(object sender, EventArgs e)
        {
            string message = "How it works?\n\n" +
                             "Open Storage Locker and empty your Inventory.\n" +
                             "Now move the Item you want to change into your Inventory.\n" +
                             "Inside the Box select which Item you want to get and then press Swap Weapons.\n" +
                             "When done, close Inventory, leave Game and rejoin.\n\n" +
                             "Do not swap out Items with each other or it won't work correctly,\n\n" +
                             "always make sure to empty your Inventory and then place the item you want to edit.";

            MessageBox.Show(message, "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WriteButton_Click(object sender, EventArgs e)
        {
            if (WeaponSwapper.SelectedIndex != -1)
            {
                string selectedName = WeaponSwapper.SelectedItem.ToString();
                string hexValue = hexToStringMap.FirstOrDefault(x => x.Value == selectedName).Key;

                if (!string.IsNullOrEmpty(hexValue))
                {
                    int intValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                    MemLib.WriteMemory("DeadIsland-Win64-Shipping.exe+06FAD0B0,8,48,18,30,18,70,1B8", "int", intValue.ToString());
                }
            }
        }

        private void WeaponSwapper_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WeaponSwapper.SelectedIndex != -1)
            {
                WriteButton.Enabled = true;
            }
            else
            {
                WriteButton.Enabled = false;
            }
        }
        private void PopulateListBox()
        {
            List<string> sortedNames = hexToStringMap.Values.OrderBy(name => name).ToList();
            foreach (string name in sortedNames)
            {
                WeaponSwapper.Items.Add(name);
            }
        }

        private void InventoryEditorForm_Load(object sender, EventArgs e)
        {
            PopulateListBox();
            SetRoundedRegion(this);
            BackgroundMods.Start();
        }

        private void BackgroundMods_Tick(object sender, EventArgs e)
        {
            string hexValue = MemLib.ReadInt("DeadIsland-Win64-Shipping.exe+06FAD0B0,8,48,18,30,18,70,1B8").ToString("X");

            if (hexToStringMap.ContainsKey(hexValue))
            {
                WeaponSwapLabel.Text = hexToStringMap[hexValue];
            }
            else
            {
                WeaponSwapLabel.Text = hexValue;
            }
            Item2UpgradeComponent.Text = ItemUpgradeComponent22.ToString("X");
            textBox1.Text = ItemUpgrade2ComponentMelee.ToString("X");
            Item1UpgradeComponent.Text = ItemUpgradeComponent11.ToString("X");
            SetModsToItem1.Text = ItemUpgradeComponentMelee.ToString("X");
            Item1Count.Text = ItemSlot1.ToString();
            Item2Count.Text = ItemSlot2.ToString();

        }

        private void InventoryEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            BackgroundMods.Stop();
        }

        private Dictionary<string, string> hexToStringMap = new Dictionary<string, string>()
{
    { "1DAB08", "Bodycount" },
    { "1DAC3E", "Big Shot" },
    { "1DB01D", "Peggy" },
    { "1DB149", "Extinction Event" },
    { "1DB268", "One-Hit Wonder" },
    { "1DB461", "Fenrir's Howl" },
    { "1DB598", "Red Dragon" },
    { "1DB6BE", "Raven" },
    { "1D1A95", "Axe" },
    { "1D1BEC", "Fire Axe" },
    { "1D1D7A", "Krakatoa" },
    { "1D1EF7", "Mattock" },
    { "1D21E3", "Pickaxe" },
    { "1D2341", "Shovel" },
    { "1D24C3", "Splitting Axe" },
    { "1D2642", "Zombie Axe" },
    { "1D274F", "Burnt Timber" },
    { "1D28D0", "Crowbar" },
    { "1D2A31", "Club" },
    { "1D2BBD", "Night Stick" },
    { "1D2D3D", "Golf Club" },
    { "1D2EC2", "Heavy Wrench" },
    { "1D2FE6", "Ripper" },
    { "1D315C", "Mace" },
    { "1D32F4", "Metal Bat" },
    { "1D3491", "Police Baton" },
    { "1D3583", "Rebar" },
    { "1D3700", "Small Wrench" },
    { "1D3800", "Steel Pipe" },
    { "1D3974", "Tire Iron" },
    { "1D3ADF", "Banoi War Club" },
    { "1D3C7C", "Wood Baseball Bat" },
    { "1D3DFA", "Dagger" },
    { "1D3F85", "Hunting Knife" },
    { "1D40AA", "Blood Rage" },
    { "1D4261", "Military Knife" },
    { "1D4369", "Bare Hands" },
    { "1D44FF", "Brass Knuckles" },
    { "1D466D", "Claws" },
    { "1D4768", "Electrocutor Claws" },
    { "1D4908", "Crescent Blades" },
    { "1D4A0E", "Fury Fists" },
    { "1D4B70", "Katars" },
    { "1D4C88", "Party Starter" },
    { "1D4E32", "Claw Hammer" },
    { "1D4F4E", "Fire Claw Hammer" },
    { "1D5135", "Composite Sledgehammer" },
    { "1D52EE", "Improvised Hammer" },
    { "1D5409", "Emma's Wrath" },
    { "1D55A5", "Lump Hammer" },
    { "1D572F", "Meat Hammer" },
    { "1D5845", "Sign Pole" },
    { "1D5B3A", "Sledgehammer Acid" },
    { "1D5BD7", "Sledgehammer Impact" },
    { "1D5C78", "Sledgehammer Wood" },
    { "1D5E38", "Bowie Knife" },
    { "1D5FBD", "Chef Knife" },
    { "1D612F", "Meat Cleaver" },
    { "1D62C0", "Deer Horn Knife" },
    { "1D642F", "Kukri" },
    { "1D6537", "Gastric Bypass" },
    { "1D671D", "Red's Demise" },
    { "1D685B", "Zom-B-Gon" },
    { "1D6978", "Wildstyle" },
    { "1D6A81", "O-Kami and Whiskey" },
    { "1D6B9F", "Special Forces Knife" },
    { "1D6CE6", "Banoi Baseball Bat" },
    { "1D6EDA", "Trickster's Smile" },
    { "1D70C4", "Eye Opener" },
    { "1D729F", "Abuela's Ashes" },
    { "1D74B6", "Homewrecker" },
    { "1D7606", "Shark Tooth" },
    { "1D773F", "Jade Dragon" },
    { "1D7867", "The Tenderizer" },
    { "1D7982", "Black Magic" },
    { "1D7B09", "HayFork" },
    { "1D7C68", "Pike" },
    { "1D7D51", "Pool Cue" },
    { "1D7EB0", "Rake" },
    { "1D8048", "Single Blade Staff" },
    { "1D8188", "Single Blade Staff Tearing" },
    { "1D8329", "Bo Staff" },
    { "1D8431", "Bo Staff Bleed" },
    { "1D8546", "Scaffold Pole" },
    { "1D86C7", "Claymore" },
    { "1D897B", "Makeshift Sword" },
    { "1D8AEC", "Katana" },
    { "1D8C05", "Brutalizer" },
    { "1D8D94", "Machete" },
    { "1D8E8C", "Machete AI" },
    { "1D8F9D", "Machete Shock" },
    { "1D9144", "Officers Sword" },
    { "1D92E7", "Tactical Sword" },
    { "1D9470", "Wakizashi" },
    { "1D9614", "Whispering Blade" },
    { "1D97B0", "Zombie Sword" },
    { "1D994B", "Zombie Sword Acid" },
    { "1D99E2", "Zombie Sword Fire" },
    { "1DA3C3", "Crossbow" },
    { "1DA559", "Heavy Revolver" },
    { "1DA705", "Machine Pistol" },
    { "1DA88A", "Nailgun" },
    { "1DA9F8", "Pistol" },
    { "1DAEE5", "Sawblade Launcher" },
    { "1DB86A", "Auto Carbine" },
    { "1DBAE9", "Carbine" },
    { "1DBC79", "Hunting Rifle" },
    { "1DBE20", "Sporting Rifle" },
    { "1DBFC6", "Short Barreled Shotgun" },
    { "1DC149", "Shotgun" },
    { "1DC2F0", "Assault Shotgun" }
};

        private void SetMoney_Click(object sender, EventArgs e)
        {
            Money = 2147483646;
        }

        private void Tutorial2Button_Click_Click(object sender, EventArgs e)
        {
            string message = "How it works?\n\n" +
                              "BEFORE USING THE ITEM EDITOR, MAKE SURE TO HAVE A SAVEGAME BACKUP!\n\n" +
                             "Open Storage Locker and empty your Inventory.\n" +
                             "Now move the Item(#1) you want to mod into your Inventory\n" +
                             "and then move the Item(#2) you want to get the Mods from.\n" +
                             "Item(#1) = First entered Item, the one you want to mod\n" +
                              "Item(#2) = Second entered Item, the one you want to get the mods from\n" +
                             "Depending on what type those Items are,  you can select the following :\n\n" +
                             "Get from Melee: write to Ranged or Melee\n\n" +
                             "Get from Ranged: write to Ranged or Melee\n\n" +
                             "When done, set Item Rarity and Level, then move the edited Item to your Storage Locker, leave Game and rejoin!\n\n" +
                             "IF GAME CRASHES, TRY AGAIN\n\n";
            MessageBox.Show(message, "Tutorial", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void setmodsranged2_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
            {
                ItemUpgradeComponent11 = value;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid hexadecimal value.");
            }
        }

        private void setmodsmelee2_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
            {
                ItemUpgradeComponentMelee = value;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid hexadecimal value.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(Item2UpgradeComponent.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
            {
                ItemUpgradeComponent11 = value;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid hexadecimal value.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(Item2UpgradeComponent.Text, System.Globalization.NumberStyles.HexNumber, null, out value))
            {
                ItemUpgradeComponentMelee = value;
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter a valid hexadecimal value.");
            }
        }

        private void SetRoundedRegion(Control control)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            var rect = new Rectangle(0, 0, control.Width, control.Height);
            var diameter = 30;
            var arc = new Rectangle(rect.Location, new Size(diameter, diameter));
            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }
        private void RarityImprovised_Click(object sender, EventArgs e)
        {
            RequiredRarity = 1;
        }

        private void RarityCommon_Click(object sender, EventArgs e)
        {
            RequiredRarity = 2;
        }

        private void RarityRare_Click(object sender, EventArgs e)
        {
            RequiredRarity = 3;
        }

        private void RaritySuperior_Click(object sender, EventArgs e)
        {
            RequiredRarity = 4;
        }

        private void RarityLegendary_Click(object sender, EventArgs e)
        {
            RequiredRarity = 5;
        }

        private void SetLevel_Click(object sender, EventArgs e)
        {
            if (int.TryParse(WeaponLevel.Text, out int level))
            {
                RequiredLevel1 = level;
                RequiredLevel2 = level;
                WeaponLevel.Text = RequiredLevel1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemSlot1 = 25;
            ItemSlot2 = 25;
        }

        private void SetWeaponStack_Click(object sender, EventArgs e)
        {
            ItemSlot1 = 99;
            ItemSlot2 = 99;
        }
    }
}
