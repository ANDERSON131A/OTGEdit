﻿namespace TCEE
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btGenerate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSetToDefault = new System.Windows.Forms.Button();
            this.tlpWorldSettings = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btCloneGroup = new System.Windows.Forms.Button();
            this.btGroupMoveDown = new System.Windows.Forms.Button();
            this.btGroupMoveUp = new System.Windows.Forms.Button();
            this.btEditGroup = new System.Windows.Forms.Button();
            this.btRemoveFromGroup = new System.Windows.Forms.Button();
            this.btAddToGroup = new System.Windows.Forms.Button();
            this.btDeleteGroup = new System.Windows.Forms.Button();
            this.btNewGroup = new System.Windows.Forms.Button();
            this.lblGroups = new System.Windows.Forms.Label();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.lblBiomesInGroup = new System.Windows.Forms.Label();
            this.lblAvailableBioms = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.ListBox();
            this.btBiomeSettingsResetToDefaults = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tlpBiomeSettings = new System.Windows.Forms.TableLayoutPanel();
            this.lbBiomes = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.cbDeleteRegion = new System.Windows.Forms.CheckBox();
            this.btnConvertSchematicToBO3 = new System.Windows.Forms.Button();
            this.btCopyBO3s = new System.Windows.Forms.Button();
            this.btImportWorld = new System.Windows.Forms.Button();
            this.rbSummerSkin = new System.Windows.Forms.RadioButton();
            this.rbWinterSkin = new System.Windows.Forms.RadioButton();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.btSelectSourceWorld = new System.Windows.Forms.Button();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.cbWorld = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btGenerate
            // 
            this.btGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btGenerate.Location = new System.Drawing.Point(11, 685);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(215, 25);
            this.btGenerate.TabIndex = 13;
            this.btGenerate.Text = "Generate";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Visible = false;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 110);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 565);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.TabStop = false;
            this.tabControl1.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "World Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btSetToDefault);
            this.groupBox1.Controls.Add(this.tlpWorldSettings);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 527);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "World Settings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tick a checkbox to apply the value. Only applied values are used by \"Generate\" an" +
    "d \"Save settings\".";
            // 
            // btSetToDefault
            // 
            this.btSetToDefault.Location = new System.Drawing.Point(9, 18);
            this.btSetToDefault.Name = "btSetToDefault";
            this.btSetToDefault.Size = new System.Drawing.Size(215, 25);
            this.btSetToDefault.TabIndex = 26;
            this.btSetToDefault.Text = "Clear all";
            this.btSetToDefault.UseVisualStyleBackColor = true;
            this.btSetToDefault.Click += new System.EventHandler(this.btWorldSettingsSetToDefault_Click);
            // 
            // tlpWorldSettings
            // 
            this.tlpWorldSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpWorldSettings.AutoScroll = true;
            this.tlpWorldSettings.ColumnCount = 8;
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpWorldSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpWorldSettings.Location = new System.Drawing.Point(10, 50);
            this.tlpWorldSettings.Name = "tlpWorldSettings";
            this.tlpWorldSettings.RowCount = 1;
            this.tlpWorldSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWorldSettings.Size = new System.Drawing.Size(1103, 471);
            this.tlpWorldSettings.TabIndex = 19;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1131, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Biome Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox4.Controls.Add(this.btCloneGroup);
            this.groupBox4.Controls.Add(this.btGroupMoveDown);
            this.groupBox4.Controls.Add(this.btGroupMoveUp);
            this.groupBox4.Controls.Add(this.btEditGroup);
            this.groupBox4.Controls.Add(this.btRemoveFromGroup);
            this.groupBox4.Controls.Add(this.btAddToGroup);
            this.groupBox4.Controls.Add(this.btDeleteGroup);
            this.groupBox4.Controls.Add(this.btNewGroup);
            this.groupBox4.Controls.Add(this.lblGroups);
            this.groupBox4.Controls.Add(this.lbGroups);
            this.groupBox4.Controls.Add(this.lblBiomesInGroup);
            this.groupBox4.Controls.Add(this.lblAvailableBioms);
            this.groupBox4.Controls.Add(this.lbGroup);
            this.groupBox4.Controls.Add(this.btBiomeSettingsResetToDefaults);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.tlpBiomeSettings);
            this.groupBox4.Controls.Add(this.lbBiomes);
            this.groupBox4.Location = new System.Drawing.Point(7, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1117, 526);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Biome Settings";
            // 
            // btCloneGroup
            // 
            this.btCloneGroup.Location = new System.Drawing.Point(155, 163);
            this.btCloneGroup.Name = "btCloneGroup";
            this.btCloneGroup.Size = new System.Drawing.Size(50, 23);
            this.btCloneGroup.TabIndex = 35;
            this.btCloneGroup.TabStop = false;
            this.btCloneGroup.Text = "Clone";
            this.btCloneGroup.UseVisualStyleBackColor = true;
            this.btCloneGroup.Click += new System.EventHandler(this.btCloneGroup_Click);
            // 
            // btGroupMoveDown
            // 
            this.btGroupMoveDown.Location = new System.Drawing.Point(111, 134);
            this.btGroupMoveDown.Name = "btGroupMoveDown";
            this.btGroupMoveDown.Size = new System.Drawing.Size(94, 23);
            this.btGroupMoveDown.TabIndex = 34;
            this.btGroupMoveDown.TabStop = false;
            this.btGroupMoveDown.Text = "Move down";
            this.btGroupMoveDown.UseVisualStyleBackColor = true;
            this.btGroupMoveDown.Click += new System.EventHandler(this.btGroupMoveDown_Click);
            // 
            // btGroupMoveUp
            // 
            this.btGroupMoveUp.Location = new System.Drawing.Point(8, 134);
            this.btGroupMoveUp.Name = "btGroupMoveUp";
            this.btGroupMoveUp.Size = new System.Drawing.Size(94, 23);
            this.btGroupMoveUp.TabIndex = 33;
            this.btGroupMoveUp.TabStop = false;
            this.btGroupMoveUp.Text = "Move up";
            this.btGroupMoveUp.UseVisualStyleBackColor = true;
            this.btGroupMoveUp.Click += new System.EventHandler(this.btGroupMoveUp_Click);
            // 
            // btEditGroup
            // 
            this.btEditGroup.Location = new System.Drawing.Point(53, 163);
            this.btEditGroup.Name = "btEditGroup";
            this.btEditGroup.Size = new System.Drawing.Size(40, 23);
            this.btEditGroup.TabIndex = 32;
            this.btEditGroup.TabStop = false;
            this.btEditGroup.Text = "Edit";
            this.btEditGroup.UseVisualStyleBackColor = true;
            this.btEditGroup.Click += new System.EventHandler(this.btEditGroup_Click);
            // 
            // btRemoveFromGroup
            // 
            this.btRemoveFromGroup.Location = new System.Drawing.Point(111, 310);
            this.btRemoveFromGroup.Name = "btRemoveFromGroup";
            this.btRemoveFromGroup.Size = new System.Drawing.Size(95, 23);
            this.btRemoveFromGroup.TabIndex = 31;
            this.btRemoveFromGroup.TabStop = false;
            this.btRemoveFromGroup.Text = "Remove";
            this.btRemoveFromGroup.UseVisualStyleBackColor = true;
            this.btRemoveFromGroup.Click += new System.EventHandler(this.btRemoveFromGroup_Click);
            // 
            // btAddToGroup
            // 
            this.btAddToGroup.Location = new System.Drawing.Point(9, 310);
            this.btAddToGroup.Name = "btAddToGroup";
            this.btAddToGroup.Size = new System.Drawing.Size(95, 23);
            this.btAddToGroup.TabIndex = 30;
            this.btAddToGroup.TabStop = false;
            this.btAddToGroup.Text = "Add";
            this.btAddToGroup.UseVisualStyleBackColor = true;
            this.btAddToGroup.Click += new System.EventHandler(this.btAddToGroup_Click);
            // 
            // btDeleteGroup
            // 
            this.btDeleteGroup.Location = new System.Drawing.Point(99, 163);
            this.btDeleteGroup.Name = "btDeleteGroup";
            this.btDeleteGroup.Size = new System.Drawing.Size(50, 23);
            this.btDeleteGroup.TabIndex = 29;
            this.btDeleteGroup.TabStop = false;
            this.btDeleteGroup.Text = "Delete";
            this.btDeleteGroup.UseVisualStyleBackColor = true;
            this.btDeleteGroup.Click += new System.EventHandler(this.btDeleteGroup_Click);
            // 
            // btNewGroup
            // 
            this.btNewGroup.Location = new System.Drawing.Point(8, 163);
            this.btNewGroup.Name = "btNewGroup";
            this.btNewGroup.Size = new System.Drawing.Size(39, 23);
            this.btNewGroup.TabIndex = 28;
            this.btNewGroup.TabStop = false;
            this.btNewGroup.Text = "New";
            this.btNewGroup.UseVisualStyleBackColor = true;
            this.btNewGroup.Click += new System.EventHandler(this.btNewGroup_Click);
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(6, 17);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(41, 13);
            this.lblGroups.TabIndex = 27;
            this.lblGroups.Text = "Groups";
            // 
            // lbGroups
            // 
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.Location = new System.Drawing.Point(9, 33);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(195, 95);
            this.lbGroups.TabIndex = 26;
            this.lbGroups.TabStop = false;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // lblBiomesInGroup
            // 
            this.lblBiomesInGroup.AutoSize = true;
            this.lblBiomesInGroup.Location = new System.Drawing.Point(5, 193);
            this.lblBiomesInGroup.Name = "lblBiomesInGroup";
            this.lblBiomesInGroup.Size = new System.Drawing.Size(82, 13);
            this.lblBiomesInGroup.TabIndex = 25;
            this.lblBiomesInGroup.Text = "Biomes in group";
            // 
            // lblAvailableBioms
            // 
            this.lblAvailableBioms.AutoSize = true;
            this.lblAvailableBioms.Location = new System.Drawing.Point(6, 338);
            this.lblAvailableBioms.Name = "lblAvailableBioms";
            this.lblAvailableBioms.Size = new System.Drawing.Size(88, 13);
            this.lblAvailableBioms.TabIndex = 24;
            this.lblAvailableBioms.Text = "Avalilable biomes";
            // 
            // lbGroup
            // 
            this.lbGroup.FormattingEnabled = true;
            this.lbGroup.Location = new System.Drawing.Point(9, 209);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbGroup.Size = new System.Drawing.Size(195, 95);
            this.lbGroup.Sorted = true;
            this.lbGroup.TabIndex = 23;
            this.lbGroup.TabStop = false;
            this.lbGroup.SelectedIndexChanged += new System.EventHandler(this.lbGroup_SelectedIndexChanged);
            // 
            // btBiomeSettingsResetToDefaults
            // 
            this.btBiomeSettingsResetToDefaults.Location = new System.Drawing.Point(217, 33);
            this.btBiomeSettingsResetToDefaults.Name = "btBiomeSettingsResetToDefaults";
            this.btBiomeSettingsResetToDefaults.Size = new System.Drawing.Size(126, 23);
            this.btBiomeSettingsResetToDefaults.TabIndex = 22;
            this.btBiomeSettingsResetToDefaults.Text = "Set to defaults";
            this.btBiomeSettingsResetToDefaults.UseVisualStyleBackColor = true;
            this.btBiomeSettingsResetToDefaults.Click += new System.EventHandler(this.btBiomeSettingsResetToDefaults_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tick a checkbox to apply the value. Only applied values are used by \"Generate\" an" +
    "d \"Save settings\".";
            // 
            // tlpBiomeSettings
            // 
            this.tlpBiomeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBiomeSettings.AutoScroll = true;
            this.tlpBiomeSettings.ColumnCount = 8;
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBiomeSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tlpBiomeSettings.Location = new System.Drawing.Point(217, 64);
            this.tlpBiomeSettings.Name = "tlpBiomeSettings";
            this.tlpBiomeSettings.RowCount = 1;
            this.tlpBiomeSettings.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBiomeSettings.Size = new System.Drawing.Size(894, 458);
            this.tlpBiomeSettings.TabIndex = 20;
            // 
            // lbBiomes
            // 
            this.lbBiomes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbBiomes.FormattingEnabled = true;
            this.lbBiomes.Location = new System.Drawing.Point(9, 354);
            this.lbBiomes.Name = "lbBiomes";
            this.lbBiomes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbBiomes.Size = new System.Drawing.Size(195, 160);
            this.lbBiomes.Sorted = true;
            this.lbBiomes.TabIndex = 0;
            this.lbBiomes.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 539);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Help";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox3.Controls.Add(this.richTextBox11);
            this.groupBox3.Controls.Add(this.richTextBox10);
            this.groupBox3.Controls.Add(this.richTextBox9);
            this.groupBox3.Controls.Add(this.richTextBox8);
            this.groupBox3.Controls.Add(this.richTextBox7);
            this.groupBox3.Controls.Add(this.richTextBox6);
            this.groupBox3.Controls.Add(this.richTextBox5);
            this.groupBox3.Controls.Add(this.richTextBox4);
            this.groupBox3.Controls.Add(this.richTextBox3);
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.textBox10);
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Location = new System.Drawing.Point(4, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1121, 526);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Help";
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Location = new System.Drawing.Point(20, 262);
            this.richTextBox9.Multiline = false;
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ReadOnly = true;
            this.richTextBox9.Size = new System.Drawing.Size(793, 23);
            this.richTextBox9.TabIndex = 23;
            this.richTextBox9.TabStop = false;
            this.richTextBox9.Text = "MCW/TCEE video tutorials: https://www.youtube.com/user/PeeGee85";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Location = new System.Drawing.Point(20, 239);
            this.richTextBox8.Multiline = false;
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(793, 23);
            this.richTextBox8.TabIndex = 22;
            this.richTextBox8.TabStop = false;
            this.richTextBox8.Text = "MCW forum thread:  http://forum.mctcp.com/t/minecraft-worlds-mod-beta-download/66" +
    "0/9";
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Location = new System.Drawing.Point(20, 216);
            this.richTextBox7.Multiline = false;
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ReadOnly = true;
            this.richTextBox7.Size = new System.Drawing.Size(793, 23);
            this.richTextBox7.TabIndex = 21;
            this.richTextBox7.TabStop = false;
            this.richTextBox7.Text = "MCW forum thread:  http://www.minecraftforum.net/forums/mapping-and-modding/minec" +
    "raft-tools/2592678-minecraft-worlds-ultimate-world-generator-tons-of";
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Location = new System.Drawing.Point(20, 193);
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(701, 23);
            this.richTextBox5.TabIndex = 19;
            this.richTextBox5.TabStop = false;
            this.richTextBox5.Text = "TCEE download & bugs thread: http://forum.mctcp.com/t/terraincontrol-editor-tcee-" +
    "beta-download-bugs-thread/561";
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Location = new System.Drawing.Point(20, 170);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(701, 23);
            this.richTextBox4.TabIndex = 18;
            this.richTextBox4.TabStop = false;
            this.richTextBox4.Text = "How to make TCEE work for any version of TC:  http://forum.mctcp.com/t/terraincon" +
    "trol-editor-tcee-how-to-make-it-work-for-any-version-of-tc/563/3";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(20, 27);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(701, 13);
            this.textBox10.TabIndex = 13;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "Resources:";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(20, 304);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(701, 13);
            this.textBox9.TabIndex = 12;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "Credits:";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.GhostWhite;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(20, 335);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(701, 13);
            this.textBox7.TabIndex = 10;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "TCEE:  PeeGee85";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(11, 80);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(105, 25);
            this.btSave.TabIndex = 26;
            this.btSave.Text = "Save settings";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(122, 80);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(109, 25);
            this.btLoad.TabIndex = 28;
            this.btLoad.Text = "Load settings";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // cbDeleteRegion
            // 
            this.cbDeleteRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbDeleteRegion.AutoSize = true;
            this.cbDeleteRegion.Checked = true;
            this.cbDeleteRegion.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleteRegion.Location = new System.Drawing.Point(237, 690);
            this.cbDeleteRegion.Name = "cbDeleteRegion";
            this.cbDeleteRegion.Size = new System.Drawing.Size(137, 17);
            this.cbDeleteRegion.TabIndex = 33;
            this.cbDeleteRegion.Text = "Delete /region directory";
            this.cbDeleteRegion.UseVisualStyleBackColor = true;
            this.cbDeleteRegion.Visible = false;
            // 
            // btnConvertSchematicToBO3
            // 
            this.btnConvertSchematicToBO3.Location = new System.Drawing.Point(367, 80);
            this.btnConvertSchematicToBO3.Name = "btnConvertSchematicToBO3";
            this.btnConvertSchematicToBO3.Size = new System.Drawing.Size(169, 25);
            this.btnConvertSchematicToBO3.TabIndex = 35;
            this.btnConvertSchematicToBO3.Text = "Convert .schematic to BO3";
            this.btnConvertSchematicToBO3.UseVisualStyleBackColor = true;
            this.btnConvertSchematicToBO3.Click += new System.EventHandler(this.btnConvertSchematicToBO3_Click);
            // 
            // btCopyBO3s
            // 
            this.btCopyBO3s.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btCopyBO3s.Location = new System.Drawing.Point(385, 685);
            this.btCopyBO3s.Name = "btCopyBO3s";
            this.btCopyBO3s.Size = new System.Drawing.Size(215, 25);
            this.btCopyBO3s.TabIndex = 36;
            this.btCopyBO3s.Text = "Copy structure files (BO3s)";
            this.btCopyBO3s.UseVisualStyleBackColor = true;
            this.btCopyBO3s.Visible = false;
            this.btCopyBO3s.Click += new System.EventHandler(this.btCopyBO3s_Click);
            // 
            // btImportWorld
            // 
            this.btImportWorld.Location = new System.Drawing.Point(237, 80);
            this.btImportWorld.Name = "btImportWorld";
            this.btImportWorld.Size = new System.Drawing.Size(126, 25);
            this.btImportWorld.TabIndex = 37;
            this.btImportWorld.Text = "Import world";
            this.btImportWorld.UseVisualStyleBackColor = true;
            this.btImportWorld.Click += new System.EventHandler(this.btImportWorld_Click);
            // 
            // rbSummerSkin
            // 
            this.rbSummerSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbSummerSkin.AutoSize = true;
            this.rbSummerSkin.Location = new System.Drawing.Point(606, 689);
            this.rbSummerSkin.Name = "rbSummerSkin";
            this.rbSummerSkin.Size = new System.Drawing.Size(87, 17);
            this.rbSummerSkin.TabIndex = 38;
            this.rbSummerSkin.Text = "Summer Skin";
            this.rbSummerSkin.UseVisualStyleBackColor = true;
            this.rbSummerSkin.Visible = false;
            this.rbSummerSkin.CheckedChanged += new System.EventHandler(this.rbSummerSkin_CheckedChanged);
            // 
            // rbWinterSkin
            // 
            this.rbWinterSkin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbWinterSkin.AutoSize = true;
            this.rbWinterSkin.Checked = true;
            this.rbWinterSkin.Location = new System.Drawing.Point(697, 689);
            this.rbWinterSkin.Name = "rbWinterSkin";
            this.rbWinterSkin.Size = new System.Drawing.Size(80, 17);
            this.rbWinterSkin.TabIndex = 39;
            this.rbWinterSkin.TabStop = true;
            this.rbWinterSkin.Text = "Winter Skin";
            this.rbWinterSkin.UseVisualStyleBackColor = true;
            this.rbWinterSkin.Visible = false;
            this.rbWinterSkin.CheckedChanged += new System.EventHandler(this.rbWinterSkin_CheckedChanged);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Location = new System.Drawing.Point(20, 358);
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(701, 22);
            this.richTextBox6.TabIndex = 20;
            this.richTextBox6.TabStop = false;
            this.richTextBox6.Text = "Most BO3s in the demonstration worlds were made using schematics from:  http://ww" +
    "w.minecraft-schematics.com/";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(20, 124);
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(701, 23);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.TabStop = false;
            this.richTextBox2.Text = "TerrainControl Wiki: https://github.com/MCTCP/TerrainControl/wiki";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Location = new System.Drawing.Point(20, 147);
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(701, 23);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.TabStop = false;
            this.richTextBox3.Text = "TerrainControl forums: http://forum.mctcp.com/";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(20, 101);
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(701, 23);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "TCEE tutorial: http://forum.mctcp.com/t/terraincontrol-editor-tcee-tutorials-thre" +
    "ad/562";
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.Location = new System.Drawing.Point(20, 55);
            this.richTextBox10.Multiline = false;
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.ReadOnly = true;
            this.richTextBox10.Size = new System.Drawing.Size(701, 23);
            this.richTextBox10.TabIndex = 24;
            this.richTextBox10.TabStop = false;
            this.richTextBox10.Text = "OTG wiki: http://openterraingen.wikia.com/wiki/Open_Terrain_Generator_Wiki";
            // 
            // richTextBox11
            // 
            this.richTextBox11.BackColor = System.Drawing.Color.GhostWhite;
            this.richTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox11.Location = new System.Drawing.Point(20, 78);
            this.richTextBox11.Multiline = false;
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.ReadOnly = true;
            this.richTextBox11.Size = new System.Drawing.Size(701, 23);
            this.richTextBox11.TabIndex = 25;
            this.richTextBox11.TabStop = false;
            this.richTextBox11.Text = "OTG reddit: https://www.reddit.com/r/openterraingen/";
            // 
            // btSelectSourceWorld
            // 
            this.btSelectSourceWorld.Location = new System.Drawing.Point(413, 28);
            this.btSelectSourceWorld.Name = "btSelectSourceWorld";
            this.btSelectSourceWorld.Size = new System.Drawing.Size(100, 23);
            this.btSelectSourceWorld.TabIndex = 8;
            this.btSelectSourceWorld.Text = "Select";
            this.btSelectSourceWorld.UseVisualStyleBackColor = true;
            this.btSelectSourceWorld.Click += new System.EventHandler(this.SelectSourceWorld_Click);
            // 
            // cbVersion
            // 
            this.cbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(12, 28);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(191, 21);
            this.cbVersion.TabIndex = 31;
            // 
            // cbWorld
            // 
            this.cbWorld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorld.FormattingEnabled = true;
            this.cbWorld.Location = new System.Drawing.Point(209, 28);
            this.cbWorld.Name = "cbWorld";
            this.cbWorld.Size = new System.Drawing.Size(198, 21);
            this.cbWorld.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbWorld);
            this.groupBox2.Controls.Add(this.cbVersion);
            this.groupBox2.Controls.Add(this.btSelectSourceWorld);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 61);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "TerrainControl / OTG version";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = global::TCEE.Properties.Resources.BGWinter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1163, 718);
            this.Controls.Add(this.rbWinterSkin);
            this.Controls.Add(this.rbSummerSkin);
            this.Controls.Add(this.btImportWorld);
            this.Controls.Add(this.btCopyBO3s);
            this.Controls.Add(this.btnConvertSchematicToBO3);
            this.Controls.Add(this.cbDeleteRegion);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btGenerate);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TerrainControl\'s Excellent Editor v1.0.10 2017";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tlpWorldSettings;
        private System.Windows.Forms.Button btSetToDefault;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lbBiomes;
        private System.Windows.Forms.TableLayoutPanel tlpBiomeSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btBiomeSettingsResetToDefaults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Label lblBiomesInGroup;
        private System.Windows.Forms.Label lblAvailableBioms;
        private System.Windows.Forms.ListBox lbGroup;
        private System.Windows.Forms.Button btRemoveFromGroup;
        private System.Windows.Forms.Button btAddToGroup;
        private System.Windows.Forms.Button btDeleteGroup;
        private System.Windows.Forms.Button btNewGroup;
        private System.Windows.Forms.Button btEditGroup;
        private System.Windows.Forms.Button btGroupMoveDown;
        private System.Windows.Forms.Button btGroupMoveUp;
        private System.Windows.Forms.CheckBox cbDeleteRegion;
        private System.Windows.Forms.Button btnConvertSchematicToBO3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.Button btCopyBO3s;
        private System.Windows.Forms.Button btImportWorld;
        private System.Windows.Forms.Button btCloneGroup;
        private System.Windows.Forms.RadioButton rbSummerSkin;
        private System.Windows.Forms.RadioButton rbWinterSkin;
        private System.Windows.Forms.RichTextBox richTextBox11;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btSelectSourceWorld;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.ComboBox cbWorld;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;

    }
}

