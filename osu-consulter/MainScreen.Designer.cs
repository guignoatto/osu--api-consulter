﻿namespace osu_consulter
{
    partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_CONSULT_BEATMAP = new System.Windows.Forms.Button();
            this.TXT_GLOBAL_RANK = new System.Windows.Forms.TextBox();
            this.LBL_GLOBAL_RANKING = new System.Windows.Forms.Label();
            this.LBL_BEATMAP_RANK = new System.Windows.Forms.Label();
            this.PB_IMAGE = new System.Windows.Forms.PictureBox();
            this.TXT_USER_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_BEATMAP_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_GET_ACCESS_TOKEN = new System.Windows.Forms.Button();
            this.PB_BG_IMAGE = new System.Windows.Forms.PictureBox();
            this.BTN_CONSULT_USER = new System.Windows.Forms.Button();
            this.LBL_COUNTRY_RANK = new System.Windows.Forms.Label();
            this.TXT_COUNTRY_RANK = new System.Windows.Forms.TextBox();
            this.TXT_USERNAME_SHOW = new System.Windows.Forms.TextBox();
            this.BTN_TEST_CONNECTION = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_COUNTRY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BG_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CONSULT_BEATMAP
            // 
            this.BTN_CONSULT_BEATMAP.Location = new System.Drawing.Point(112, 372);
            this.BTN_CONSULT_BEATMAP.Name = "BTN_CONSULT_BEATMAP";
            this.BTN_CONSULT_BEATMAP.Size = new System.Drawing.Size(157, 32);
            this.BTN_CONSULT_BEATMAP.TabIndex = 0;
            this.BTN_CONSULT_BEATMAP.Text = "Consult";
            this.BTN_CONSULT_BEATMAP.UseVisualStyleBackColor = true;
            this.BTN_CONSULT_BEATMAP.Click += new System.EventHandler(this.BTN_CONSULT_Click);
            // 
            // TXT_GLOBAL_RANK
            // 
            this.TXT_GLOBAL_RANK.Location = new System.Drawing.Point(112, 243);
            this.TXT_GLOBAL_RANK.Name = "TXT_GLOBAL_RANK";
            this.TXT_GLOBAL_RANK.ReadOnly = true;
            this.TXT_GLOBAL_RANK.Size = new System.Drawing.Size(157, 23);
            this.TXT_GLOBAL_RANK.TabIndex = 1;
            // 
            // LBL_GLOBAL_RANKING
            // 
            this.LBL_GLOBAL_RANKING.AutoSize = true;
            this.LBL_GLOBAL_RANKING.Location = new System.Drawing.Point(35, 251);
            this.LBL_GLOBAL_RANKING.Name = "LBL_GLOBAL_RANKING";
            this.LBL_GLOBAL_RANKING.Size = new System.Drawing.Size(70, 15);
            this.LBL_GLOBAL_RANKING.TabIndex = 2;
            this.LBL_GLOBAL_RANKING.Text = "Global rank:";
            this.LBL_GLOBAL_RANKING.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LBL_BEATMAP_RANK
            // 
            this.LBL_BEATMAP_RANK.AutoSize = true;
            this.LBL_BEATMAP_RANK.Location = new System.Drawing.Point(112, 173);
            this.LBL_BEATMAP_RANK.Name = "LBL_BEATMAP_RANK";
            this.LBL_BEATMAP_RANK.Size = new System.Drawing.Size(0, 15);
            this.LBL_BEATMAP_RANK.TabIndex = 3;
            // 
            // PB_IMAGE
            // 
            this.PB_IMAGE.Location = new System.Drawing.Point(496, 183);
            this.PB_IMAGE.Name = "PB_IMAGE";
            this.PB_IMAGE.Size = new System.Drawing.Size(157, 157);
            this.PB_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMAGE.TabIndex = 4;
            this.PB_IMAGE.TabStop = false;
            this.PB_IMAGE.WaitOnLoad = true;
            // 
            // TXT_USER_ID
            // 
            this.TXT_USER_ID.Location = new System.Drawing.Point(112, 104);
            this.TXT_USER_ID.Name = "TXT_USER_ID";
            this.TXT_USER_ID.Size = new System.Drawing.Size(157, 23);
            this.TXT_USER_ID.TabIndex = 5;
            this.TXT_USER_ID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TXT_USER_ID_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "User ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Beatmap ID";
            // 
            // TXT_BEATMAP_ID
            // 
            this.TXT_BEATMAP_ID.Location = new System.Drawing.Point(112, 132);
            this.TXT_BEATMAP_ID.Name = "TXT_BEATMAP_ID";
            this.TXT_BEATMAP_ID.Size = new System.Drawing.Size(157, 23);
            this.TXT_BEATMAP_ID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Beatmap rank:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BT_GET_ACCESS_TOKEN
            // 
            this.BT_GET_ACCESS_TOKEN.Location = new System.Drawing.Point(112, 66);
            this.BT_GET_ACCESS_TOKEN.Name = "BT_GET_ACCESS_TOKEN";
            this.BT_GET_ACCESS_TOKEN.Size = new System.Drawing.Size(114, 23);
            this.BT_GET_ACCESS_TOKEN.TabIndex = 10;
            this.BT_GET_ACCESS_TOKEN.Text = "Get Access Token";
            this.BT_GET_ACCESS_TOKEN.UseVisualStyleBackColor = true;
            this.BT_GET_ACCESS_TOKEN.Click += new System.EventHandler(this.BT_GET_ACCESS_TOKEN_Click);
            // 
            // PB_BG_IMAGE
            // 
            this.PB_BG_IMAGE.Location = new System.Drawing.Point(390, 66);
            this.PB_BG_IMAGE.Name = "PB_BG_IMAGE";
            this.PB_BG_IMAGE.Size = new System.Drawing.Size(408, 157);
            this.PB_BG_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BG_IMAGE.TabIndex = 11;
            this.PB_BG_IMAGE.TabStop = false;
            this.PB_BG_IMAGE.WaitOnLoad = true;
            // 
            // BTN_CONSULT_USER
            // 
            this.BTN_CONSULT_USER.Location = new System.Drawing.Point(112, 334);
            this.BTN_CONSULT_USER.Name = "BTN_CONSULT_USER";
            this.BTN_CONSULT_USER.Size = new System.Drawing.Size(157, 32);
            this.BTN_CONSULT_USER.TabIndex = 12;
            this.BTN_CONSULT_USER.Text = "Consult User";
            this.BTN_CONSULT_USER.UseVisualStyleBackColor = true;
            this.BTN_CONSULT_USER.Click += new System.EventHandler(this.BTN_CONSULT_USER_Click);
            // 
            // LBL_COUNTRY_RANK
            // 
            this.LBL_COUNTRY_RANK.AutoSize = true;
            this.LBL_COUNTRY_RANK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LBL_COUNTRY_RANK.Location = new System.Drawing.Point(26, 280);
            this.LBL_COUNTRY_RANK.Name = "LBL_COUNTRY_RANK";
            this.LBL_COUNTRY_RANK.Size = new System.Drawing.Size(79, 15);
            this.LBL_COUNTRY_RANK.TabIndex = 14;
            this.LBL_COUNTRY_RANK.Text = "Country rank:";
            this.LBL_COUNTRY_RANK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_COUNTRY_RANK
            // 
            this.TXT_COUNTRY_RANK.Location = new System.Drawing.Point(112, 272);
            this.TXT_COUNTRY_RANK.Name = "TXT_COUNTRY_RANK";
            this.TXT_COUNTRY_RANK.ReadOnly = true;
            this.TXT_COUNTRY_RANK.Size = new System.Drawing.Size(157, 23);
            this.TXT_COUNTRY_RANK.TabIndex = 13;
            // 
            // TXT_USERNAME_SHOW
            // 
            this.TXT_USERNAME_SHOW.Location = new System.Drawing.Point(496, 346);
            this.TXT_USERNAME_SHOW.Name = "TXT_USERNAME_SHOW";
            this.TXT_USERNAME_SHOW.ReadOnly = true;
            this.TXT_USERNAME_SHOW.Size = new System.Drawing.Size(157, 23);
            this.TXT_USERNAME_SHOW.TabIndex = 15;
            this.TXT_USERNAME_SHOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BTN_TEST_CONNECTION
            // 
            this.BTN_TEST_CONNECTION.Location = new System.Drawing.Point(275, 334);
            this.BTN_TEST_CONNECTION.Name = "BTN_TEST_CONNECTION";
            this.BTN_TEST_CONNECTION.Size = new System.Drawing.Size(157, 32);
            this.BTN_TEST_CONNECTION.TabIndex = 16;
            this.BTN_TEST_CONNECTION.Text = "Test sql connection";
            this.BTN_TEST_CONNECTION.UseVisualStyleBackColor = true;
            this.BTN_TEST_CONNECTION.Click += new System.EventHandler(this.BTN_TEST_CONNECTION_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(52, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Country:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TXT_COUNTRY
            // 
            this.TXT_COUNTRY.Location = new System.Drawing.Point(112, 301);
            this.TXT_COUNTRY.Name = "TXT_COUNTRY";
            this.TXT_COUNTRY.ReadOnly = true;
            this.TXT_COUNTRY.Size = new System.Drawing.Size(157, 23);
            this.TXT_COUNTRY.TabIndex = 18;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 485);
            this.Controls.Add(this.TXT_COUNTRY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_TEST_CONNECTION);
            this.Controls.Add(this.TXT_USERNAME_SHOW);
            this.Controls.Add(this.LBL_COUNTRY_RANK);
            this.Controls.Add(this.TXT_COUNTRY_RANK);
            this.Controls.Add(this.BTN_CONSULT_USER);
            this.Controls.Add(this.BT_GET_ACCESS_TOKEN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_BEATMAP_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_USER_ID);
            this.Controls.Add(this.PB_IMAGE);
            this.Controls.Add(this.LBL_BEATMAP_RANK);
            this.Controls.Add(this.LBL_GLOBAL_RANKING);
            this.Controls.Add(this.TXT_GLOBAL_RANK);
            this.Controls.Add(this.BTN_CONSULT_BEATMAP);
            this.Controls.Add(this.PB_BG_IMAGE);
            this.Name = "MainScreen";
            this.Text = "\'\'";
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BG_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_CONSULT_BEATMAP;
        private TextBox TXT_GLOBAL_RANK;
        private Label LBL_GLOBAL_RANKING;
        private Label LBL_BEATMAP_RANK;
        private PictureBox PB_IMAGE;
        private TextBox TXT_USER_ID;
        private Label label2;
        private Label label3;
        private TextBox TXT_BEATMAP_ID;
        private Label label4;
        private Button BT_GET_ACCESS_TOKEN;
        private PictureBox PB_BG_IMAGE;
        private Button BTN_CONSULT_USER;
        private Label LBL_COUNTRY_RANK;
        private TextBox TXT_COUNTRY_RANK;
        private TextBox TXT_USERNAME_SHOW;
        private Button BTN_TEST_CONNECTION;
        private Label label1;
        private TextBox TXT_COUNTRY;
    }
}