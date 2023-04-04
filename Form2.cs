using System;
using System.Windows.Forms;
using System.DirectoryServices.AccountManagement;
using Newtonsoft.Json;
using System.IO;
using LoansApp.Folders;
using System.Collections.Generic; 




namespace LoansApp
{
    public partial class Form2 : Form
    {
        ActiveDirectoryRepo AD_Respository ;
        Product selectedProduct; 
        UserPrincipal user;
        public Form2(ActiveDirectoryRepo ActiveDirectoryRepo, Product selectedProduct)
        {
            InitializeComponent();
            this.AD_Respository = ActiveDirectoryRepo;
            this.selectedProduct = selectedProduct;
            SetProductsNumbers();
            SetProductTimes();
            
        } 
        private void SetProductsNumbers()
        {
            ProductNumLabel.Text = selectedProduct.ProductNumber;
        } 
        private void SetProductTimes()
        {
                List<int> times = new List<int>();
                times.AddRange(new List<int>() {0, 1, 7, 14, 30, 90 });
                EndDateComboBox.DataSource = times;
        } 
        private void FullNameSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                user = AD_Respository.CheckIdentityExistByName(FullNameTextBox.Text);
                if (user != null)
                {
                    ShowFullNameTextBox.Text = $"{user.Name} - {user.SamAccountName}";
                } 
                else
                {
                    ShowFullNameTextBox.Text = "משתמש לא נמצא באקטיב";
                } 
            } 
            catch (MultipleMatchesException ex)
            {
                ErrorMessage($"נמצא יותר ממשתמש אחד עם שם זה, יש לנסות עם ת.ז,{ex.Message}");
            }
        }
        private void IDSearchButton_Click(object sender, EventArgs e)
        {
            user = AD_Respository.CheckIdentityExistById(IdTextBox.Text); 
            if (user != null)
            {
                ShowFullNameTextBox.Text = $"{user.Name} - {user.SamAccountName}";
            }
            else
            {
                ShowFullNameTextBox.Text = "משתמש לא נמצא באקטיב";
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(selectedProduct.User) || !string.IsNullOrWhiteSpace(selectedProduct.UserId))
            {
                ErrorMessage("יש לבצע ניתוק מוצר ואחרי זה לשייך");
                return;
            }
            try
            {
                if (user != null)
                {
                    user = AD_Respository.AssociateUserProduct(user, int.Parse(EndDateComboBox.SelectedValue.ToString()));
                    selectedProduct.User = user.Name;

                    string userID = Usings.PrincipalToID(user.UserPrincipalName);
                    if (!string.IsNullOrEmpty(userID))
                    {
                        selectedProduct.UserId = userID;
                      
                    }

                }
                else 
                {
                   if (!string.IsNullOrWhiteSpace(FullNameTextBox.Text))
                    {
                        selectedProduct.User = FullNameTextBox.Text;
                        InformationMessage("משתמש לא נמצא באקטיב לכן לא תתבצע נעילת משתמש"); 
                    } 
                   else
                    {
                        ErrorMessage("לא נמצא משתמש לפי ת.ז יש להכניס שם מלא ולאחר מכן ללחוץ שמור");
                        return;
                    }
                }
                selectedProduct.SupporterName = Form1.currentUser.Name;
                selectedProduct.StartDate = DateTime.Now.ToString("dd/MM/yyy");
                selectedProduct.EndDate = DateTime.Now.AddDays(int.Parse(EndDateComboBox.SelectedValue.ToString())).ToString("dd/MM/yyy");
                Usings.UpdateJson($@"{Form1.exepath}\Folders\ProductsNumbers.json", Form1.Products);
                InformationMessage($"מוצר שויך ל \"{FullNameTextBox.Text}\"");

                Close();
            } 
            catch (Exception ex)
            {
                ErrorMessage($"לא הצליח לשייך מוצר {ex.Message}");
            }
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
