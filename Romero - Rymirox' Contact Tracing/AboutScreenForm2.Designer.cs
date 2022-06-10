namespace Romero___Rymirox__Contact_Tracing
{
    partial class AboutScreenForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutScreenForm2));
            this.labelASF1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelASF1
            // 
            this.labelASF1.AutoSize = true;
            this.labelASF1.BackColor = System.Drawing.Color.Transparent;
            this.labelASF1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelASF1.Location = new System.Drawing.Point(274, 215);
            this.labelASF1.Name = "labelASF1";
            this.labelASF1.Size = new System.Drawing.Size(253, 20);
            this.labelASF1.TabIndex = 3;
            this.labelASF1.Text = "Welcome to About this Software!";
            // 
            // AboutScreenForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelASF1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutScreenForm2";
            this.Text = "AboutScreenForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelASF1;
    }
}