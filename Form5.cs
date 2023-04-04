using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoansApp.Folders;
using System.IO;
using Newtonsoft.Json;

namespace LoansApp
{
    public partial class Form5 : Form
    {
        private BindingList<Product> products;
        public readonly static string expath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        Product selectedProduct;
        public Form5(BindingList<Product> products, Product selectedProduct)
        {
            this.selectedProduct = selectedProduct;
            this.products = products;
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(noteTextBox.Text))
            {
                ErrorMessage("נא לכתוב הערה לפני השמירה");
                return;
            }
            selectedProduct.Note = noteTextBox.Text;
            Usings.UpdateJson($@"{expath}\Folders\ProductsNumbers.Json", Form1.Products);
            InformationMessage("הערה נשמרה בהצלחה");
            Form1.ActiveForm.Refresh();
            Close();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void ErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
        private void InformationMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
    }
}
