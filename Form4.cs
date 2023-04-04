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
using System.Diagnostics;
using Newtonsoft.Json;



namespace LoansApp
{
    public partial class Form4 : Form
    {
        private BindingList<Product> products;
        public readonly static string expath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        private static List<Typep> ProductTypeList;

        public Form4(BindingList<Product> products)
        {
            InitializeComponent();
            SetProductType();
            this.products = products;
            
        }
        private void SetProductType()
        {
            try
            {
                ProductTypeList = JsonConvert.DeserializeObject<List<Typep>>(File.ReadAllText($@"{Form1.exepath}\Folders\ProductType.json"));
            }
            catch (Exception ex)
            {
                ErrorMessage($"לא הצליח לטעון את קובץ ProductType.json: {ex.Message}");
            }
            TypeComboBox.DataSource = ProductTypeList;
            TypeComboBox.DisplayMember = "ProductType";
            TypeComboBox.ValueMember = "ProductType";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            /*if(string.IsNullOrWhiteSpace(DateReceived.CalendarDimensions.ToString()))
            {
                ErrorMessage("יש להכניס תאריך קבלה של המוצר");
                return; 
            }*/
            try
            {
                if (!string.IsNullOrWhiteSpace(ProductNumberTextBox.Text) && ProductNumberTextBox.Text.Length <= 7)
                {
                    Product product = new Product
                    {
                        ProductNumber = ProductNumberTextBox.Text,
                        EndDate = string.Empty,
                        StartDate = string.Empty,
                        Reason = string.Empty,
                        SupporterName = string.Empty,
                        User = string.Empty,
                        UserId = string.Empty,
                        ProductType = TypeComboBox.SelectedValue.ToString(),
                        DateReceived = DateReceived.Value.ToString("dd/MM/yyyy"),
                        Note = string.Empty
                    };
                    products.Add(product);
                    Usings.UpdateJson($@"{expath}\Folders\ProductsNumbers.Json", products);
                    InformationMessage($"מוצר {ProductNumberTextBox.Text} נוסף בהצלחה");
                    Form1.ActiveForm.Refresh();
                    Close();
                }
                else
                    ErrorMessage("חסר מספר מוצר");
            } catch (Exception ex)
            {
                Trace.WriteLine(ex.StackTrace);
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

