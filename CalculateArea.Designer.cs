namespace Calculator
{
    partial class CalculateArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculateArea));
            this.label1 = new System.Windows.Forms.Label();
            this.RecBtn = new System.Windows.Forms.Button();
            this.squareBtn = new System.Windows.Forms.Button();
            this.TriangleArea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simplified Arabic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select the Shape";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RecBtn
            // 
            this.RecBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RecBtn.BackgroundImage")));
            this.RecBtn.Font = new System.Drawing.Font("Simplified Arabic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.RecBtn.Location = new System.Drawing.Point(1, 92);
            this.RecBtn.Name = "RecBtn";
            this.RecBtn.Size = new System.Drawing.Size(456, 133);
            this.RecBtn.TabIndex = 1;
            this.RecBtn.Text = "Rectangle Area";
            this.RecBtn.UseVisualStyleBackColor = true;
            this.RecBtn.Click += new System.EventHandler(this.RecBtn_Click);
            // 
            // squareBtn
            // 
            this.squareBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("squareBtn.BackgroundImage")));
            this.squareBtn.Font = new System.Drawing.Font("Simplified Arabic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.squareBtn.Location = new System.Drawing.Point(1, 267);
            this.squareBtn.Name = "squareBtn";
            this.squareBtn.Size = new System.Drawing.Size(456, 133);
            this.squareBtn.TabIndex = 2;
            this.squareBtn.Text = "Square Area";
            this.squareBtn.UseVisualStyleBackColor = true;
            this.squareBtn.Click += new System.EventHandler(this.squareBtn_Click);
            // 
            // TriangleArea
            // 
            this.TriangleArea.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TriangleArea.BackgroundImage")));
            this.TriangleArea.Font = new System.Drawing.Font("Simplified Arabic", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TriangleArea.ForeColor = System.Drawing.Color.SaddleBrown;
            this.TriangleArea.Location = new System.Drawing.Point(1, 434);
            this.TriangleArea.Name = "TriangleArea";
            this.TriangleArea.Size = new System.Drawing.Size(456, 133);
            this.TriangleArea.TabIndex = 3;
            this.TriangleArea.Text = "Triangle Area";
            this.TriangleArea.UseVisualStyleBackColor = true;
            this.TriangleArea.Click += new System.EventHandler(this.TriangleArea_Click);
            // 
            // CalculateArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.TriangleArea);
            this.Controls.Add(this.squareBtn);
            this.Controls.Add(this.RecBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalculateArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RecBtn;
        private System.Windows.Forms.Button squareBtn;
        private System.Windows.Forms.Button TriangleArea;
    }
}