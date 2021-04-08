namespace Calculator
{
    partial class CalculateTriangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateTriangle));
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.HeightTxt = new System.Windows.Forms.TextBox();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.BaseTxt = new System.Windows.Forms.TextBox();
            this.BaseLbl = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTxt
            // 
            this.ResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxt.Location = new System.Drawing.Point(49, 419);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(360, 56);
            this.ResultTxt.TabIndex = 18;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ResultLbl.Location = new System.Drawing.Point(147, 336);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(174, 89);
            this.ResultLbl.TabIndex = 17;
            this.ResultLbl.Text = "Result";
            // 
            // HeightTxt
            // 
            this.HeightTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightTxt.Location = new System.Drawing.Point(49, 276);
            this.HeightTxt.Name = "HeightTxt";
            this.HeightTxt.Size = new System.Drawing.Size(360, 56);
            this.HeightTxt.TabIndex = 16;
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.HeightLbl.Location = new System.Drawing.Point(54, 182);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(355, 89);
            this.HeightLbl.TabIndex = 15;
            this.HeightLbl.Text = "Vertical Height";
            // 
            // BaseTxt
            // 
            this.BaseTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseTxt.Location = new System.Drawing.Point(49, 107);
            this.BaseTxt.Name = "BaseTxt";
            this.BaseTxt.Size = new System.Drawing.Size(360, 56);
            this.BaseTxt.TabIndex = 14;
            // 
            // BaseLbl
            // 
            this.BaseLbl.AutoSize = true;
            this.BaseLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaseLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.BaseLbl.Location = new System.Drawing.Point(151, 26);
            this.BaseLbl.Name = "BaseLbl";
            this.BaseLbl.Size = new System.Drawing.Size(148, 89);
            this.BaseLbl.TabIndex = 13;
            this.BaseLbl.Text = "Base";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CalculateBtn.Location = new System.Drawing.Point(97, 492);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(258, 77);
            this.CalculateBtn.TabIndex = 12;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateTrianle_Click);
            // 
            // CalculateTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.HeightTxt);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.BaseTxt);
            this.Controls.Add(this.BaseLbl);
            this.Controls.Add(this.CalculateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculateTriangle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Triangle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.TextBox HeightTxt;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.TextBox BaseTxt;
        private System.Windows.Forms.Label BaseLbl;
        private System.Windows.Forms.Button CalculateBtn;
    }
}