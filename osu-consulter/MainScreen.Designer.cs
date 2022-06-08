namespace osu_consulter
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
            this.TXT_OSU_NAME = new System.Windows.Forms.TextBox();
            this.LBL_OSU_NAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_IMAGE = new System.Windows.Forms.PictureBox();
            this.TXT_USER_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_BEATMAP_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_GET_ACCESS_TOKEN = new System.Windows.Forms.Button();
            this.PB_BG_IMAGE = new System.Windows.Forms.PictureBox();
            this.BTN_CONSULT_USER = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BG_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CONSULT_BEATMAP
            // 
            this.BTN_CONSULT_BEATMAP.Location = new System.Drawing.Point(112, 329);
            this.BTN_CONSULT_BEATMAP.Name = "BTN_CONSULT_BEATMAP";
            this.BTN_CONSULT_BEATMAP.Size = new System.Drawing.Size(157, 32);
            this.BTN_CONSULT_BEATMAP.TabIndex = 0;
            this.BTN_CONSULT_BEATMAP.Text = "Consult";
            this.BTN_CONSULT_BEATMAP.UseVisualStyleBackColor = true;
            this.BTN_CONSULT_BEATMAP.Click += new System.EventHandler(this.BTN_CONSULT_Click);
            // 
            // TXT_OSU_NAME
            // 
            this.TXT_OSU_NAME.Location = new System.Drawing.Point(112, 243);
            this.TXT_OSU_NAME.Name = "TXT_OSU_NAME";
            this.TXT_OSU_NAME.Size = new System.Drawing.Size(157, 23);
            this.TXT_OSU_NAME.TabIndex = 1;
            // 
            // LBL_OSU_NAME
            // 
            this.LBL_OSU_NAME.AutoSize = true;
            this.LBL_OSU_NAME.Location = new System.Drawing.Point(18, 251);
            this.LBL_OSU_NAME.Name = "LBL_OSU_NAME";
            this.LBL_OSU_NAME.Size = new System.Drawing.Size(88, 15);
            this.LBL_OSU_NAME.TabIndex = 2;
            this.LBL_OSU_NAME.Text = "Nome no osu! :";
            this.LBL_OSU_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
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
            this.label4.Location = new System.Drawing.Point(40, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Colocação:";
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
            this.PB_BG_IMAGE.Location = new System.Drawing.Point(367, 66);
            this.PB_BG_IMAGE.Name = "PB_BG_IMAGE";
            this.PB_BG_IMAGE.Size = new System.Drawing.Size(408, 157);
            this.PB_BG_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_BG_IMAGE.TabIndex = 11;
            this.PB_BG_IMAGE.TabStop = false;
            this.PB_BG_IMAGE.WaitOnLoad = true;
            // 
            // BTN_CONSULT_USER
            // 
            this.BTN_CONSULT_USER.Location = new System.Drawing.Point(112, 291);
            this.BTN_CONSULT_USER.Name = "BTN_CONSULT_USER";
            this.BTN_CONSULT_USER.Size = new System.Drawing.Size(157, 32);
            this.BTN_CONSULT_USER.TabIndex = 12;
            this.BTN_CONSULT_USER.Text = "Consult User";
            this.BTN_CONSULT_USER.UseVisualStyleBackColor = true;
            this.BTN_CONSULT_USER.Click += new System.EventHandler(this.BTN_CONSULT_USER_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_CONSULT_USER);
            this.Controls.Add(this.BT_GET_ACCESS_TOKEN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXT_BEATMAP_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXT_USER_ID);
            this.Controls.Add(this.PB_IMAGE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_OSU_NAME);
            this.Controls.Add(this.TXT_OSU_NAME);
            this.Controls.Add(this.BTN_CONSULT_BEATMAP);
            this.Controls.Add(this.PB_BG_IMAGE);
            this.Name = "MainScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_BG_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_CONSULT_BEATMAP;
        private TextBox TXT_OSU_NAME;
        private Label LBL_OSU_NAME;
        private Label label1;
        private PictureBox PB_IMAGE;
        private TextBox TXT_USER_ID;
        private Label label2;
        private Label label3;
        private TextBox TXT_BEATMAP_ID;
        private Label label4;
        private Button BT_GET_ACCESS_TOKEN;
        private PictureBox PB_BG_IMAGE;
        private Button BTN_CONSULT_USER;
    }
}