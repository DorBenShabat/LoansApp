using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LoansApp.Folders;
using System.DirectoryServices.AccountManagement;
using Newtonsoft.Json;
using System.IO;

namespace LoansApp
{
    public partial class Form3 : Form
    {
        ActiveDirectoryRepo activeDirectoryRepo;
        Product selectedProduct;
        UserPrincipal user;
        public Form3(ActiveDirectoryRepo activeDirectoryRepo, Product selectedProduct)
        {
            InitializeComponent();
            this.activeDirectoryRepo = activeDirectoryRepo;
            this.selectedProduct = selectedProduct;
            ProductNumberLabel.Text = selectedProduct.ProductNumber;
            SetProductTimes();
        }
     private void SetProductTimes()
        {
            List<int> times = new List<int>();
            times.AddRange(new List<int> { 1, 7, 14, 30, 90 });
            EndDateComboBox.DataSource = times;
            EndDateComboBox.SelectedIndex = -1;
        }
            private void OKButton_Click(object sender, EventArgs e)
        {
            if (!ReasonRichTextBox.Text.Equals(selectedProduct.Reason))
            {
                selectedProduct.Reason = ReasonRichTextBox.Text;
            }
            if (EndDateComboBox.SelectedIndex != -1)
            {
                selectedProduct.EndDate = DateTime.Now.AddDays(int.Parse(EndDateComboBox.SelectedValue.ToString())).ToString("dd/MM/yyyy");
                user = activeDirectoryRepo.CheckIdentityExistById(selectedProduct.UserId);

                if (user != null) activeDirectoryRepo.ExtensionProduct(user, int.Parse(EndDateComboBox.SelectedValue.ToString()));
                else ErrorMessage($"לא הצליח לבצע הארכה באקטיב למשתמש {selectedProduct.User}");
            } 
            Usings.UpdateJson($@"{Form1.exepath}\Folders\ProductsNumbers.json", Form1.Products);
            InformationMessage($"פרטי מוצר \"{selectedProduct.ProductNumber}\"");
            Close();
        } 
        private void ErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
        private void InformationMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
