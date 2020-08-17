namespace AddMyDetail
{
    partial class PersonDashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddName = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddAge = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AddAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(517, 46);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(75, 23);
            this.AddName.TabIndex = 0;
            this.AddName.Text = "Add";
            this.AddName.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLabel.Location = new System.Drawing.Point(236, 48);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(43, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 23);
            this.textBox1.TabIndex = 3;
            // 
            // AddAge
            // 
            this.AddAge.Location = new System.Drawing.Point(517, 96);
            this.AddAge.Name = "AddAge";
            this.AddAge.Size = new System.Drawing.Size(75, 23);
            this.AddAge.TabIndex = 4;
            this.AddAge.Text = "Add";
            this.AddAge.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(281, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(230, 23);
            this.textBox2.TabIndex = 3;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AgeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgeLabel.Location = new System.Drawing.Point(244, 101);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(31, 17);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age";
            // 
            // AddAddress
            // 
            this.AddAddress.Location = new System.Drawing.Point(244, 149);
            this.AddAddress.Name = "AddAddress";
            this.AddAddress.Size = new System.Drawing.Size(118, 23);
            this.AddAddress.TabIndex = 4;
            this.AddAddress.Text = "Add Address";
            this.AddAddress.UseVisualStyleBackColor = true;
            // 
            // PersonDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAddress);
            this.Controls.Add(this.AddAge);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddName);
            this.Name = "PersonDashboard";
            this.Text = "PersonDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddAge;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Button AddAddress;
    }
}

