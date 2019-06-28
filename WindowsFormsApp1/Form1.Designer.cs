namespace WindowsFormsApp1
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
            this.RunPackage1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunPackage1
            // 
            this.RunPackage1.Location = new System.Drawing.Point(136, 47);
            this.RunPackage1.Name = "RunPackage1";
            this.RunPackage1.Size = new System.Drawing.Size(161, 52);
            this.RunPackage1.TabIndex = 0;
            this.RunPackage1.Text = "Run Package 1";
            this.RunPackage1.UseVisualStyleBackColor = true;
            this.RunPackage1.Click += new System.EventHandler(this.RunPackage1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunPackage1);
            this.Name = "Form1";
            this.Text = "Run SSIS Packages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunPackage1;
    }
}

