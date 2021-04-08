namespace Calculator
{
    partial class BasicCalulatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicCalulatorForm));
            this.ZeroBtn = new System.Windows.Forms.Button();
            this.DotBtn = new System.Windows.Forms.Button();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.PlsBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultipBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.ThreeBtn = new System.Windows.Forms.Button();
            this.SixBtn = new System.Windows.Forms.Button();
            this.NineBtn = new System.Windows.Forms.Button();
            this.TwoBtn = new System.Windows.Forms.Button();
            this.OneBtn = new System.Windows.Forms.Button();
            this.FourBtn = new System.Windows.Forms.Button();
            this.FiveBtn = new System.Windows.Forms.Button();
            this.SevenBtn = new System.Windows.Forms.Button();
            this.EightBtn = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.CBtn = new System.Windows.Forms.Button();
            this.CEBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ZeroBtn
            // 
            this.ZeroBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroBtn.Location = new System.Drawing.Point(3, 505);
            this.ZeroBtn.Name = "ZeroBtn";
            this.ZeroBtn.Size = new System.Drawing.Size(224, 90);
            this.ZeroBtn.TabIndex = 0;
            this.ZeroBtn.Text = "0";
            this.ZeroBtn.UseVisualStyleBackColor = true;
            this.ZeroBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // DotBtn
            // 
            this.DotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DotBtn.Location = new System.Drawing.Point(229, 504);
            this.DotBtn.Name = "DotBtn";
            this.DotBtn.Size = new System.Drawing.Size(110, 90);
            this.DotBtn.TabIndex = 1;
            this.DotBtn.Text = ".";
            this.DotBtn.UseVisualStyleBackColor = true;
            this.DotBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBtn.Location = new System.Drawing.Point(343, 412);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(110, 183);
            this.EqualBtn.TabIndex = 2;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.OperationResultClick);
            // 
            // PlsBtn
            // 
            this.PlsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlsBtn.Location = new System.Drawing.Point(343, 321);
            this.PlsBtn.Name = "PlsBtn";
            this.PlsBtn.Size = new System.Drawing.Size(110, 90);
            this.PlsBtn.TabIndex = 3;
            this.PlsBtn.Text = "+";
            this.PlsBtn.UseVisualStyleBackColor = true;
            this.PlsBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinusBtn.Location = new System.Drawing.Point(343, 229);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(110, 90);
            this.MinusBtn.TabIndex = 4;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // MultipBtn
            // 
            this.MultipBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultipBtn.Location = new System.Drawing.Point(343, 136);
            this.MultipBtn.Name = "MultipBtn";
            this.MultipBtn.Size = new System.Drawing.Size(110, 90);
            this.MultipBtn.TabIndex = 5;
            this.MultipBtn.Text = "x";
            this.MultipBtn.UseVisualStyleBackColor = true;
            this.MultipBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // DivBtn
            // 
            this.DivBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivBtn.Location = new System.Drawing.Point(229, 136);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(110, 90);
            this.DivBtn.TabIndex = 6;
            this.DivBtn.Text = "/\t";
            this.DivBtn.UseVisualStyleBackColor = true;
            this.DivBtn.Click += new System.EventHandler(this.OperationClick);
            // 
            // ThreeBtn
            // 
            this.ThreeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeBtn.Location = new System.Drawing.Point(229, 412);
            this.ThreeBtn.Name = "ThreeBtn";
            this.ThreeBtn.Size = new System.Drawing.Size(110, 90);
            this.ThreeBtn.TabIndex = 8;
            this.ThreeBtn.Text = "3\t";
            this.ThreeBtn.UseVisualStyleBackColor = true;
            this.ThreeBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // SixBtn
            // 
            this.SixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SixBtn.Location = new System.Drawing.Point(229, 320);
            this.SixBtn.Name = "SixBtn";
            this.SixBtn.Size = new System.Drawing.Size(110, 90);
            this.SixBtn.TabIndex = 9;
            this.SixBtn.Text = "6\t";
            this.SixBtn.UseVisualStyleBackColor = true;
            this.SixBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // NineBtn
            // 
            this.NineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NineBtn.Location = new System.Drawing.Point(230, 228);
            this.NineBtn.Name = "NineBtn";
            this.NineBtn.Size = new System.Drawing.Size(110, 90);
            this.NineBtn.TabIndex = 10;
            this.NineBtn.Text = "9\t";
            this.NineBtn.UseVisualStyleBackColor = true;
            this.NineBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // TwoBtn
            // 
            this.TwoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoBtn.Location = new System.Drawing.Point(117, 412);
            this.TwoBtn.Name = "TwoBtn";
            this.TwoBtn.Size = new System.Drawing.Size(110, 90);
            this.TwoBtn.TabIndex = 12;
            this.TwoBtn.Text = "2\t";
            this.TwoBtn.UseVisualStyleBackColor = true;
            this.TwoBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // OneBtn
            // 
            this.OneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OneBtn.Location = new System.Drawing.Point(4, 412);
            this.OneBtn.Name = "OneBtn";
            this.OneBtn.Size = new System.Drawing.Size(110, 90);
            this.OneBtn.TabIndex = 13;
            this.OneBtn.Text = "1";
            this.OneBtn.UseVisualStyleBackColor = true;
            this.OneBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // FourBtn
            // 
            this.FourBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourBtn.Location = new System.Drawing.Point(3, 320);
            this.FourBtn.Name = "FourBtn";
            this.FourBtn.Size = new System.Drawing.Size(110, 90);
            this.FourBtn.TabIndex = 15;
            this.FourBtn.Text = "4\t";
            this.FourBtn.UseVisualStyleBackColor = true;
            this.FourBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // FiveBtn
            // 
            this.FiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveBtn.Location = new System.Drawing.Point(116, 320);
            this.FiveBtn.Name = "FiveBtn";
            this.FiveBtn.Size = new System.Drawing.Size(110, 90);
            this.FiveBtn.TabIndex = 14;
            this.FiveBtn.Text = "5\t";
            this.FiveBtn.UseVisualStyleBackColor = true;
            this.FiveBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // SevenBtn
            // 
            this.SevenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenBtn.Location = new System.Drawing.Point(4, 228);
            this.SevenBtn.Name = "SevenBtn";
            this.SevenBtn.Size = new System.Drawing.Size(110, 90);
            this.SevenBtn.TabIndex = 17;
            this.SevenBtn.Text = "7\t";
            this.SevenBtn.UseVisualStyleBackColor = true;
            this.SevenBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // EightBtn
            // 
            this.EightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EightBtn.Location = new System.Drawing.Point(117, 228);
            this.EightBtn.Name = "EightBtn";
            this.EightBtn.Size = new System.Drawing.Size(110, 90);
            this.EightBtn.TabIndex = 16;
            this.EightBtn.Text = "8\t";
            this.EightBtn.UseVisualStyleBackColor = true;
            this.EightBtn.Click += new System.EventHandler(this.BtnClick);
            // 
            // ResultBox
            // 
            this.ResultBox.Font = new System.Drawing.Font("Tahoma", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(4, 34);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(449, 91);
            this.ResultBox.TabIndex = 18;
            this.ResultBox.Text = "0";
            this.ResultBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ResultBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // CBtn
            // 
            this.CBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBtn.Location = new System.Drawing.Point(117, 136);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(110, 90);
            this.CBtn.TabIndex = 19;
            this.CBtn.Text = "C";
            this.CBtn.UseVisualStyleBackColor = true;
            this.CBtn.Click += new System.EventHandler(this.CPress);
            // 
            // CEBtn
            // 
            this.CEBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEBtn.Location = new System.Drawing.Point(4, 136);
            this.CEBtn.Name = "CEBtn";
            this.CEBtn.Size = new System.Drawing.Size(110, 90);
            this.CEBtn.TabIndex = 20;
            this.CEBtn.Text = "CE";
            this.CEBtn.UseVisualStyleBackColor = true;
            this.CEBtn.Click += new System.EventHandler(this.CEClick);
            // 
            // BasicCalulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(458, 600);
            this.Controls.Add(this.CEBtn);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.SevenBtn);
            this.Controls.Add(this.EightBtn);
            this.Controls.Add(this.FourBtn);
            this.Controls.Add(this.FiveBtn);
            this.Controls.Add(this.OneBtn);
            this.Controls.Add(this.TwoBtn);
            this.Controls.Add(this.NineBtn);
            this.Controls.Add(this.SixBtn);
            this.Controls.Add(this.ThreeBtn);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultipBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.PlsBtn);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.DotBtn);
            this.Controls.Add(this.ZeroBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BasicCalulatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ZeroBtn;
        private System.Windows.Forms.Button DotBtn;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button PlsBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button MultipBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button ThreeBtn;
        private System.Windows.Forms.Button SixBtn;
        private System.Windows.Forms.Button NineBtn;
        private System.Windows.Forms.Button TwoBtn;
        private System.Windows.Forms.Button OneBtn;
        private System.Windows.Forms.Button FourBtn;
        private System.Windows.Forms.Button FiveBtn;
        private System.Windows.Forms.Button SevenBtn;
        private System.Windows.Forms.Button EightBtn;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.Button CEBtn;
    }
}