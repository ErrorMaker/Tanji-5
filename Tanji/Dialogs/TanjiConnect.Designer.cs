﻿namespace Tanji.Dialogs
{
    partial class TanjiConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TanjiConnect));
            this.MiddleGlowPnl = new System.Windows.Forms.Panel();
            this.ATimer = new System.Windows.Forms.Timer(this.components);
            this.ChooseClientDlg = new System.Windows.Forms.OpenFileDialog();
            this.StatusTxt = new System.Windows.Forms.Label();
            this.StatusLeftGlowPnl = new System.Windows.Forms.Panel();
            this.StatusRightGlowPnl = new System.Windows.Forms.Panel();
            this.ManualH = new System.Windows.Forms.Panel();
            this.AutomaticLbl = new System.Windows.Forms.Label();
            this.GameHostLbl = new System.Windows.Forms.Label();
            this.GamePortLbl = new System.Windows.Forms.Label();
            this.AutomaticH = new System.Windows.Forms.Panel();
            this.TopGlowPnl = new System.Windows.Forms.Panel();
            this.ExponentTxt = new System.Windows.Forms.TextBox();
            this.ExponentGrpbx = new System.Windows.Forms.GroupBox();
            this.CustomClientTxt = new System.Windows.Forms.TextBox();
            this.CustomChckbx = new System.Windows.Forms.CheckBox();
            this.FiddlerCoreGrpbx = new System.Windows.Forms.GroupBox();
            this.BrowseBtn = new Tanji.Components.TanjiButton();
            this.ModulusTxt = new System.Windows.Forms.TextBox();
            this.ModulusGrpbx = new System.Windows.Forms.GroupBox();
            this.GameHostTxt = new System.Windows.Forms.ComboBox();
            this.ManualLbl = new System.Windows.Forms.Label();
            this.GamePortTxt = new System.Windows.Forms.ComboBox();
            this.ProcessBtn = new Tanji.Components.TanjiButton();
            this.ExponentGrpbx.SuspendLayout();
            this.FiddlerCoreGrpbx.SuspendLayout();
            this.ModulusGrpbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // MiddleGlowPnl
            // 
            this.MiddleGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.MiddleGlowPnl.Location = new System.Drawing.Point(0, 192);
            this.MiddleGlowPnl.Name = "MiddleGlowPnl";
            this.MiddleGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.MiddleGlowPnl.TabIndex = 41;
            // 
            // ATimer
            // 
            this.ATimer.Interval = 200;
            this.ATimer.Tick += new System.EventHandler(this.ATimer_Tick);
            // 
            // ChooseClientDlg
            // 
            this.ChooseClientDlg.DefaultExt = "swf";
            this.ChooseClientDlg.Filter = "Shockwave Flash File (*.swf)|*.swf";
            this.ChooseClientDlg.Title = "Tanji ~ Choose Custom Client";
            // 
            // StatusTxt
            // 
            this.StatusTxt.Location = new System.Drawing.Point(20, 199);
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(191, 23);
            this.StatusTxt.TabIndex = 46;
            this.StatusTxt.Text = "Standing By...";
            this.StatusTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLeftGlowPnl
            // 
            this.StatusLeftGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusLeftGlowPnl.Location = new System.Drawing.Point(12, 199);
            this.StatusLeftGlowPnl.Name = "StatusLeftGlowPnl";
            this.StatusLeftGlowPnl.Size = new System.Drawing.Size(2, 23);
            this.StatusLeftGlowPnl.TabIndex = 58;
            // 
            // StatusRightGlowPnl
            // 
            this.StatusRightGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.StatusRightGlowPnl.Location = new System.Drawing.Point(217, 199);
            this.StatusRightGlowPnl.Name = "StatusRightGlowPnl";
            this.StatusRightGlowPnl.Size = new System.Drawing.Size(2, 23);
            this.StatusRightGlowPnl.TabIndex = 59;
            // 
            // ManualH
            // 
            this.ManualH.BackColor = System.Drawing.Color.Silver;
            this.ManualH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManualH.Location = new System.Drawing.Point(168, 31);
            this.ManualH.Name = "ManualH";
            this.ManualH.Size = new System.Drawing.Size(150, 2);
            this.ManualH.TabIndex = 45;
            this.ManualH.Click += new System.EventHandler(this.Manual_Click);
            // 
            // AutomaticLbl
            // 
            this.AutomaticLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutomaticLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutomaticLbl.Location = new System.Drawing.Point(12, 2);
            this.AutomaticLbl.Name = "AutomaticLbl";
            this.AutomaticLbl.Size = new System.Drawing.Size(150, 31);
            this.AutomaticLbl.TabIndex = 42;
            this.AutomaticLbl.Text = "Automatic";
            this.AutomaticLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutomaticLbl.Click += new System.EventHandler(this.Automatic_Click);
            // 
            // GameHostLbl
            // 
            this.GameHostLbl.AutoSize = true;
            this.GameHostLbl.Location = new System.Drawing.Point(9, 41);
            this.GameHostLbl.Name = "GameHostLbl";
            this.GameHostLbl.Size = new System.Drawing.Size(101, 13);
            this.GameHostLbl.TabIndex = 49;
            this.GameHostLbl.Text = "Game Host ( Mask )";
            // 
            // GamePortLbl
            // 
            this.GamePortLbl.AutoSize = true;
            this.GamePortLbl.Location = new System.Drawing.Point(165, 41);
            this.GamePortLbl.Name = "GamePortLbl";
            this.GamePortLbl.Size = new System.Drawing.Size(98, 13);
            this.GamePortLbl.TabIndex = 51;
            this.GamePortLbl.Text = "Game Port ( Mask )";
            // 
            // AutomaticH
            // 
            this.AutomaticH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.AutomaticH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AutomaticH.Location = new System.Drawing.Point(12, 31);
            this.AutomaticH.Name = "AutomaticH";
            this.AutomaticH.Size = new System.Drawing.Size(150, 2);
            this.AutomaticH.TabIndex = 44;
            this.AutomaticH.Click += new System.EventHandler(this.Automatic_Click);
            // 
            // TopGlowPnl
            // 
            this.TopGlowPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.TopGlowPnl.Location = new System.Drawing.Point(0, 83);
            this.TopGlowPnl.Name = "TopGlowPnl";
            this.TopGlowPnl.Size = new System.Drawing.Size(330, 1);
            this.TopGlowPnl.TabIndex = 48;
            // 
            // ExponentTxt
            // 
            this.ExponentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExponentTxt.Enabled = false;
            this.ExponentTxt.Location = new System.Drawing.Point(6, 19);
            this.ExponentTxt.Name = "ExponentTxt";
            this.ExponentTxt.Size = new System.Drawing.Size(77, 20);
            this.ExponentTxt.TabIndex = 0;
            this.ExponentTxt.TabStop = false;
            this.ExponentTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExponentGrpbx
            // 
            this.ExponentGrpbx.Controls.Add(this.ExponentTxt);
            this.ExponentGrpbx.Location = new System.Drawing.Point(12, 90);
            this.ExponentGrpbx.Name = "ExponentGrpbx";
            this.ExponentGrpbx.Size = new System.Drawing.Size(89, 45);
            this.ExponentGrpbx.TabIndex = 52;
            this.ExponentGrpbx.TabStop = false;
            this.ExponentGrpbx.Text = "Exponent ( e )";
            // 
            // CustomClientTxt
            // 
            this.CustomClientTxt.Enabled = false;
            this.CustomClientTxt.Location = new System.Drawing.Point(6, 19);
            this.CustomClientTxt.Name = "CustomClientTxt";
            this.CustomClientTxt.Size = new System.Drawing.Size(229, 20);
            this.CustomClientTxt.TabIndex = 0;
            this.CustomClientTxt.TabStop = false;
            // 
            // CustomChckbx
            // 
            this.CustomChckbx.AutoSize = true;
            this.CustomChckbx.Location = new System.Drawing.Point(235, -1);
            this.CustomChckbx.Name = "CustomChckbx";
            this.CustomChckbx.Size = new System.Drawing.Size(65, 17);
            this.CustomChckbx.TabIndex = 3;
            this.CustomChckbx.Text = "Enabled";
            this.CustomChckbx.UseVisualStyleBackColor = true;
            this.CustomChckbx.CheckedChanged += new System.EventHandler(this.CustomChckbx_CheckedChanged);
            // 
            // FiddlerCoreGrpbx
            // 
            this.FiddlerCoreGrpbx.Controls.Add(this.CustomChckbx);
            this.FiddlerCoreGrpbx.Controls.Add(this.BrowseBtn);
            this.FiddlerCoreGrpbx.Controls.Add(this.CustomClientTxt);
            this.FiddlerCoreGrpbx.Location = new System.Drawing.Point(12, 141);
            this.FiddlerCoreGrpbx.Name = "FiddlerCoreGrpbx";
            this.FiddlerCoreGrpbx.Size = new System.Drawing.Size(306, 45);
            this.FiddlerCoreGrpbx.TabIndex = 54;
            this.FiddlerCoreGrpbx.TabStop = false;
            this.FiddlerCoreGrpbx.Text = "Eavesdropper - Custom Client";
            // 
            // BrowseBtn
            // 
            this.BrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseBtn.BackColor = System.Drawing.Color.Transparent;
            this.BrowseBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BrowseBtn.Enabled = false;
            this.BrowseBtn.Location = new System.Drawing.Point(241, 19);
            this.BrowseBtn.Name = "BrowseBtn";
            this.BrowseBtn.Size = new System.Drawing.Size(59, 20);
            this.BrowseBtn.TabIndex = 2;
            this.BrowseBtn.TabStop = false;
            this.BrowseBtn.Text = "Browse";
            this.BrowseBtn.Click += new System.EventHandler(this.BrowseBtn_Click);
            // 
            // ModulusTxt
            // 
            this.ModulusTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ModulusTxt.Enabled = false;
            this.ModulusTxt.Location = new System.Drawing.Point(6, 19);
            this.ModulusTxt.Name = "ModulusTxt";
            this.ModulusTxt.Size = new System.Drawing.Size(199, 20);
            this.ModulusTxt.TabIndex = 0;
            this.ModulusTxt.TabStop = false;
            this.ModulusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModulusGrpbx
            // 
            this.ModulusGrpbx.Controls.Add(this.ModulusTxt);
            this.ModulusGrpbx.Location = new System.Drawing.Point(107, 90);
            this.ModulusGrpbx.Name = "ModulusGrpbx";
            this.ModulusGrpbx.Size = new System.Drawing.Size(211, 45);
            this.ModulusGrpbx.TabIndex = 53;
            this.ModulusGrpbx.TabStop = false;
            this.ModulusGrpbx.Text = "Modulus ( n )";
            // 
            // GameHostTxt
            // 
            this.GameHostTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GameHostTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GameHostTxt.FormattingEnabled = true;
            this.GameHostTxt.Items.AddRange(new object[] {
            "game-us.habbo.com",
            "game-br.habbo.com",
            "game-tr.habbo.com",
            "game-de.habbo.com",
            "game-dk.habbo.com",
            "game-es.habbo.com",
            "game-fi.habbo.com",
            "game-fr.habbo.com",
            "game-it.habbo.com",
            "game-nl.habbo.com",
            "game-no.habbo.com",
            "game-se.habbo.com"});
            this.GameHostTxt.Location = new System.Drawing.Point(12, 56);
            this.GameHostTxt.Name = "GameHostTxt";
            this.GameHostTxt.Size = new System.Drawing.Size(150, 21);
            this.GameHostTxt.TabIndex = 60;
            this.GameHostTxt.SelectedIndexChanged += new System.EventHandler(this.GameHostTxt_SelectedIndexChanged);
            // 
            // ManualLbl
            // 
            this.ManualLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManualLbl.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManualLbl.Location = new System.Drawing.Point(168, 2);
            this.ManualLbl.Name = "ManualLbl";
            this.ManualLbl.Size = new System.Drawing.Size(150, 31);
            this.ManualLbl.TabIndex = 43;
            this.ManualLbl.Text = "Manual";
            this.ManualLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ManualLbl.Click += new System.EventHandler(this.Manual_Click);
            // 
            // GamePortTxt
            // 
            this.GamePortTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GamePortTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GamePortTxt.FormattingEnabled = true;
            this.GamePortTxt.Items.AddRange(new object[] {
            "38101",
            "30000"});
            this.GamePortTxt.Location = new System.Drawing.Point(168, 56);
            this.GamePortTxt.Name = "GamePortTxt";
            this.GamePortTxt.Size = new System.Drawing.Size(150, 21);
            this.GamePortTxt.TabIndex = 61;
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProcessBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProcessBtn.Location = new System.Drawing.Point(225, 199);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(93, 23);
            this.ProcessBtn.TabIndex = 57;
            this.ProcessBtn.TabStop = false;
            this.ProcessBtn.Text = "Connect";
            this.ProcessBtn.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TanjiConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 234);
            this.Controls.Add(this.GamePortTxt);
            this.Controls.Add(this.GameHostTxt);
            this.Controls.Add(this.StatusRightGlowPnl);
            this.Controls.Add(this.StatusLeftGlowPnl);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.MiddleGlowPnl);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.ModulusGrpbx);
            this.Controls.Add(this.GamePortLbl);
            this.Controls.Add(this.ExponentGrpbx);
            this.Controls.Add(this.GameHostLbl);
            this.Controls.Add(this.TopGlowPnl);
            this.Controls.Add(this.ManualH);
            this.Controls.Add(this.AutomaticH);
            this.Controls.Add(this.ManualLbl);
            this.Controls.Add(this.AutomaticLbl);
            this.Controls.Add(this.FiddlerCoreGrpbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TanjiConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanji ~ Connection Setup [Automatic]";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TanjiConnect_FormClosing);
            this.Load += new System.EventHandler(this.TanjiConnect_Load);
            this.ExponentGrpbx.ResumeLayout(false);
            this.ExponentGrpbx.PerformLayout();
            this.FiddlerCoreGrpbx.ResumeLayout(false);
            this.FiddlerCoreGrpbx.PerformLayout();
            this.ModulusGrpbx.ResumeLayout(false);
            this.ModulusGrpbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MiddleGlowPnl;
        private System.Windows.Forms.Timer ATimer;
        private System.Windows.Forms.OpenFileDialog ChooseClientDlg;
        private System.Windows.Forms.Label StatusTxt;
        private Components.TanjiButton ProcessBtn;
        private System.Windows.Forms.Panel StatusLeftGlowPnl;
        private System.Windows.Forms.Panel StatusRightGlowPnl;
        private System.Windows.Forms.Panel ManualH;
        private System.Windows.Forms.Label AutomaticLbl;
        private System.Windows.Forms.Label GameHostLbl;
        private System.Windows.Forms.Label GamePortLbl;
        private System.Windows.Forms.Panel AutomaticH;
        private System.Windows.Forms.Panel TopGlowPnl;
        private System.Windows.Forms.TextBox ExponentTxt;
        private System.Windows.Forms.GroupBox ExponentGrpbx;
        private System.Windows.Forms.TextBox CustomClientTxt;
        private Components.TanjiButton BrowseBtn;
        private System.Windows.Forms.CheckBox CustomChckbx;
        private System.Windows.Forms.GroupBox FiddlerCoreGrpbx;
        private System.Windows.Forms.TextBox ModulusTxt;
        private System.Windows.Forms.GroupBox ModulusGrpbx;
        private System.Windows.Forms.ComboBox GameHostTxt;
        private System.Windows.Forms.Label ManualLbl;
        private System.Windows.Forms.ComboBox GamePortTxt;
    }
}