using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace coursework
{

    public partial class MainForm : System.Windows.Forms.Form
    {

        public MainForm()
        {
                InitializeComponent();
        }

        string Password;
        bool SuperUser;

        private void Form1_Load(object sender, EventArgs e)
        {
            //TOOLTIP
            ToolTip t = new ToolTip();
            t.SetToolTip(ImportButton, "Import Data from DataBase");
            t.SetToolTip(AddButton, "Add something to DB");
            t.SetToolTip(ExportButton, "Export Data to DataBase");
            t.SetToolTip(SearchButton, "Search product in MechStore");
            t.SetToolTip(ShowMinButton, "Show product with a minimum amount");
            t.SetToolTip(ClearButton, "Clear all product from store");

            //Console Greeting
            ConsoleBox.Text = "WELCOME!\nThank you for using/testing my programm!";

            //Setting password
            Password = InputBox.Show("Please set security password",Password);
        }

        private void DBPreView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Asking for password
            if(SuperUser == false)
            {
                if (Password == InputBox.Show("Please input your security password",Password))
                {
                    DBPreView.AllowUserToDeleteRows = true;
                    DBPreView.ReadOnly = false;
                    SuperUser = true;
                    ConsoleBox.Text = "Succes!\n"+"Now you SuperUser! SuperUser can edit and remove rows!";
                }
                else
                {
                    ConsoleBox.Text = "Invalid password!";
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //Adding
            Mechstore mechstore = new Mechstore(Convert.ToString(NameBox.Text), Convert.ToString(ManufactBox.Text), Convert.ToDouble(PriceUpDown.Value), Convert.ToInt32(AmountUpDown.Value), Convert.ToInt32(DrugUpDown.Value), Convert.ToInt32(СonsignmentUpDown1.Value));
            if (mechstore.check())
            {
                //Adding Object to PreView
                DBPreView.Rows.Add(mechstore.Name,mechstore.Manufact,mechstore.Price,mechstore.Amount, mechstore.StoreNumb,mechstore.Consignment);
                //All Input elements colors to default
                NameBox.BackColor = System.Drawing.Color.White;
                NameBox.ForeColor = System.Drawing.Color.Black;

                ManufactBox.BackColor = System.Drawing.Color.White;
                ManufactBox.ForeColor = System.Drawing.Color.Black;

                ConsoleBox.Text = "Succes!\n Now You can see result in DataBase Preview";
            }
            else
            {
                //Error Boxs
                if(mechstore.Error == 1)
                {
                    //Name Error
                    NameBox.BackColor = System.Drawing.Color.Red;
                    NameBox.ForeColor = System.Drawing.Color.White;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;

                }
                if (mechstore.Error == 2)
                {
                    //Manufacturer Error
                    ManufactBox.BackColor = System.Drawing.Color.Red;
                    ManufactBox.ForeColor = System.Drawing.Color.White;

                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                }
                //Deleting falt object
                mechstore = null;
                ConsoleBox.Text = "It seems you have a mistake\nYou must to correct red box!";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Searching
            bool min = false;
            int searchnumb = Convert.ToInt32(InputBox.Show("Please input number of store",min));
            for (int i = 0; i<DBPreView.Rows.Count; i++)
            {
                    if (Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) != searchnumb)
                    {
                        DBPreView.Rows[i].Visible = false;
                    }
                    ConsoleBox.Text = "Now you can see products ONLY in current store!" + '(' + searchnumb + ')' + "\nToo see ALL products press " + '"' + "Show All" + '"' + "button.";
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            //Lets make all visible!
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {
             DBPreView.Rows[i].Visible = true;  
            }
            ConsoleBox.Text = "Now you can see ALL products in DB";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
           bool min = false;
           int clearnumb = Convert.ToInt32(InputBox.Show("Please input number of store", min));
            //Deleting!
           for (int j = 0; j < DBPreView.Rows.Count; j++)
           {
             for (int i = 0; i < DBPreView.Rows.Count; i++)
             {
               if (Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) == clearnumb)
               {
                 DBPreView.Rows.RemoveAt(i);
               }
             }
           }

           // Just in case :D
           DBPreView.Refresh();
           int tmp = DBPreView.RowCount - 1;

           if (Convert.ToInt32(DBPreView.Rows[0].Cells[5].Value.ToString()) == clearnumb)
            DBPreView.Rows.RemoveAt(0);

           tmp = DBPreView.RowCount - 1;
           if ((Convert.ToInt32(DBPreView.Rows[tmp].Cells[5].Value.ToString()) == clearnumb))
            DBPreView.Rows.RemoveAt(tmp);

           DBPreView.Refresh();
           ConsoleBox.Text = "All products from store #" + clearnumb + " has been deleted!";
        }

        private void ShowMinButton_Click(object sender, EventArgs e)
        {
            //Lets find!
            bool min = true;
            int consignment = Convert.ToInt32(InputBox.Show("Please input MINIMAL consignment", min));
            for (int i = 0; i < DBPreView.RowCount; i++)
            {
                double nowprice = Convert.ToDouble(DBPreView.Rows[i].Cells[5].Value.ToString());
                if (nowprice < consignment)
                {
                    DBPreView.Rows[i].Visible = false;
                }
                ConsoleBox.Text = "Now you can see ONLY objects which amount bigger or equal " + consignment + "\nToo see ALL objects press " + '"' + "Show All" + '"' + "button.";
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        { 
            //Alot of strange symbols
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            excelapp.Visible = false;

            //Preparing to export user password
            for (int i = 0; i < DBPreView.RowCount; i++)
            {
                for (int j = 0; j < DBPreView.ColumnCount; j++)
                {
                    char[] s = Password.ToArray();
                    string str = "";
                    for (int f = s.Length - 1; f >= 0; f--)
                    {
                        str += s[f];
                    }
                    worksheet.Rows[i+1].Columns[j+1] = DBPreView.Rows[i].Cells[j].Value;
                    worksheet.Rows[1].Columns[7] = str;
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel (*.xlsx)|*.xlsx | Excel (*.xls)|*.xls";
            
            //Saving!
            string path =null;
            saveDialog.ShowDialog();
            path = saveDialog.FileName;
            if(path == "")
            {
                ConsoleBox.Text = "You MUST to choose name and path of file to create it!";
                excelapp.Quit();
            }
            else
            {
                ConsoleBox.Text = "File succesfully saved to " + path;
                excelapp.AlertBeforeOverwriting = false;
                workbook.SaveAs(path,ReadOnlyRecommended:true);
                excelapp.Quit();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            //Alot of strange symbols PART2

            //Lets remove trash! 
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {
                DBPreView.Rows.RemoveAt(i);
            }
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLSX)|*.XLSX | OLD_Excel (*.XLS)|*.XLS ";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                DataTable tb = new DataTable();
                string filename = opf.FileName;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

                //Opening
                ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                false, 0, true, 1, 0);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                 for (int i = 1; i <= ExcelApp.Rows.Count; i++)
                 {
                        if (ExcelApp.Cells[i, 1].Value != null)
                        {
                        //Importing our data to DBPreView
                          DBPreView.Rows.Add(ExcelApp.Cells[i, 1].Value, ExcelApp.Cells[i, 2].Value, ExcelApp.Cells[i, 3].Value, ExcelApp.Cells[i, 4].Value, ExcelApp.Cells[i, 5].Value, ExcelApp.Cells[i, 6].Value, ExcelApp.Cells[i, 7].Value, ExcelApp.Cells[i, 8].Value);
                        }
                        else
                        {
                           break;
                        }
                 }
                 string str = ExcelApp.Cells[1, 7].Value;
                 char[] s = str.ToArray();
                 str = "";
               for (int f = s.Length - 1; f >= 0; f--)
               {
                  str += s[f];
               }

               //Old Password
               Password = str;
               SuperUser = false;
               ConsoleBox.Text = "Data importing finished succesful\n Now in DBPreView you can see data from " + filename;
               ExcelApp.Quit();
            }
            else
            {
                //If the user changed the decision
                ConsoleBox.Text = "You MUST to choose name and path of file to open it!";
            }
        }
    }
}
