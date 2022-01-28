namespace Activity_8
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
            this.FatLbl = new System.Windows.Forms.Label();
            this.CarbsLbl = new System.Windows.Forms.Label();
            this.FatTxb = new System.Windows.Forms.TextBox();
            this.CarbsTxb = new System.Windows.Forms.TextBox();
            this.CalBtn = new System.Windows.Forms.Button();
            this.CalLbl = new System.Windows.Forms.Label();
            this.CalTxb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FatLbl
            // 
            this.FatLbl.AutoSize = true;
            this.FatLbl.Location = new System.Drawing.Point(95, 55);
            this.FatLbl.Name = "FatLbl";
            this.FatLbl.Size = new System.Drawing.Size(150, 16);
            this.FatLbl.TabIndex = 0;
            this.FatLbl.Text = "Number of fat grams (gr)";
            // 
            // CarbsLbl
            // 
            this.CarbsLbl.AutoSize = true;
            this.CarbsLbl.Location = new System.Drawing.Point(95, 99);
            this.CarbsLbl.Name = "CarbsLbl";
            this.CarbsLbl.Size = new System.Drawing.Size(170, 16);
            this.CarbsLbl.TabIndex = 1;
            this.CarbsLbl.Text = "Number of carbs grams (gr)";
            // 
            // FatTxb
            // 
            this.FatTxb.Location = new System.Drawing.Point(317, 52);
            this.FatTxb.Name = "FatTxb";
            this.FatTxb.Size = new System.Drawing.Size(100, 22);
            this.FatTxb.TabIndex = 2;
            // 
            // CarbsTxb
            // 
            this.CarbsTxb.Location = new System.Drawing.Point(317, 99);
            this.CarbsTxb.Name = "CarbsTxb";
            this.CarbsTxb.Size = new System.Drawing.Size(100, 22);
            this.CarbsTxb.TabIndex = 3;
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(98, 148);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(82, 23);
            this.CalBtn.TabIndex = 4;
            this.CalBtn.Text = "Calculate";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // CalLbl
            // 
            this.CalLbl.AutoSize = true;
            this.CalLbl.Location = new System.Drawing.Point(218, 151);
            this.CalLbl.Name = "CalLbl";
            this.CalLbl.Size = new System.Drawing.Size(57, 16);
            this.CalLbl.TabIndex = 5;
            this.CalLbl.Text = "Calories";
            // 
            // CalTxb
            // 
            this.CalTxb.Location = new System.Drawing.Point(317, 145);
            this.CalTxb.Name = "CalTxb";
            this.CalTxb.Size = new System.Drawing.Size(100, 22);
            this.CalTxb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 231);
            this.Controls.Add(this.CalTxb);
            this.Controls.Add(this.CalLbl);
            this.Controls.Add(this.CalBtn);
            this.Controls.Add(this.CarbsTxb);
            this.Controls.Add(this.FatTxb);
            this.Controls.Add(this.CarbsLbl);
            this.Controls.Add(this.FatLbl);
            this.Name = "Form1";
            this.Text = "Calories";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FatLbl;
        private System.Windows.Forms.Label CarbsLbl;
        private System.Windows.Forms.TextBox FatTxb;
        private System.Windows.Forms.TextBox CarbsTxb;
        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.Label CalLbl;
        private System.Windows.Forms.TextBox CalTxb;
    }
}

