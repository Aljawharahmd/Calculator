namespace Calculator
{
    partial class CalculateSquare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateSquare));
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.ResultLbl = new System.Windows.Forms.Label();
            this.AreaTxt = new System.Windows.Forms.TextBox();
            this.AreaLbl = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResultTxt
            // 
            this.ResultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxt.Location = new System.Drawing.Point(49, 348);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(360, 56);
            this.ResultTxt.TabIndex = 18;
            // 
            // ResultLbl
            // 
            this.ResultLbl.AutoSize = true;
            this.ResultLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.ResultLbl.Location = new System.Drawing.Point(147, 264);
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Size = new System.Drawing.Size(174, 89);
            this.ResultLbl.TabIndex = 17;
            this.ResultLbl.Text = "Result";
            // 
            // AreaTxt
            // 
            this.AreaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaTxt.Location = new System.Drawing.Point(45, 167);
            this.AreaTxt.Name = "AreaTxt";
            this.AreaTxt.Size = new System.Drawing.Size(360, 56);
            this.AreaTxt.TabIndex = 14;
            // 
            // AreaLbl
            // 
            this.AreaLbl.AutoSize = true;
            this.AreaLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.AreaLbl.Location = new System.Drawing.Point(164, 64);
            this.AreaLbl.Name = "AreaLbl";
            this.AreaLbl.Size = new System.Drawing.Size(140, 89);
            this.AreaLbl.TabIndex = 13;
            this.AreaLbl.Text = "Area";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.CalculateBtn.Location = new System.Drawing.Point(97, 441);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(258, 77);
            this.CalculateBtn.TabIndex = 12;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateSquare_Click);
            // 
            // CalculateSquare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.ResultTxt);
            this.Controls.Add(this.ResultLbl);
            this.Controls.Add(this.AreaTxt);
            this.Controls.Add(this.AreaLbl);
            this.Controls.Add(this.CalculateBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculateSquare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Square";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.TextBox AreaTxt;
        private System.Windows.Forms.Label AreaLbl;
        private System.Windows.Forms.Button CalculateBtn;
    }
}