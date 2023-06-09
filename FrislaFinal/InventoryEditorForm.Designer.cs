namespace FrislaFinal
{
    partial class InventoryEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryEditorForm));
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TutorialButton = new System.Windows.Forms.Button();
            this.WeaponSwapper = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.WeaponSwapLabel = new System.Windows.Forms.Label();
            this.BackgroundMods = new System.Windows.Forms.Timer(this.components);
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.SetMoney = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetLevel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.WeaponLevel = new System.Windows.Forms.TextBox();
            this.Tutorial2Button_Click = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.setmodsmelee2 = new System.Windows.Forms.Button();
            this.setmodsranged2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RarityLegendary = new System.Windows.Forms.Button();
            this.RaritySuperior = new System.Windows.Forms.Button();
            this.RarityRare = new System.Windows.Forms.Button();
            this.RarityCommon = new System.Windows.Forms.Button();
            this.RarityImprovised = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SetModsToItem1 = new System.Windows.Forms.TextBox();
            this.Item2UpgradeComponent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Item1UpgradeComponent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.getweaponmelee2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.getweaponranged2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SetWeaponStack = new System.Windows.Forms.Button();
            this.Item1Count = new System.Windows.Forms.TextBox();
            this.Item2Count = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox6.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TutorialButton);
            this.groupBox6.Controls.Add(this.WeaponSwapper);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.WriteButton);
            this.groupBox6.Controls.Add(this.WeaponSwapLabel);
            this.groupBox6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox6.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(355, 589);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Item Swapper";
            // 
            // TutorialButton
            // 
            this.TutorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TutorialButton.ForeColor = System.Drawing.Color.Red;
            this.TutorialButton.Location = new System.Drawing.Point(8, 28);
            this.TutorialButton.Name = "TutorialButton";
            this.TutorialButton.Size = new System.Drawing.Size(340, 59);
            this.TutorialButton.TabIndex = 47;
            this.TutorialButton.TabStop = false;
            this.TutorialButton.Text = "TUTORIAL";
            this.TutorialButton.UseVisualStyleBackColor = true;
            this.TutorialButton.Click += new System.EventHandler(this.TutorialButton_Click);
            // 
            // WeaponSwapper
            // 
            this.WeaponSwapper.BackColor = System.Drawing.Color.Black;
            this.WeaponSwapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WeaponSwapper.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponSwapper.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.WeaponSwapper.FormattingEnabled = true;
            this.WeaponSwapper.ItemHeight = 23;
            this.WeaponSwapper.Location = new System.Drawing.Point(6, 146);
            this.WeaponSwapper.Name = "WeaponSwapper";
            this.WeaponSwapper.Size = new System.Drawing.Size(342, 393);
            this.WeaponSwapper.TabIndex = 0;
            this.WeaponSwapper.SelectedIndexChanged += new System.EventHandler(this.WeaponSwapper_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Cyan;
            this.label13.Location = new System.Drawing.Point(6, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Weapon to change";
            // 
            // WriteButton
            // 
            this.WriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WriteButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteButton.ForeColor = System.Drawing.Color.Cyan;
            this.WriteButton.Location = new System.Drawing.Point(6, 545);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(342, 38);
            this.WriteButton.TabIndex = 45;
            this.WriteButton.TabStop = false;
            this.WriteButton.Text = "Swap Weapon";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // WeaponSwapLabel
            // 
            this.WeaponSwapLabel.AutoSize = true;
            this.WeaponSwapLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponSwapLabel.ForeColor = System.Drawing.Color.Lime;
            this.WeaponSwapLabel.Location = new System.Drawing.Point(6, 125);
            this.WeaponSwapLabel.Name = "WeaponSwapLabel";
            this.WeaponSwapLabel.Size = new System.Drawing.Size(114, 18);
            this.WeaponSwapLabel.TabIndex = 43;
            this.WeaponSwapLabel.Text = "WEAPON ID";
            // 
            // BackgroundMods
            // 
            this.BackgroundMods.Tick += new System.EventHandler(this.BackgroundMods_Tick);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.SetMoney);
            this.groupBox9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox9.Location = new System.Drawing.Point(373, 403);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(245, 70);
            this.groupBox9.TabIndex = 61;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Other";
            // 
            // SetMoney
            // 
            this.SetMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetMoney.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.SetMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SetMoney.Location = new System.Drawing.Point(15, 25);
            this.SetMoney.Name = "SetMoney";
            this.SetMoney.Size = new System.Drawing.Size(215, 36);
            this.SetMoney.TabIndex = 57;
            this.SetMoney.TabStop = false;
            this.SetMoney.Text = "Set Money $2147483646";
            this.SetMoney.UseVisualStyleBackColor = true;
            this.SetMoney.Click += new System.EventHandler(this.SetMoney_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.Tutorial2Button_Click);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(373, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 385);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item Modification Editor";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.SetLevel);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.WeaponLevel);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox4.Location = new System.Drawing.Point(10, 244);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 69);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ITEM LEVEL";
            // 
            // SetLevel
            // 
            this.SetLevel.BackColor = System.Drawing.Color.Black;
            this.SetLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetLevel.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.SetLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SetLevel.Location = new System.Drawing.Point(8, 22);
            this.SetLevel.Name = "SetLevel";
            this.SetLevel.Size = new System.Drawing.Size(156, 32);
            this.SetLevel.TabIndex = 39;
            this.SetLevel.TabStop = false;
            this.SetLevel.Text = "Set Weapon Level";
            this.SetLevel.UseVisualStyleBackColor = false;
            this.SetLevel.Click += new System.EventHandler(this.SetLevel_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(225, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 23);
            this.label15.TabIndex = 48;
            this.label15.Text = "0-30";
            // 
            // WeaponLevel
            // 
            this.WeaponLevel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponLevel.Location = new System.Drawing.Point(169, 21);
            this.WeaponLevel.Name = "WeaponLevel";
            this.WeaponLevel.Size = new System.Drawing.Size(50, 33);
            this.WeaponLevel.TabIndex = 38;
            this.WeaponLevel.TabStop = false;
            this.WeaponLevel.Text = "30";
            this.WeaponLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Tutorial2Button_Click
            // 
            this.Tutorial2Button_Click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Tutorial2Button_Click.ForeColor = System.Drawing.Color.Red;
            this.Tutorial2Button_Click.Location = new System.Drawing.Point(6, 28);
            this.Tutorial2Button_Click.Name = "Tutorial2Button_Click";
            this.Tutorial2Button_Click.Size = new System.Drawing.Size(254, 59);
            this.Tutorial2Button_Click.TabIndex = 47;
            this.Tutorial2Button_Click.TabStop = false;
            this.Tutorial2Button_Click.Text = "TUTORIAL";
            this.Tutorial2Button_Click.UseVisualStyleBackColor = true;
            this.Tutorial2Button_Click.Click += new System.EventHandler(this.Tutorial2Button_Click_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Transparent;
            this.groupBox8.Controls.Add(this.button1);
            this.groupBox8.Controls.Add(this.button2);
            this.groupBox8.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox8.Location = new System.Drawing.Point(10, 170);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(250, 68);
            this.groupBox8.TabIndex = 49;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "GET FROM RANGED, WRITE TO: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(10, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 18;
            this.button1.TabStop = false;
            this.button1.Text = "Ranged";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(128, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.Text = "Melee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.setmodsmelee2);
            this.groupBox5.Controls.Add(this.setmodsranged2);
            this.groupBox5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox5.Location = new System.Drawing.Point(10, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(250, 68);
            this.groupBox5.TabIndex = 40;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GET FROM MELEE, WRITE TO: ";
            // 
            // setmodsmelee2
            // 
            this.setmodsmelee2.BackColor = System.Drawing.Color.Black;
            this.setmodsmelee2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setmodsmelee2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.setmodsmelee2.Location = new System.Drawing.Point(128, 22);
            this.setmodsmelee2.Name = "setmodsmelee2";
            this.setmodsmelee2.Size = new System.Drawing.Size(112, 32);
            this.setmodsmelee2.TabIndex = 43;
            this.setmodsmelee2.TabStop = false;
            this.setmodsmelee2.Text = "Melee";
            this.setmodsmelee2.UseVisualStyleBackColor = false;
            this.setmodsmelee2.Click += new System.EventHandler(this.setmodsmelee2_Click);
            // 
            // setmodsranged2
            // 
            this.setmodsranged2.BackColor = System.Drawing.Color.Black;
            this.setmodsranged2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setmodsranged2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.setmodsranged2.Location = new System.Drawing.Point(10, 22);
            this.setmodsranged2.Name = "setmodsranged2";
            this.setmodsranged2.Size = new System.Drawing.Size(112, 32);
            this.setmodsranged2.TabIndex = 40;
            this.setmodsranged2.TabStop = false;
            this.setmodsranged2.Text = "Ranged";
            this.setmodsranged2.UseVisualStyleBackColor = false;
            this.setmodsranged2.Click += new System.EventHandler(this.setmodsranged2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.RarityLegendary);
            this.groupBox3.Controls.Add(this.RaritySuperior);
            this.groupBox3.Controls.Add(this.RarityRare);
            this.groupBox3.Controls.Add(this.RarityCommon);
            this.groupBox3.Controls.Add(this.RarityImprovised);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(10, 319);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(164, 55);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ITEM RARITY";
            // 
            // RarityLegendary
            // 
            this.RarityLegendary.BackColor = System.Drawing.Color.Chocolate;
            this.RarityLegendary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RarityLegendary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RarityLegendary.ForeColor = System.Drawing.Color.Chocolate;
            this.RarityLegendary.Location = new System.Drawing.Point(130, 22);
            this.RarityLegendary.Name = "RarityLegendary";
            this.RarityLegendary.Size = new System.Drawing.Size(25, 25);
            this.RarityLegendary.TabIndex = 33;
            this.RarityLegendary.TabStop = false;
            this.RarityLegendary.UseVisualStyleBackColor = false;
            this.RarityLegendary.Click += new System.EventHandler(this.RarityLegendary_Click);
            // 
            // RaritySuperior
            // 
            this.RaritySuperior.BackColor = System.Drawing.Color.DarkMagenta;
            this.RaritySuperior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RaritySuperior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RaritySuperior.ForeColor = System.Drawing.Color.DarkMagenta;
            this.RaritySuperior.Location = new System.Drawing.Point(99, 22);
            this.RaritySuperior.Name = "RaritySuperior";
            this.RaritySuperior.Size = new System.Drawing.Size(25, 25);
            this.RaritySuperior.TabIndex = 32;
            this.RaritySuperior.TabStop = false;
            this.RaritySuperior.UseVisualStyleBackColor = false;
            this.RaritySuperior.Click += new System.EventHandler(this.RaritySuperior_Click);
            // 
            // RarityRare
            // 
            this.RarityRare.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.RarityRare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RarityRare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RarityRare.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.RarityRare.Location = new System.Drawing.Point(68, 22);
            this.RarityRare.Name = "RarityRare";
            this.RarityRare.Size = new System.Drawing.Size(25, 25);
            this.RarityRare.TabIndex = 31;
            this.RarityRare.TabStop = false;
            this.RarityRare.UseVisualStyleBackColor = false;
            this.RarityRare.Click += new System.EventHandler(this.RarityRare_Click);
            // 
            // RarityCommon
            // 
            this.RarityCommon.BackColor = System.Drawing.Color.Green;
            this.RarityCommon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RarityCommon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RarityCommon.ForeColor = System.Drawing.Color.Green;
            this.RarityCommon.Location = new System.Drawing.Point(37, 22);
            this.RarityCommon.Name = "RarityCommon";
            this.RarityCommon.Size = new System.Drawing.Size(25, 25);
            this.RarityCommon.TabIndex = 30;
            this.RarityCommon.TabStop = false;
            this.RarityCommon.UseVisualStyleBackColor = false;
            this.RarityCommon.Click += new System.EventHandler(this.RarityCommon_Click);
            // 
            // RarityImprovised
            // 
            this.RarityImprovised.BackColor = System.Drawing.Color.Gray;
            this.RarityImprovised.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RarityImprovised.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RarityImprovised.ForeColor = System.Drawing.Color.Gray;
            this.RarityImprovised.Location = new System.Drawing.Point(6, 22);
            this.RarityImprovised.Name = "RarityImprovised";
            this.RarityImprovised.Size = new System.Drawing.Size(25, 25);
            this.RarityImprovised.TabIndex = 29;
            this.RarityImprovised.TabStop = false;
            this.RarityImprovised.UseVisualStyleBackColor = false;
            this.RarityImprovised.Click += new System.EventHandler(this.RarityImprovised_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.Color.Transparent;
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.SetModsToItem1);
            this.groupBox7.Controls.Add(this.Item2UpgradeComponent);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.Item1UpgradeComponent);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.getweaponmelee2);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.getweaponranged2);
            this.groupBox7.Enabled = false;
            this.groupBox7.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox7.Location = new System.Drawing.Point(114, 630);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(103, 11);
            this.groupBox7.TabIndex = 63;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "IGNORE ME BOX";
            this.groupBox7.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "ranged melee";
            // 
            // SetModsToItem1
            // 
            this.SetModsToItem1.Enabled = false;
            this.SetModsToItem1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetModsToItem1.Location = new System.Drawing.Point(113, 157);
            this.SetModsToItem1.Name = "SetModsToItem1";
            this.SetModsToItem1.Size = new System.Drawing.Size(100, 22);
            this.SetModsToItem1.TabIndex = 17;
            this.SetModsToItem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item2UpgradeComponent
            // 
            this.Item2UpgradeComponent.Enabled = false;
            this.Item2UpgradeComponent.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2UpgradeComponent.Location = new System.Drawing.Point(99, 90);
            this.Item2UpgradeComponent.Name = "Item2UpgradeComponent";
            this.Item2UpgradeComponent.Size = new System.Drawing.Size(100, 22);
            this.Item2UpgradeComponent.TabIndex = 16;
            this.Item2UpgradeComponent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(6, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "melee base";
            // 
            // Item1UpgradeComponent
            // 
            this.Item1UpgradeComponent.Enabled = false;
            this.Item1UpgradeComponent.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1UpgradeComponent.Location = new System.Drawing.Point(113, 122);
            this.Item1UpgradeComponent.Name = "Item1UpgradeComponent";
            this.Item1UpgradeComponent.Size = new System.Drawing.Size(100, 22);
            this.Item1UpgradeComponent.TabIndex = 15;
            this.Item1UpgradeComponent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "ranged base";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "ranged ranged";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(98, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 36;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(6, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "melee melee";
            // 
            // getweaponmelee2
            // 
            this.getweaponmelee2.Enabled = false;
            this.getweaponmelee2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getweaponmelee2.Location = new System.Drawing.Point(88, 63);
            this.getweaponmelee2.Name = "getweaponmelee2";
            this.getweaponmelee2.Size = new System.Drawing.Size(100, 21);
            this.getweaponmelee2.TabIndex = 39;
            this.getweaponmelee2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "melee ranged";
            // 
            // getweaponranged2
            // 
            this.getweaponranged2.Enabled = false;
            this.getweaponranged2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getweaponranged2.Location = new System.Drawing.Point(98, 35);
            this.getweaponranged2.Name = "getweaponranged2";
            this.getweaponranged2.Size = new System.Drawing.Size(100, 21);
            this.getweaponranged2.TabIndex = 38;
            this.getweaponranged2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SetWeaponStack);
            this.groupBox1.Controls.Add(this.Item1Count);
            this.groupBox1.Controls.Add(this.Item2Count);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Location = new System.Drawing.Point(373, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 207);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Duper";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(30, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 50);
            this.button3.TabIndex = 61;
            this.button3.TabStop = false;
            this.button3.Text = "Set Stack x25";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label6.Location = new System.Drawing.Point(19, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 14);
            this.label6.TabIndex = 55;
            this.label6.Text = "Inventory First Added Item Count";
            // 
            // SetWeaponStack
            // 
            this.SetWeaponStack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetWeaponStack.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.SetWeaponStack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.SetWeaponStack.Location = new System.Drawing.Point(136, 146);
            this.SetWeaponStack.Name = "SetWeaponStack";
            this.SetWeaponStack.Size = new System.Drawing.Size(90, 50);
            this.SetWeaponStack.TabIndex = 56;
            this.SetWeaponStack.TabStop = false;
            this.SetWeaponStack.Text = "Set Stack x99";
            this.SetWeaponStack.UseVisualStyleBackColor = true;
            this.SetWeaponStack.Click += new System.EventHandler(this.SetWeaponStack_Click);
            // 
            // Item1Count
            // 
            this.Item1Count.Enabled = false;
            this.Item1Count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1Count.Location = new System.Drawing.Point(77, 57);
            this.Item1Count.Name = "Item1Count";
            this.Item1Count.Size = new System.Drawing.Size(100, 22);
            this.Item1Count.TabIndex = 52;
            this.Item1Count.TabStop = false;
            this.Item1Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Item2Count
            // 
            this.Item2Count.Enabled = false;
            this.Item2Count.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2Count.Location = new System.Drawing.Point(77, 114);
            this.Item2Count.Name = "Item2Count";
            this.Item2Count.Size = new System.Drawing.Size(100, 22);
            this.Item2Count.TabIndex = 51;
            this.Item2Count.TabStop = false;
            this.Item2Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(9, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Inventory Second Added Item Count";
            // 
            // InventoryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(697, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InventoryEditorForm";
            this.Opacity = 0.85D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryEditorForm_FormClosing);
            this.Load += new System.EventHandler(this.InventoryEditorForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InventoryEditorForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InventoryEditorForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InventoryEditorForm_MouseUp);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button TutorialButton;
        private System.Windows.Forms.ListBox WeaponSwapper;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Label WeaponSwapLabel;
        private System.Windows.Forms.Timer BackgroundMods;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button SetMoney;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetLevel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox WeaponLevel;
        private System.Windows.Forms.Button Tutorial2Button_Click;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button setmodsmelee2;
        private System.Windows.Forms.Button setmodsranged2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RarityLegendary;
        private System.Windows.Forms.Button RaritySuperior;
        private System.Windows.Forms.Button RarityRare;
        private System.Windows.Forms.Button RarityCommon;
        private System.Windows.Forms.Button RarityImprovised;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SetModsToItem1;
        private System.Windows.Forms.TextBox Item2UpgradeComponent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Item1UpgradeComponent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox getweaponmelee2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox getweaponranged2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SetWeaponStack;
        private System.Windows.Forms.TextBox Item1Count;
        private System.Windows.Forms.TextBox Item2Count;
        private System.Windows.Forms.Label label5;
    }
}