
namespace LoansApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.AssociateProductButton = new System.Windows.Forms.Button();
            this.DisconnectProductButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.SupporterUserTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateReceivedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supporterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UpdateProductDetailsButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.noteProductClick = new System.Windows.Forms.Button();
            this.exportCSV_button = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "חפש מוצר:";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(124, 38);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(223, 20);
            this.ProductTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(372, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם מלא:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(466, 38);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(223, 20);
            this.FullNameTextBox.TabIndex = 3;
            // 
            // AssociateProductButton
            // 
            this.AssociateProductButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AssociateProductButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.AssociateProductButton.Location = new System.Drawing.Point(110, 72);
            this.AssociateProductButton.Name = "AssociateProductButton";
            this.AssociateProductButton.Size = new System.Drawing.Size(126, 32);
            this.AssociateProductButton.TabIndex = 4;
            this.AssociateProductButton.Text = "שיוך מוצר";
            this.AssociateProductButton.UseVisualStyleBackColor = false;
            this.AssociateProductButton.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // DisconnectProductButton
            // 
            this.DisconnectProductButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DisconnectProductButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.DisconnectProductButton.Location = new System.Drawing.Point(306, 73);
            this.DisconnectProductButton.Name = "DisconnectProductButton";
            this.DisconnectProductButton.Size = new System.Drawing.Size(125, 32);
            this.DisconnectProductButton.TabIndex = 5;
            this.DisconnectProductButton.Text = "ניתוק מוצר";
            this.DisconnectProductButton.UseVisualStyleBackColor = false;
            this.DisconnectProductButton.Click += new System.EventHandler(this.DisconnectProductButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SearchButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.SearchButton.Location = new System.Drawing.Point(711, 34);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 33);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "חפש";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            this.SearchButton.Enter += new System.EventHandler(this.SearchButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.filterButton.Font = new System.Drawing.Font("Arial", 15.75F);
            this.filterButton.Image = global::LoansApp.Properties.Resources.WhatsApp_Image_2022_12_21_at_13_32_29;
            this.filterButton.Location = new System.Drawing.Point(1274, 77);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(33, 28);
            this.filterButton.TabIndex = 7;
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click_1);
            // 
            // SupporterUserTextBox
            // 
            this.SupporterUserTextBox.Enabled = false;
            this.SupporterUserTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.SupporterUserTextBox.Location = new System.Drawing.Point(1213, 6);
            this.SupporterUserTextBox.Name = "SupporterUserTextBox";
            this.SupporterUserTextBox.Size = new System.Drawing.Size(99, 26);
            this.SupporterUserTextBox.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(1123, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "שם התומך:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNumber,
            this.productTypeDataGridViewTextBoxColumn,
            this.dateReceivedDataGridViewTextBoxColumn,
            this.Note,
            this.userDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.supporterNameDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.MediumSlateBlue;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 641);
            this.dataGridView1.TabIndex = 0;
            // 
            // ProductNumber
            // 
            this.ProductNumber.DataPropertyName = "ProductNumber";
            this.ProductNumber.HeaderText = "מספר מוצר";
            this.ProductNumber.MinimumWidth = 8;
            this.ProductNumber.Name = "ProductNumber";
            this.ProductNumber.ReadOnly = true;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "סוג מוצר";
            this.productTypeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateReceivedDataGridViewTextBoxColumn
            // 
            this.dateReceivedDataGridViewTextBoxColumn.DataPropertyName = "DateReceived";
            this.dateReceivedDataGridViewTextBoxColumn.HeaderText = "תאריך קבלת המוצר";
            this.dateReceivedDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateReceivedDataGridViewTextBoxColumn.Name = "dateReceivedDataGridViewTextBoxColumn";
            this.dateReceivedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Note
            // 
            this.Note.DataPropertyName = "Note";
            this.Note.HeaderText = "הערה למוצר";
            this.Note.MinimumWidth = 8;
            this.Note.Name = "Note";
            this.Note.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "שם משתמש";
            this.userDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "ת.ז";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supporterNameDataGridViewTextBoxColumn
            // 
            this.supporterNameDataGridViewTextBoxColumn.DataPropertyName = "SupporterName";
            this.supporterNameDataGridViewTextBoxColumn.HeaderText = "שם התומך";
            this.supporterNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.supporterNameDataGridViewTextBoxColumn.Name = "supporterNameDataGridViewTextBoxColumn";
            this.supporterNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "תאריך התחלה";
            this.startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            this.startDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "תאריך סיום";
            this.endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            this.endDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "סיבה";
            this.reasonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            this.reasonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.AllowNew = true;
            this.productBindingSource1.DataSource = typeof(LoansApp.Folders.Product);
            // 
            // UpdateProductDetailsButton
            // 
            this.UpdateProductDetailsButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UpdateProductDetailsButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductDetailsButton.Location = new System.Drawing.Point(858, 77);
            this.UpdateProductDetailsButton.Name = "UpdateProductDetailsButton";
            this.UpdateProductDetailsButton.Size = new System.Drawing.Size(133, 27);
            this.UpdateProductDetailsButton.TabIndex = 12;
            this.UpdateProductDetailsButton.Text = "עדכון פרטי שיוך";
            this.UpdateProductDetailsButton.UseVisualStyleBackColor = false;
            this.UpdateProductDetailsButton.Click += new System.EventHandler(this.UpdateProductDetailsButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.AddProductButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductButton.Location = new System.Drawing.Point(997, 78);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(133, 27);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = "הוספת מוצר";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // noteProductClick
            // 
            this.noteProductClick.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.noteProductClick.Font = new System.Drawing.Font("Arial", 15.75F);
            this.noteProductClick.Location = new System.Drawing.Point(466, 73);
            this.noteProductClick.Name = "noteProductClick";
            this.noteProductClick.Size = new System.Drawing.Size(211, 32);
            this.noteProductClick.TabIndex = 15;
            this.noteProductClick.Text = "הוספת הערה למוצר";
            this.noteProductClick.UseVisualStyleBackColor = false;
            this.noteProductClick.Click += new System.EventHandler(this.noteProduct_Click);
            // 
            // exportCSV_button
            // 
            this.exportCSV_button.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.exportCSV_button.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportCSV_button.Location = new System.Drawing.Point(1136, 78);
            this.exportCSV_button.Name = "exportCSV_button";
            this.exportCSV_button.Size = new System.Drawing.Size(133, 27);
            this.exportCSV_button.TabIndex = 16;
            this.exportCSV_button.Text = "הצג באקסל";
            this.exportCSV_button.UseVisualStyleBackColor = false;
            this.exportCSV_button.Click += new System.EventHandler(this.exportCSV_button_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(LoansApp.Folders.Product);
            // 
            // Form1
            // 
            this.AcceptButton = this.SearchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1319, 751);
            this.Controls.Add(this.exportCSV_button);
            this.Controls.Add(this.noteProductClick);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.UpdateProductDetailsButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SupporterUserTextBox);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.DisconnectProductButton);
            this.Controls.Add(this.AssociateProductButton);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "השאלת ציוד";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExitButton_Click);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Button AssociateProductButton;
        private System.Windows.Forms.Button DisconnectProductButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.TextBox SupporterUserTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateProductDetailsButton;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.BindingSource productBindingSource1;
       
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button noteProductClick;
        private System.Windows.Forms.Button exportCSV_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateReceivedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supporterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
    }
}

