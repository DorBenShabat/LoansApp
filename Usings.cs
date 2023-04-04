 
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoansApp.Folders;
using System.Text.Json;
using CsvHelper;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel; 



namespace LoansApp
{
   public class Usings
    { 
        public readonly static string expath = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
        public static void close(string lockedFilePath)
        {
            deleteLockedFile(lockedFilePath);
            Environment.Exit(0);
        } 
        public static void CheckLockedFile(string lockedFilePath)
        {
            if (File.Exists(lockedFilePath))
            {
                MessageBox.Show($"המערכת פתוחה על ידי {File.ReadAllText(lockedFilePath)}");
                Environment.Exit(-1);
            }
        } 
        public static void CreateLockedFile(string path, UserPrincipal currentUser)
        {
            if (!File.Exists(path))
            {
                using (FileStream fs = File.Create(path))
                {
                    var name = currentUser.Name;
                    byte[] data = new UTF8Encoding(true).GetBytes(name);
                    fs.Write(data, 0, data.Length);
                    fs.Dispose();
                }
            }
        } 
        public static void deleteLockedFile(string path)
        {
            if (File.Exists(path)) File.Delete(path);
        } 

        public static void UpdateJson(string path, BindingList<Product> products)
        {
            TextWriter writer = null;
            try
            {  
                var jsonConvert = JsonConvert.SerializeObject(products, Formatting.Indented);
                writer = new StreamWriter(path, false);
                writer.WriteLine(jsonConvert);
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"לא עדכן קובץ JSON.{ex.Message}");
            } 
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
        public static string PrincipalToID(string userprincipalname)
        {
            if (string.IsNullOrEmpty(userprincipalname)) { return null; }

            return userprincipalname.Split('@')[0];
        }
        public static void ExportExcel(string path, DataGridView myDGV)
        {
            if (myDGV.Rows.Count > 0)
            {
                //string fileName = "LoansApp.xlsx";
                string pathtosave = $@"O:\Tmicha\Dor\LoansApp\LoansApp\LoansApp\bin\Debug\Folders\LoansApp.xlsx";
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
                Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];
                for (int i = 0; i < myDGV.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
                }

                for (int r = 0; r < myDGV.Rows.Count; r++)
                {
                    for (int i = 0; i < myDGV.ColumnCount; i++)
                    {
                        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                    }
                    Application.DoEvents();
                }
                worksheet.Columns.EntireColumn.AutoFit();
                xlApp.DisplayAlerts = false;
                worksheet.SaveAs(pathtosave, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, Excel.XlSaveAsAccessMode.xlNoChange, Excel.XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);

                //workbook.SaveAs(pathtosave, Excel.XlSaveAsAccessMode.xlNoChange/*.Equals(pathtosave*/));
                xlApp.Quit();



                Process.Start(path);

            }

        }

    }
}
