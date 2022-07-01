namespace Romero___Rymirox__Contact_Tracing
{
    partial class FindingRecordOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindingRecordOptions));
            this.labelFRO1 = new System.Windows.Forms.Label();
            this.buttonFRO3 = new System.Windows.Forms.Button();
            this.buttonFRO2 = new System.Windows.Forms.Button();
            this.buttonFRO1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFRO1
            // 
            this.labelFRO1.AutoSize = true;
            this.labelFRO1.BackColor = System.Drawing.Color.Transparent;
            this.labelFRO1.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelFRO1.Location = new System.Drawing.Point(41, 31);
            this.labelFRO1.Name = "labelFRO1";
            this.labelFRO1.Size = new System.Drawing.Size(264, 20);
            this.labelFRO1.TabIndex = 13;
            this.labelFRO1.Text = "What function do you want to use?";
            // 
            // buttonFRO3
            // 
            this.buttonFRO3.BackColor = System.Drawing.Color.White;
            this.buttonFRO3.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFRO3.Location = new System.Drawing.Point(114, 166);
            this.buttonFRO3.Name = "buttonFRO3";
            this.buttonFRO3.Size = new System.Drawing.Size(112, 29);
            this.buttonFRO3.TabIndex = 67;
            this.buttonFRO3.Text = "Main Menu";
            this.buttonFRO3.UseVisualStyleBackColor = false;
            this.buttonFRO3.Click += new System.EventHandler(this.buttonFRO3_Click);
            // 
            // buttonFRO2
            // 
            this.buttonFRO2.BackColor = System.Drawing.Color.White;
            this.buttonFRO2.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFRO2.Location = new System.Drawing.Point(114, 120);
            this.buttonFRO2.Name = "buttonFRO2";
            this.buttonFRO2.Size = new System.Drawing.Size(112, 29);
            this.buttonFRO2.TabIndex = 66;
            this.buttonFRO2.Text = "QR Code ";
            this.buttonFRO2.UseVisualStyleBackColor = false;
            this.buttonFRO2.Click += new System.EventHandler(this.buttonFRO2_Click);
            // 
            // buttonFRO1
            // 
            this.buttonFRO1.BackColor = System.Drawing.Color.White;
            this.buttonFRO1.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFRO1.Location = new System.Drawing.Point(114, 76);
            this.buttonFRO1.Name = "buttonFRO1";
            this.buttonFRO1.Size = new System.Drawing.Size(112, 29);
            this.buttonFRO1.TabIndex = 65;
            this.buttonFRO1.Text = "Filter";
            this.buttonFRO1.UseVisualStyleBackColor = false;
            this.buttonFRO1.Click += new System.EventHandler(this.buttonFRO1_Click);
            // 
            // FindingRecordOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Romero___Rymirox__Contact_Tracing.Properties.Resources.output_onlinepngtools;
            this.ClientSize = new System.Drawing.Size(339, 220);
            this.Controls.Add(this.buttonFRO3);
            this.Controls.Add(this.buttonFRO2);
            this.Controls.Add(this.buttonFRO1);
            this.Controls.Add(this.labelFRO1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FindingRecordOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rymirox\' Contact Tracing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFRO1;
        private Button buttonFRO3;
        private Button buttonFRO2;
        private Button buttonFRO1;
    }
}