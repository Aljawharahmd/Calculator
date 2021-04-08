namespace Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.calBtn = new System.Windows.Forms.Button();
            this.readEqBtn = new System.Windows.Forms.Button();
            this.calAreaBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calBtn
            // 
            this.calBtn.Font = new System.Drawing.Font("Simplified Arabic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.calBtn.Location = new System.Drawing.Point(12, 415);
            this.calBtn.Name = "calBtn";
            this.calBtn.Size = new System.Drawing.Size(436, 175);
            this.calBtn.TabIndex = 2;
            this.calBtn.Text = "Basic Calculator";
            this.calBtn.UseVisualStyleBackColor = true;
            this.calBtn.Click += new System.EventHandler(this.NewForm);
            // 
            // readEqBtn
            // 
            this.readEqBtn.Font = new System.Drawing.Font("Simplified Arabic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readEqBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.readEqBtn.Location = new System.Drawing.Point(12, 221);
            this.readEqBtn.Name = "readEqBtn";
            this.readEqBtn.Size = new System.Drawing.Size(436, 175);
            this.readEqBtn.TabIndex = 3;
            this.readEqBtn.Text = "Read Equation From a File";
            this.readEqBtn.UseVisualStyleBackColor = true;
            this.readEqBtn.Click += new System.EventHandler(this.ReadeqClick);
            // 
            // calAreaBtn
            // 
            this.calAreaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.calAreaBtn.Font = new System.Drawing.Font("Simplified Arabic", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calAreaBtn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.calAreaBtn.Location = new System.Drawing.Point(12, 26);
            this.calAreaBtn.Name = "calAreaBtn";
            this.calAreaBtn.Size = new System.Drawing.Size(436, 175);
            this.calAreaBtn.TabIndex = 4;
            this.calAreaBtn.Text = "Calculating Area";
            this.calAreaBtn.UseVisualStyleBackColor = true;
            this.calAreaBtn.Click += new System.EventHandler(this.calAreaBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.calAreaBtn);
            this.Controls.Add(this.readEqBtn);
            this.Controls.Add(this.calBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calBtn;
        private System.Windows.Forms.Button readEqBtn;
        private System.Windows.Forms.Button calAreaBtn;
    }
}

