
namespace LoansApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowFullNameTextBox = new System.Windows.Forms.TextBox();
            this.IDSearchButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameSearchButton = new System.Windows.Forms.Button();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label6.Location = new System.Drawing.Point(34, 142);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "חפש לפי ת.ז:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 31;
            this.label2.Text = "מספר מוצר :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductNumLabel
            // 
            this.ProductNumLabel.AutoSize = true;
            this.ProductNumLabel.Font = new System.Drawing.Font("Arial", 15.75F);
            this.ProductNumLabel.Location = new System.Drawing.Point(390, 35);
            this.ProductNumLabel.Name = "ProductNumLabel";
            this.ProductNumLabel.Size = new System.Drawing.Size(153, 24);
            this.ProductNumLabel.TabIndex = 32;
            this.ProductNumLabel.Text = "ProductNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label4.Location = new System.Drawing.Point(22, 203);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "ימי השאלה:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EndDateComboBox
            // 
            this.EndDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndDateComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EndDateComboBox.FormattingEnabled = true;
            this.EndDateComboBox.Location = new System.Drawing.Point(26, 230);
            this.EndDateComboBox.Name = "EndDateComboBox";
            this.EndDateComboBox.Size = new System.Drawing.Size(218, 24);
            this.EndDateComboBox.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label3.Location = new System.Drawing.Point(530, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "משתמש:";
            // 
            // ShowFullNameTextBox
            // 
            this.ShowFullNameTextBox.Enabled = false;
            this.ShowFullNameTextBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ShowFullNameTextBox.Location = new System.Drawing.Point(534, 129);
            this.ShowFullNameTextBox.Name = "ShowFullNameTextBox";
            this.ShowFullNameTextBox.Size = new System.Drawing.Size(218, 22);
            this.ShowFullNameTextBox.TabIndex = 36;
            // 
            // IDSearchButton
            // 
            this.IDSearchButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.IDSearchButton.Location = new System.Drawing.Point(261, 166);
            this.IDSearchButton.Name = "IDSearchButton";
            this.IDSearchButton.Size = new System.Drawing.Size(74, 25);
            this.IDSearchButton.TabIndex = 38;
            this.IDSearchButton.Text = "חפש";
            this.IDSearchButton.UseVisualStyleBackColor = true;
            this.IDSearchButton.Click += new System.EventHandler(this.IDSearchButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OKButton.Location = new System.Drawing.Point(259, 296);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(76, 29);
            this.OKButton.TabIndex = 39;
            this.OKButton.Text = "שמור";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitButton.Location = new System.Drawing.Point(467, 296);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 29);
            this.ExitButton.TabIndex = 40;
            this.ExitButton.Text = "חזור";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.IdTextBox.Location = new System.Drawing.Point(26, 169);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(218, 22);
            this.IdTextBox.TabIndex = 30;
            // 
            // FullNameSearchButton
            // 
            this.FullNameSearchButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FullNameSearchButton.Location = new System.Drawing.Point(261, 98);
            this.FullNameSearchButton.Name = "FullNameSearchButton";
            this.FullNameSearchButton.Size = new System.Drawing.Size(74, 25);
            this.FullNameSearchButton.TabIndex = 37;
            this.FullNameSearchButton.Text = "חפש";
            this.FullNameSearchButton.UseVisualStyleBackColor = true;
            this.FullNameSearchButton.Click += new System.EventHandler(this.FullNameSearchButton_Click);
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Arial", 9.75F);
            this.FullNameTextBox.Location = new System.Drawing.Point(26, 98);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(218, 22);
            this.FullNameTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label1.Location = new System.Drawing.Point(22, 71);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "חפש לפי שם מלא:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 351);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.IDSearchButton);
            this.Controls.Add(this.FullNameSearchButton);
            this.Controls.Add(this.ShowFullNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDateComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNumLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "השאלת מחשב ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductNumLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EndDateComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShowFullNameTextBox;
        private System.Windows.Forms.Button IDSearchButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button FullNameSearchButton;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label label1;
    }
}