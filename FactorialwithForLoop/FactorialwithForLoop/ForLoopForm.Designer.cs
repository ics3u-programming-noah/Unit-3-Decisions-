namespace FactorialwithForLoop
{
    partial class frmForLoop
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblEnterNum = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtFactorial = new System.Windows.Forms.TextBox();
            this.lstFactorial = new System.Windows.Forms.ListBox();
            this.lblFactAnswer = new System.Windows.Forms.Label();
            this.lblFactorialAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(375, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblEnterNum
            // 
            this.lblEnterNum.AutoSize = true;
            this.lblEnterNum.Location = new System.Drawing.Point(89, 115);
            this.lblEnterNum.Name = "lblEnterNum";
            this.lblEnterNum.Size = new System.Drawing.Size(93, 13);
            this.lblEnterNum.TabIndex = 1;
            this.lblEnterNum.Text = "Enter the Number:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(110, 353);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblAnswer.TabIndex = 2;
            // 
            // txtFactorial
            // 
            this.txtFactorial.Location = new System.Drawing.Point(593, 112);
            this.txtFactorial.Name = "txtFactorial";
            this.txtFactorial.Size = new System.Drawing.Size(100, 20);
            this.txtFactorial.TabIndex = 3;
            // 
            // lstFactorial
            // 
            this.lstFactorial.FormattingEnabled = true;
            this.lstFactorial.Location = new System.Drawing.Point(375, 296);
            this.lstFactorial.Name = "lstFactorial";
            this.lstFactorial.Size = new System.Drawing.Size(120, 95);
            this.lstFactorial.TabIndex = 4;
            // 
            // lblFactAnswer
            // 
            this.lblFactAnswer.AutoSize = true;
            this.lblFactAnswer.Location = new System.Drawing.Point(75, 340);
            this.lblFactAnswer.Name = "lblFactAnswer";
            this.lblFactAnswer.Size = new System.Drawing.Size(35, 13);
            this.lblFactAnswer.TabIndex = 5;
            this.lblFactAnswer.Text = "label1";
            // 
            // lblFactorialAnswer
            // 
            this.lblFactorialAnswer.AutoSize = true;
            this.lblFactorialAnswer.Location = new System.Drawing.Point(64, 232);
            this.lblFactorialAnswer.Name = "lblFactorialAnswer";
            this.lblFactorialAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblFactorialAnswer.TabIndex = 6;
            // 
            // frmForLoop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFactorialAnswer);
            this.Controls.Add(this.lblFactAnswer);
            this.Controls.Add(this.lstFactorial);
            this.Controls.Add(this.txtFactorial);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblEnterNum);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmForLoop";
            this.Text = "Factorial with For Loop by Noah";
            this.Load += new System.EventHandler(this.FrmForLoop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblEnterNum;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtFactorial;
        private System.Windows.Forms.ListBox lstFactorial;
        private System.Windows.Forms.Label lblFactAnswer;
        private System.Windows.Forms.Label lblFactorialAnswer;
    }
}

