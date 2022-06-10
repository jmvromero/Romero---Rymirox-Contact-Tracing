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
            this.buttonCO1 = new System.Windows.Forms.Button();
            this.buttonCO2 = new System.Windows.Forms.Button();
            this.buttonCO3 = new System.Windows.Forms.Button();
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
            // buttonCO1
            // 
            this.buttonCO1.BackColor = System.Drawing.Color.White;
            this.buttonCO1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCO1.Location = new System.Drawing.Point(113, 76);
            this.buttonCO1.Name = "buttonCO1";
            this.buttonCO1.Size = new System.Drawing.Size(112, 29);
            this.buttonCO1.TabIndex = 62;
            this.buttonCO1.Text = "Yes";
            this.buttonCO1.UseVisualStyleBackColor = false;
            this.buttonCO1.Click += new System.EventHandler(this.buttonLSF2_Click);
            // 
            // buttonCO2
            // 
            this.buttonCO2.BackColor = System.Drawing.Color.White;
            this.buttonCO2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCO2.Location = new System.Drawing.Point(113, 120);
            this.buttonCO2.Name = "buttonCO2";
            this.buttonCO2.Size = new System.Drawing.Size(112, 29);
            this.buttonCO2.TabIndex = 63;
            this.buttonCO2.Text = "Exit";
            this.buttonCO2.UseVisualStyleBackColor = false;
            this.buttonCO2.Click += new System.EventHandler(this.buttonCO2_Click);
            // 
            // buttonCO3
            // 
            this.buttonCO3.BackColor = System.Drawing.Color.White;
            this.buttonCO3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCO3.Location = new System.Drawing.Point(113, 166);
            this.buttonCO3.Name = "buttonCO3";
            this.buttonCO3.Size = new System.Drawing.Size(112, 29);
            this.buttonCO3.TabIndex = 64;
            this.buttonCO3.Text = "Main Menu";
            this.buttonCO3.UseVisualStyleBackColor = false;
            this.buttonCO3.Click += new System.EventHandler(this.buttonCO3_Click);
            // 
            // ContinueOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Romero___Rymirox__Contact_Tracing.Properties.Resources.Sole__5_;
            this.ClientSize = new System.Drawing.Size(343, 224);
            this.Controls.Add(this.buttonCO3);
            this.Controls.Add(this.buttonCO2);
            this.Controls.Add(this.buttonCO1);
            this.Controls.Add(this.labelFOF1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "ContinueOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFOF1;
        private Button buttonCO1;
        private Button buttonCO2;
        private Button buttonCO3;
    }
}