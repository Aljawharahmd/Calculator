namespace Calculator
{
    partial class ReadEqForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadEqForm));
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.FilePathLbl = new System.Windows.Forms.Label();
            this.FileTxt = new System.Windows.Forms.TextBox();
            this.EqationTxt = new System.Windows.Forms.TextBox();
            this.EqationLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenFileBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.OpenFileBtn.Location = new System.Drawing.Point(90, 419);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(258, 77);
            this.OpenFileBtn.TabIndex = 0;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileClicked);
            // 
            // FilePathLbl
            // 
            this.FilePathLbl.AutoSize = true;
            this.FilePathLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilePathLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FilePathLbl.Location = new System.Drawing.Point(107, 29);
            this.FilePathLbl.Name = "FilePathLbl";
            this.FilePathLbl.Size = new System.Drawing.Size(232, 89);
            this.FilePathLbl.TabIndex = 1;
            this.FilePathLbl.Text = "File Path";
            this.FilePathLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FileTxt
            // 
            this.FileTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileTxt.Location = new System.Drawing.Point(49, 136);
            this.FileTxt.Name = "FileTxt";
            this.FileTxt.Size = new System.Drawing.Size(360, 56);
            this.FileTxt.TabIndex = 2;
            // 
            // EqationTxt
            // 
            this.EqationTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqationTxt.Location = new System.Drawing.Point(49, 326);
            this.EqationTxt.Name = "EqationTxt";
            this.EqationTxt.Size = new System.Drawing.Size(360, 56);
            this.EqationTxt.TabIndex = 4;
            // 
            // EqationLbl
            // 
            this.EqationLbl.AutoSize = true;
            this.EqationLbl.Font = new System.Drawing.Font("Simplified Arabic", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqationLbl.ForeColor = System.Drawing.Color.SaddleBrown;
            this.EqationLbl.Location = new System.Drawing.Point(107, 219);
            this.EqationLbl.Name = "EqationLbl";
            this.EqationLbl.Size = new System.Drawing.Size(229, 89);
            this.EqationLbl.TabIndex = 3;
            this.EqationLbl.Text = "Equation";
            // 
            // ReadEqForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.EqationTxt);
            this.Controls.Add(this.EqationLbl);
            this.Controls.Add(this.FileTxt);
            this.Controls.Add(this.FilePathLbl);
            this.Controls.Add(this.OpenFileBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReadEqForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read Equation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.Label FilePathLbl;
        private System.Windows.Forms.TextBox FileTxt;
        private System.Windows.Forms.TextBox EqationTxt;
        private System.Windows.Forms.Label EqationLbl;
    }
}