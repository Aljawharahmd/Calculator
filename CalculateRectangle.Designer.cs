namespace Calculator
{
    partial class CalculateRectangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateRectangle));
            this.RecHeightTxt = new System.Windows.Forms.TextBox();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.RecWidthTxt = new System.Windows.Forms.TextBox();
            this.WidthLbl = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.RecResultTxt = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecHeightTxt
            // 
            this.RecHeightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecHeightTxt.Location = new System.Drawing.Point(49, 274);
            this.RecHeightTxt.Name = "RecHeightTxt";
            this.RecHeightTxt.Size = new System.Drawing.Size(360, 56);
            this.RecHeightTxt.TabIndex = 9;
            this.RecHeightTxt.TextChanged += new System.EventHandler(this.RecHeightTxt_TextChanged);
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.HeightLbl.Location = new System.Drawing.Point(147, 177);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(177, 89);
            this.HeightLbl.TabIndex = 8;
            this.HeightLbl.Text = "Height";
            this.HeightLbl.Click += new System.EventHandler(this.HeightLbl_Click);
            // 
            // RecWidthTxt
            // 
            this.RecWidthTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecWidthTxt.Location = new System.Drawing.Point(49, 105);
            this.RecWidthTxt.Name = "RecWidthTxt";
            this.RecWidthTxt.Size = new System.Drawing.Size(360, 56);
            this.RecWidthTxt.TabIndex = 7;
            this.RecWidthTxt.TextChanged += new System.EventHandler(this.RecWidthTxt_TextChanged);
            // 
            // WidthLbl
            // 
            this.WidthLbl.AutoSize = true;
            this.WidthLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.WidthLbl.Location = new System.Drawing.Point(151, 30);
            this.WidthLbl.Name = "WidthLbl";
            this.WidthLbl.Size = new System.Drawing.Size(161, 89);
            this.WidthLbl.TabIndex = 6;
            this.WidthLbl.Text = "Width";
            this.WidthLbl.Click += new System.EventHandler(this.WidthLbl_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CalculateBtn.Location = new System.Drawing.Point(97, 490);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(258, 77);
            this.CalculateBtn.TabIndex = 5;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateRec_Click);
            // 
            // RecResultTxt
            // 
            this.RecResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecResultTxt.Location = new System.Drawing.Point(49, 415);
            this.RecResultTxt.Name = "RecResultTxt";
            this.RecResultTxt.Size = new System.Drawing.Size(360, 56);
            this.RecResultTxt.TabIndex = 11;
            this.RecResultTxt.TextChanged += new System.EventHandler(this.RecResultTxt_TextChanged);
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ResultLbl.Location = new System.Drawing.Point(147, 333);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(174, 89);
            this.ResultLbl.TabIndex = 10;
            this.ResultLbl.Text = "Result";
            this.ResultLbl.Click += new System.EventHandler(this.ResultLbl_Click);
            // 
            // CalculateRectangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.RecResultTxt);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.RecHeightTxt);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.RecWidthTxt);
            this.Controls.Add(this.WidthLbl);
            this.Controls.Add(this.CalculateBtn);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculateRectangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Rectangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RecHeightTxt;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox RecWidthTxt;
        private System.Windows.Forms.Label WidthLbl;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.TextBox RecResultTxt;
        private System.Windows.Forms.Label ResultLbl;
    }
}