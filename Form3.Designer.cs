
namespace LoansApp
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label2 = new System.Windows.Forms.Label();
            this.ProductNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EndDateComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ReasonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "עדכון פרטים";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ProductNumberLabel
            // 
            this.ProductNumberLabel.AutoSize = true;
            this.ProductNumberLabel.Font = new System.Drawing.Font("Arial", 15.75F);
            this.ProductNumberLabel.Location = new System.Drawing.Point(314, 43);
            this.ProductNumberLabel.Name = "ProductNumberLabel";
            this.ProductNumberLabel.Size = new System.Drawing.Size(153, 24);
            this.ProductNumberLabel.TabIndex = 33;
            this.ProductNumberLabel.Text = "ProductNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label4.Location = new System.Drawing.Point(39, 69);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "ימי השאלה:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EndDateComboBox
            // 
            this.EndDateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndDateComboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EndDateComboBox.FormattingEnabled = true;
            this.EndDateComboBox.Location = new System.Drawing.Point(43, 96);
            this.EndDateComboBox.Name = "EndDateComboBox";
            this.EndDateComboBox.Size = new System.Drawing.Size(218, 24);
            this.EndDateComboBox.TabIndex = 42;
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.OKButton.Location = new System.Drawing.Point(240, 204);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(76, 29);
            this.OKButton.TabIndex = 44;
            this.OKButton.Text = "שמור";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitButton.Location = new System.Drawing.Point(443, 204);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 29);
            this.ExitButton.TabIndex = 45;
            this.ExitButton.Text = "חזור";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F);
            this.label7.Location = new System.Drawing.Point(477, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 46;
            this.label7.Text = "סיבה:";
            // 
            // ReasonRichTextBox
            // 
            this.ReasonRichTextBox.Location = new System.Drawing.Point(481, 96);
            this.ReasonRichTextBox.Name = "ReasonRichTextBox";
            this.ReasonRichTextBox.Size = new System.Drawing.Size(307, 87);
            this.ReasonRichTextBox.TabIndex = 47;
            this.ReasonRichTextBox.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 255);
            this.Controls.Add(this.ReasonRichTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.EndDateComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductNumberLabel);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "עדכון פרטי שיוך";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox EndDateComboBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox ReasonRichTextBox;
    }
}