namespace Containerverhuur
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBoxVasteKlant = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxM3 = new System.Windows.Forms.TextBox();
            this.Bereken = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(78, 38);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Van";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tot";
            // 
            // CheckBoxVasteKlant
            // 
            this.CheckBoxVasteKlant.AutoSize = true;
            this.CheckBoxVasteKlant.Location = new System.Drawing.Point(78, 70);
            this.CheckBoxVasteKlant.Name = "CheckBoxVasteKlant";
            this.CheckBoxVasteKlant.Size = new System.Drawing.Size(15, 14);
            this.CheckBoxVasteKlant.TabIndex = 4;
            this.CheckBoxVasteKlant.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vaste klant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "m3";
            // 
            // TextBoxM3
            // 
            this.TextBoxM3.Location = new System.Drawing.Point(78, 97);
            this.TextBoxM3.Name = "TextBoxM3";
            this.TextBoxM3.Size = new System.Drawing.Size(100, 20);
            this.TextBoxM3.TabIndex = 7;
            // 
            // Bereken
            // 
            this.Bereken.Location = new System.Drawing.Point(78, 123);
            this.Bereken.Name = "Bereken";
            this.Bereken.Size = new System.Drawing.Size(100, 23);
            this.Bereken.TabIndex = 8;
            this.Bereken.Text = "Bereken";
            this.Bereken.UseVisualStyleBackColor = true;
            this.Bereken.Click += new System.EventHandler(this.Bereken_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(75, 149);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(100, 23);
            this.Output.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 179);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Bereken);
            this.Controls.Add(this.TextBoxM3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxVasteKlant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Container tarief berekenen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxVasteKlant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxM3;
        private System.Windows.Forms.Button Bereken;
        private System.Windows.Forms.Label Output;
    }
}

