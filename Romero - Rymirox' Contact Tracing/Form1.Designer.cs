namespace Romero___Rymirox__Contact_Tracing
{
    partial class ContinueOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContinueOptions));
            this.labelFOF1 = new System.Windows.Forms.Label();
            this.buttonLSF2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFOF1
            // 
            this.labelFOF1.AutoSize = true;
            this.labelFOF1.BackColor = System.Drawing.Color.Transparent;
            this.labelFOF1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFOF1.Location = new System.Drawing.Point(35, 31);
            this.labelFOF1.Name = "labelFOF1";
            this.labelFOF1.Size = new System.Drawing.Size(269, 20);
            this.labelFOF1.TabIndex = 12;
            this.labelFOF1.Text = "Do you want to make another one?";
            // 
            // buttonLSF2
            // 
            this.buttonLSF2.BackColor = System.Drawing.Color.White;
            this.buttonLSF2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLSF2.Location = new System.Drawing.Point(113, 76);
            this.buttonLSF2.Name = "buttonLSF2";
            this.buttonLSF2.Size = new System.Drawing.Size(112, 29);
            this.buttonLSF2.TabIndex = 62;
            this.buttonLSF2.Text = "Yes";
            this.buttonLSF2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(113, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 63;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(113, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 29);
            this.button2.TabIndex = 64;
            this.button2.Text = "Main Menu";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ContinueOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Romero___Rymirox__Contact_Tracing.Properties.Resources.Sole__5_;
            this.ClientSize = new System.Drawing.Size(343, 224);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonLSF2);
            this.Controls.Add(this.labelFOF1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContinueOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFOF1;
        private Button buttonLSF2;
        private Button button1;
        private Button button2;
    }
}