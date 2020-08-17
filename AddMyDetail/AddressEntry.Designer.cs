namespace AddMyDetail
{
    partial class AddressEntry
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
            this.StreetLabel = new System.Windows.Forms.Label();
            this.StreetInput = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountryInput = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.StreetLabel.Location = new System.Drawing.Point(216, 47);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(37, 15);
            this.StreetLabel.TabIndex = 0;
            this.StreetLabel.Text = "Street";
            // 
            // StreetInput
            // 
            this.StreetInput.Location = new System.Drawing.Point(259, 44);
            this.StreetInput.Name = "StreetInput";
            this.StreetInput.Size = new System.Drawing.Size(206, 23);
            this.StreetInput.TabIndex = 2;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CityLabel.Location = new System.Drawing.Point(216, 90);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(28, 15);
            this.CityLabel.TabIndex = 0;
            this.CityLabel.Text = "City";
            // 
            // CityInput
            // 
            this.CityInput.Location = new System.Drawing.Point(259, 87);
            this.CityInput.Name = "CityInput";
            this.CityInput.Size = new System.Drawing.Size(206, 23);
            this.CityInput.TabIndex = 2;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CountryLabel.Location = new System.Drawing.Point(203, 137);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(50, 15);
            this.CountryLabel.TabIndex = 0;
            this.CountryLabel.Text = "Country";
            // 
            // CountryInput
            // 
            this.CountryInput.Location = new System.Drawing.Point(259, 134);
            this.CountryInput.Name = "CountryInput";
            this.CountryInput.Size = new System.Drawing.Size(206, 23);
            this.CountryInput.TabIndex = 2;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.SaveBtn.Location = new System.Drawing.Point(315, 184);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AddressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CountryInput);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.StreetInput);
            this.Controls.Add(this.StreetLabel);
            this.Name = "AddressEntry";
            this.Text = "AddressEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox StreetInput;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox CountryInput;
        private System.Windows.Forms.Button SaveBtn;
    }
}