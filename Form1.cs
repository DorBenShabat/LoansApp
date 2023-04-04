using LoansApp.Folders;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using excel = Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace LoansApp
{

    public partial class Form1 : Form
    {
        public readonly static string exepath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public readonly static string lockedFilePath = $@"{exepath}\Locked.txt";
        public readonly static string excelFilePath = $@"{exepath}\Folders\LoansApp.xlsx";
        private static PrincipalContext principalcontext;
        private static ActiveDirectoryRepo ActiveDirectoryRepo;
        public static BindingList<Product> Products = new BindingList<Product>();
        public static UserPrincipal currentUser;
        public static UserPrincipal user;

        public Form1()
        {
            InitializeComponent();
            Usings.CheckLockedFile(lockedFilePath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Startupprogress();
                SetProductsNumbers();
                currentUser = GetCurrentUser();
                Usings.CreateLockedFile(lockedFilePath, currentUser);
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
        public void SetProductsNumbers()
        {
            try
            {
                Products = JsonConvert.DeserializeObject<BindingList<Product>>(File.ReadAllText($@"{Form1.exepath}\Folders\ProductsNumbers.json"));
                dataGridView1.DataSource = Products;
            }
            catch (Exception ex)
            {
                ErrorMessage($"לא הצליח לטעון קובץ ProductsNumbers.Json: {ex.Message}");
                Usings.deleteLockedFile(lockedFilePath);
                Environment.Exit(-1);
            }
        }
        void Startupprogress()
        {
            try
            {

                principalcontext = new PrincipalContext(ContextType.Domain);
                ActiveDirectoryRepo = new ActiveDirectoryRepo(principalcontext);

            }
            catch (Exception ex)
            {
                ErrorMessage($"לא ניתן לטעון נתונים:{ex.Message}");
                Usings.deleteLockedFile(lockedFilePath);
                Environment.Exit(-1);
            }
        }
        private UserPrincipal GetCurrentUser()
        {
            try
            {
                var temp = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                temp = temp.Replace(@"OZAR\", "");
                var user = ActiveDirectoryRepo.CheckIdentityExistByUserName(temp);
                if (user != null)
                {
                    SupporterUserTextBox.Text = user.Name;
                    return user;
                }
                else throw new Exception();
            }
            catch (Exception ex)
            {
                ErrorMessage($"לא הצליח להביא את היוזר הנוכחי.{ex.Message}");
                Usings.deleteLockedFile(lockedFilePath);
                Environment.Exit(-1);
                return null;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
            if (string.IsNullOrWhiteSpace(selectedProduct.User))
            {
                Form2 form2 = new Form2(ActiveDirectoryRepo, selectedProduct);
                form2.ShowDialog();
                SetProductsNumbers();
            }
            else ErrorMessage($"מוצר משויך ל{selectedProduct.User},צריך לבצע ניתוק מוצר");
        }

        private void DisconnectProductButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
            if (string.IsNullOrEmpty(selectedProduct.User) && string.IsNullOrEmpty(selectedProduct.UserId))
            {
                ErrorMessage("מוצר לא משויך למשתמש");
                return;
            }
            try
            {
                var ADuser = ActiveDirectoryRepo.CheckIdentityExistById(selectedProduct.UserId);
                selectedProduct.User = string.Empty;
                selectedProduct.UserId = string.Empty;
                selectedProduct.StartDate = string.Empty;
                selectedProduct.EndDate = string.Empty;
                selectedProduct.Reason = string.Empty;
                selectedProduct.SupporterName = string.Empty;
                Usings.UpdateJson($@"{exepath}\Folders\ProductsNumbers.json", Products);
                SetProductsNumbers();
                if (ADuser != null) user = ActiveDirectoryRepo.DisconnectUserProduct(ADuser, Products);
                else Console.WriteLine("משתמש לא נמצא באקטיב לכן הנעילה לא תתבטל");

                InformationMessage($"מוצר נותק בהצלחה");

            }
            catch (Exception ex)
            {
                ErrorMessage($"לא הצליח לנתק מוצר מהמשתמש :{ex.Message}");
            }

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(ProductTextBox.Text))
                {

                    List<Product> temp = Products.Where(p => p.ProductNumber.Contains(ProductTextBox.Text.ToUpper())).ToList();
                    if (temp.Count == 0)
                    {
                        temp = Products.Where(p => p.ProductType.Contains(ProductTextBox.Text)).ToList();
                        if (temp.Count == 0) { ErrorMessage("לא נמצאו תוצאות חיפוש"); return; }
                        dataGridView1.DataSource = temp;
                    }
                    else dataGridView1.DataSource = temp;
                }
                else if (!string.IsNullOrWhiteSpace(FullNameTextBox.Text))
                {
                    if (Products != null) dataGridView1.DataSource = Products.Where(p => p.User.Contains(FullNameTextBox.Text)).ToList();
                    else ErrorMessage("לא נמצאו תוצאות חיפוש");
                }
                else SetProductsNumbers();
            }
            catch (Exception ex) {
                Trace.WriteLine(ex.Message);
                Trace.WriteLine(ex.StackTrace);
            }

        }
        private void noteProduct_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
            Usings.UpdateJson($@"{exepath}\Folders\ProductsNumbers.Json", Products);
            Form5 form5 = new Form5(Products, selectedProduct);
            form5.ShowDialog();

        }

        private void ExitButton_Click(object sender, FormClosingEventArgs e)
        {
            Usings.close(lockedFilePath);
        }

        private void UpdateProductDetailsButton_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;
            if (string.IsNullOrEmpty(selectedProduct.User) && string.IsNullOrEmpty(selectedProduct.UserId))
            {
                ErrorMessage("מוצר לא משויך למשתמש");
                return;
            }
            Form3 form3 = new Form3(ActiveDirectoryRepo, selectedProduct);
            form3.ShowDialog();
            SetProductsNumbers();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(Products);
            form4.ShowDialog();
        }
        private void exportCSV_button_Click(object sender, EventArgs e)
        {
            try
            {
                Usings.ExportExcel($@"{exepath}\Folders\LoansApp.xlsx", dataGridView1);
            }
            catch (Exception ex)
            {
                ErrorMessage($"{ex.Message}:לא ניתן לטעון קובץ אקסל");
            }

        }
        public void ErrorMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }
        private void InformationMessage(string message)
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign);
        }

        private void filterButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                List<Product> temp = new List<Product>(); 
                
                foreach (Product product in Products)
                {
                    DateTime currentDate = DateTime.Now; 

                    if(!product.EndDate.Equals(null)&& !string.IsNullOrWhiteSpace(product.EndDate))
                    {
                        DateTime endDateProduct = DateTime.ParseExact(product.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        
                        if (endDateProduct < currentDate)
                        {
                            temp.Add(product);
                        }

                    }
                    else dataGridView1.DataSource = temp;

                }
                if (temp.Count == 0) { ErrorMessage("לא נמצאו תוצאות חיפוש"); }
            } 
            catch (Exception ex)
            {
                ErrorMessage($"{ex.Message}לא הצליח לסדר לפי מוצרים שלא הוחזרו");
            }

        }
    }
}



