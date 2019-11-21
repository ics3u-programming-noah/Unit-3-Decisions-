namespace Walking_Man_Noah
{
    partial class WalkingManForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.picWalkingMan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(355, 189);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // picWalkingMan
            // 
            this.picWalkingMan.Image = global::Walking_Man_Noah.Properties.Resources.walk10;
            this.picWalkingMan.Location = new System.Drawing.Point(533, 95);
            this.picWalkingMan.Name = "picWalkingMan";
            this.picWalkingMan.Size = new System.Drawing.Size(186, 214);
            this.picWalkingMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWalkingMan.TabIndex = 2;
            this.picWalkingMan.TabStop = false;
            this.picWalkingMan.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // WalkingManForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picWalkingMan);
            this.Controls.Add(this.btnStart);
            this.Name = "WalkingManForm";
            this.Text = "Walking Man by Noah";
            this.Load += new System.EventHandler(this.WalkingManForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWalkingMan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picWalkingMan;
    }
}

