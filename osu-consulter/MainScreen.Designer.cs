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
            this.BTN_CONSULT = new System.Windows.Forms.Button();
            this.TXT_OSU_NAME = new System.Windows.Forms.TextBox();
            this.LBL_OSU_NAME = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_IMAGE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_CONSULT
            // 
            this.BTN_CONSULT.Location = new System.Drawing.Point(306, 187);
            this.BTN_CONSULT.Name = "BTN_CONSULT";
            this.BTN_CONSULT.Size = new System.Drawing.Size(157, 32);
            this.BTN_CONSULT.TabIndex = 0;
            this.BTN_CONSULT.Text = "Consult";
            this.BTN_CONSULT.UseVisualStyleBackColor = true;
            this.BTN_CONSULT.Click += new System.EventHandler(this.BTN_CONSULT_Click);
            // 
            // TXT_OSU_NAME
            // 
            this.TXT_OSU_NAME.Location = new System.Drawing.Point(306, 158);
            this.TXT_OSU_NAME.Name = "TXT_OSU_NAME";
            this.TXT_OSU_NAME.Size = new System.Drawing.Size(157, 23);
            this.TXT_OSU_NAME.TabIndex = 1;
            // 
            // LBL_OSU_NAME
            // 
            this.LBL_OSU_NAME.AutoSize = true;
            this.LBL_OSU_NAME.Location = new System.Drawing.Point(218, 161);
            this.LBL_OSU_NAME.Name = "LBL_OSU_NAME";
            this.LBL_OSU_NAME.Size = new System.Drawing.Size(88, 15);
            this.LBL_OSU_NAME.TabIndex = 2;
            this.LBL_OSU_NAME.Text = "Nome no osu! :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // PB_IMAGE
            // 
            this.PB_IMAGE.Location = new System.Drawing.Point(306, 225);
            this.PB_IMAGE.Name = "PB_IMAGE";
            this.PB_IMAGE.Size = new System.Drawing.Size(157, 141);
            this.PB_IMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_IMAGE.TabIndex = 4;
            this.PB_IMAGE.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PB_IMAGE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBL_OSU_NAME);
            this.Controls.Add(this.TXT_OSU_NAME);
            this.Controls.Add(this.BTN_CONSULT);
            this.Name = "MainScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PB_IMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BTN_CONSULT;
        private TextBox TXT_OSU_NAME;
        private Label LBL_OSU_NAME;
        private Label label1;
        private PictureBox PB_IMAGE;
    }
}