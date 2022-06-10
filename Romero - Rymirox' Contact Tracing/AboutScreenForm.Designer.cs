namespace Romero___Rymirox__Contact_Tracing
{
    partial class AboutScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutScreenForm));
            this.labelASF3 = new System.Windows.Forms.Label();
            this.labelASF1 = new System.Windows.Forms.Label();
            this.labelASF2 = new System.Windows.Forms.Label();
            this.labelASF4 = new System.Windows.Forms.Label();
            this.pictureBoxASF1 = new System.Windows.Forms.PictureBox();
            this.buttonASF2 = new System.Windows.Forms.Button();
            this.buttonASF1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxASF1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelASF3
            // 
            this.labelASF3.AutoSize = true;
            this.labelASF3.BackColor = System.Drawing.Color.Transparent;
            this.labelASF3.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelASF3.Location = new System.Drawing.Point(167, 70);
            this.labelASF3.Name = "labelASF3";
            this.labelASF3.Size = new System.Drawing.Size(375, 33);
            this.labelASF3.TabIndex = 1;
            this.labelASF3.Text = "Rymirox\' Contact Tracing";
            // 
            // labelASF1
            // 
            this.labelASF1.AutoSize = true;
            this.labelASF1.BackColor = System.Drawing.Color.Transparent;
            this.labelASF1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelASF1.Location = new System.Drawing.Point(227, 20);
            this.labelASF1.Name = "labelASF1";
            this.labelASF1.Size = new System.Drawing.Size(253, 20);
            this.labelASF1.TabIndex = 2;
            this.labelASF1.Text = "Welcome to About this Software!";
            // 
            // labelASF2
            // 
            this.labelASF2.AutoSize = true;
            this.labelASF2.BackColor = System.Drawing.Color.Transparent;
            this.labelASF2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelASF2.Location = new System.Drawing.Point(63, 40);
            this.labelASF2.Name = "labelASF2";
            this.labelASF2.Size = new System.Drawing.Size(578, 20);
            this.labelASF2.TabIndex = 3;
            this.labelASF2.Text = "I will introduce the description of the software and steps to start your tracing." +
    "";
            // 
            // labelASF4
            // 
            this.labelASF4.AutoSize = true;
            this.labelASF4.BackColor = System.Drawing.Color.Transparent;
            this.labelASF4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelASF4.Location = new System.Drawing.Point(298, 117);
            this.labelASF4.Name = "labelASF4";
            this.labelASF4.Size = new System.Drawing.Size(95, 20);
            this.labelASF4.TabIndex = 4;
            this.labelASF4.Text = "Description";
            // 
            // pictureBoxASF1
            // 
            this.pictureBoxASF1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxASF1.Image = global::Romero___Rymirox__Contact_Tracing.Properties.Resources.Screenshot_2022_06_11_005558;
            this.pictureBoxASF1.Location = new System.Drawing.Point(104, 159);
            this.pictureBoxASF1.Name = "pictureBoxASF1";
            this.pictureBoxASF1.Size = new System.Drawing.Size(492, 170);
            this.pictureBoxASF1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxASF1.TabIndex = 5;
            this.pictureBoxASF1.TabStop = false;
            // 
            // buttonASF2
            // 
            this.buttonASF2.BackColor = System.Drawing.Color.White;
            this.buttonASF2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonASF2.Location = new System.Drawing.Point(600, 335);
            this.buttonASF2.Name = "buttonASF2";
            this.buttonASF2.Size = new System.Drawing.Size(93, 28);
            this.buttonASF2.TabIndex = 24;
            this.buttonASF2.Text = "Next";
            this.buttonASF2.UseVisualStyleBackColor = false;
            // 
            // buttonASF1
            // 
            this.buttonASF1.BackColor = System.Drawing.Color.White;
            this.buttonASF1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonASF1.Location = new System.Drawing.Point(12, 9);
            this.buttonASF1.Name = "buttonASF1";
            this.buttonASF1.Size = new System.Drawing.Size(93, 28);
            this.buttonASF1.TabIndex = 25;
            this.buttonASF1.Text = "Back";
            this.buttonASF1.UseVisualStyleBackColor = false;
            this.buttonASF1.Click += new System.EventHandler(this.buttonASF1_Click);
            // 
            // AboutScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Romero___Rymirox__Contact_Tracing.Properties.Resources.Sole__5_;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.buttonASF1);
            this.Controls.Add(this.buttonASF2);
            this.Controls.Add(this.pictureBoxASF1);
            this.Controls.Add(this.labelASF4);
            this.Controls.Add(this.labelASF2);
            this.Controls.Add(this.labelASF1);
            this.Controls.Add(this.labelASF3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutScreenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxASF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelASF3;
        private Label labelASF1;
        private Label labelASF2;
        private Label labelASF4;
        private PictureBox pictureBoxASF1;
        private Button buttonASF2;
        private Button buttonASF1;
    }
}