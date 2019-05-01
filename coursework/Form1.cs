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
        int[] date = new int[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //TOOLTIP
            ToolTip t = new ToolTip();
            t.SetToolTip(ImportButton, "Import Data from DataBase");
            t.SetToolTip(AddButton, "Add Medicine to DB");
            t.SetToolTip(ExportButton, "Export Data to DataBase");
            t.SetToolTip(SearchButton, "Search medicine in Drugstore");
            t.SetToolTip(ShowMinButton, "Show medicine with a minimum amount");
            t.SetToolTip(ClearButton, "Clear all expired drugs");

            //Console Greeting
            ConsoleBox.Text = "WELCOME!\nThank you for using/testing my programm!";

            //Setting password
            Password = InputBox.Show("Please set security password",Password);
        }

        private void DBPreView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            date[0] = Convert.ToInt32(DayUpDown.Value);
            date[1] = Convert.ToInt32(MonthUpDown.Value);
            date[2] = Convert.ToInt32(YearUpDown.Value);
            Drugstore drugstore = new Drugstore(Convert.ToString(NameBox.Text), Convert.ToString(ManufactBox.Text), Convert.ToDouble(PriceUpDown.Value), Convert.ToInt32(AmountUpDown.Value), Convert.ToInt32(DrugUpDown.Value), date);
            if (drugstore.check())
            {
                //Adding Object to PreView
                DBPreView.Rows.Add(drugstore.Name,drugstore.Manufact,drugstore.Price,drugstore.Amount, drugstore.DrugNumb,drugstore.ExpDate[0]+"."+ drugstore.ExpDate[1] + "."+drugstore.ExpDate[2]);
                //All Input elements colors to default
                NameBox.BackColor = System.Drawing.Color.White;
                NameBox.ForeColor = System.Drawing.Color.Black;

                ManufactBox.BackColor = System.Drawing.Color.White;
                ManufactBox.ForeColor = System.Drawing.Color.Black;

                PriceUpDown.BackColor = System.Drawing.Color.White;
                PriceUpDown.ForeColor = System.Drawing.Color.Black;

                DayUpDown.BackColor = System.Drawing.Color.White;
                DayUpDown.ForeColor = System.Drawing.Color.Black;

                MonthUpDown.BackColor = System.Drawing.Color.White;
                MonthUpDown.ForeColor = System.Drawing.Color.Black;

                YearUpDown.BackColor = System.Drawing.Color.White;
                YearUpDown.ForeColor = System.Drawing.Color.Black;

                ConsoleBox.Text = "Succes!\n Now You can see result in DataBase Preview";
            }
            else
            {
                //Error Boxs
                if(drugstore.Error == 1)
                {
                    //Name Error
                    NameBox.BackColor = System.Drawing.Color.Red;
                    NameBox.ForeColor = System.Drawing.Color.White;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;

                    PriceUpDown.BackColor = System.Drawing.Color.White;
                    PriceUpDown.ForeColor = System.Drawing.Color.Black;

                    DayUpDown.BackColor = System.Drawing.Color.White;
                    DayUpDown.ForeColor = System.Drawing.Color.Black;

                    MonthUpDown.BackColor = System.Drawing.Color.White;
                    MonthUpDown.ForeColor = System.Drawing.Color.Black;

                    YearUpDown.BackColor = System.Drawing.Color.White;
                    YearUpDown.ForeColor = System.Drawing.Color.Black;
                }
                if (drugstore.Error == 2)
                {
                    //Manufacturer Error
                    ManufactBox.BackColor = System.Drawing.Color.Red;
                    ManufactBox.ForeColor = System.Drawing.Color.White;

                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                    PriceUpDown.BackColor = System.Drawing.Color.White;
                    PriceUpDown.ForeColor = System.Drawing.Color.Black;

                    DayUpDown.BackColor = System.Drawing.Color.White;
                    DayUpDown.ForeColor = System.Drawing.Color.Black;

                    MonthUpDown.BackColor = System.Drawing.Color.White;
                    MonthUpDown.ForeColor = System.Drawing.Color.Black;

                    YearUpDown.BackColor = System.Drawing.Color.White;
                    YearUpDown.ForeColor = System.Drawing.Color.Black;
                }
                if (drugstore.Error == 3)
                {
                    //Price Error
                    PriceUpDown.BackColor = System.Drawing.Color.Red;
                    PriceUpDown.ForeColor = System.Drawing.Color.White;

                    DayUpDown.BackColor = System.Drawing.Color.White;
                    DayUpDown.ForeColor = System.Drawing.Color.Black;

                    MonthUpDown.BackColor = System.Drawing.Color.White;
                    MonthUpDown.ForeColor = System.Drawing.Color.Black;

                    YearUpDown.BackColor = System.Drawing.Color.White;
                    YearUpDown.ForeColor = System.Drawing.Color.Black;

                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;
                }
                if (drugstore.Error == 4)
                {
                    //Day Error
                    DayUpDown.BackColor = System.Drawing.Color.Red;
                    DayUpDown.ForeColor = System.Drawing.Color.White;

                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;

                    PriceUpDown.BackColor = System.Drawing.Color.White;
                    PriceUpDown.ForeColor = System.Drawing.Color.Black;

                    MonthUpDown.BackColor = System.Drawing.Color.White;
                    MonthUpDown.ForeColor = System.Drawing.Color.Black;

                    YearUpDown.BackColor = System.Drawing.Color.White;
                    YearUpDown.ForeColor = System.Drawing.Color.Black;
                }
                if (drugstore.Error == 5)
                {
                    //Month Error
                    MonthUpDown.BackColor = System.Drawing.Color.Red;
                    MonthUpDown.ForeColor = System.Drawing.Color.White;

                    YearUpDown.BackColor = System.Drawing.Color.White;
                    YearUpDown.ForeColor = System.Drawing.Color.Black;

                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;

                    PriceUpDown.BackColor = System.Drawing.Color.White;
                    PriceUpDown.ForeColor = System.Drawing.Color.Black;

                    DayUpDown.BackColor = System.Drawing.Color.White;
                    DayUpDown.ForeColor = System.Drawing.Color.Black;
                }
                if (drugstore.Error == 6)
                {
                    //Year Error
                    NameBox.BackColor = System.Drawing.Color.White;
                    NameBox.ForeColor = System.Drawing.Color.Black;

                    ManufactBox.BackColor = System.Drawing.Color.White;
                    ManufactBox.ForeColor = System.Drawing.Color.Black;

                    PriceUpDown.BackColor = System.Drawing.Color.White;
                    PriceUpDown.ForeColor = System.Drawing.Color.Black;

                    DayUpDown.BackColor = System.Drawing.Color.White;
                    DayUpDown.ForeColor = System.Drawing.Color.Black;

                    MonthUpDown.BackColor = System.Drawing.Color.White;
                    MonthUpDown.ForeColor = System.Drawing.Color.Black;

                    YearUpDown.BackColor = System.Drawing.Color.Red;
                    YearUpDown.ForeColor = System.Drawing.Color.White;
                }
                //Deleting falt object
                drugstore = null;
                ConsoleBox.Text = "It seems you have a mistake\nYou must to coret red box!";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            bool fraction = false;
            int searchnumb = Convert.ToInt32(InputBox.Show("Please input number of drugstore",fraction));
            for (int i = 0; i<DBPreView.Rows.Count; i++)
            {
                if(Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) != searchnumb)
                {
                    DBPreView.Rows[i].Visible = false;
                }
                ConsoleBox.Text = "Now you can see medicine  ONLY in current drugstore!"+'('+searchnumb+')'+"\nToo see ALL medicine press " + '"' + "Show All" + '"' + "button.";
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {
             DBPreView.Rows[i].Visible = true;  
            }
            ConsoleBox.Text = "Now you can see ALL medicine in DB";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < DBPreView.Rows.Count; j++)
            {
                for (int i = 0; i < DBPreView.Rows.Count; i++)
                {
                    date = DBPreView.Rows[i].Cells[5].Value.ToString().Split('.').Select(n => Convert.ToInt32(n)).ToArray();
                    if (date[0] + date[1] * 31 + date[2] * 365 < System.DateTime.Now.Day + System.DateTime.Now.Month * 31 + System.DateTime.Now.Year * 365)
                    {
                        DBPreView.Rows.RemoveAt(i);
                    }
                }
            }
            date = DBPreView.Rows[0].Cells[5].Value.ToString().Split('.').Select(n => Convert.ToInt32(n)).ToArray();
            if (DBPreView.RowCount !=0 && date[0] + date[1] * 31 + date[2] * 365 < System.DateTime.Now.Day + System.DateTime.Now.Month * 31 + System.DateTime.Now.Year * 365)
            DBPreView.Rows.RemoveAt(0);
            DBPreView.Refresh();
            ConsoleBox.Text = "All expired medicine has been deleted!";
        }

        private void ShowMinButton_Click(object sender, EventArgs e)
        {
            bool fraction = true;
            double minprice = Convert.ToDouble(InputBox.Show("Please input MINIMAL price",fraction));
            for (int i = 0; i < DBPreView.RowCount; i++)
            {
                double nowprice = Convert.ToDouble(DBPreView.Rows[i].Cells[2].Value.ToString());
                if (nowprice < minprice)
                {
                  DBPreView.Rows[i].Visible = false;
                }
                       ConsoleBox.Text = "Now you can see ONLY objects whitch price bigger or equal " + minprice + "\nToo see ALL objects press " + '"' + "Show All" + '"' + "button.";
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            Excel.Application excelapp = new Excel.Application();
            Excel.Workbook workbook = excelapp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.ActiveSheet;
            excelapp.Visible = false;

            for (int i = 0; i < DBPreView.RowCount; i++)
            {
                for (int j = 0; j < DBPreView.ColumnCount; j++)
                {
                    worksheet.Rows[i+1].Columns[j+1] = DBPreView.Rows[i].Cells[j].Value;
                }
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel (*.XLSX)|*.XLSX | Excel (*.XLS)|*.XLS";
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
                workbook.SaveAs(path);
                excelapp.Quit();
            }
        }

        private void ImportButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {
                DBPreView.Rows.RemoveAt(i);
            }
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Excel (*.XLSX)|*.XLSX | OLD_Excel (*.XLS)|*.XLS ";
            if(opf.ShowDialog() == DialogResult.OK)
            {
                DataTable tb = new DataTable();
                string filename = opf.FileName;
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook ExcelWorkBook;
                Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;

                ExcelWorkBook = ExcelApp.Workbooks.Open(filename, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false,
                    false, 0, true, 1, 0);
                ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);
                for (int i = 1; i <= ExcelApp.Rows.Count; i++)
                {
                    if (ExcelApp.Cells[i, 1].Value != null)
                    {
                        DBPreView.Rows.Add(ExcelApp.Cells[i, 1].Value, ExcelApp.Cells[i, 2].Value, ExcelApp.Cells[i, 3].Value, ExcelApp.Cells[i, 4].Value, ExcelApp.Cells[i, 5].Value, ExcelApp.Cells[i, 6].Value, ExcelApp.Cells[i, 7].Value, ExcelApp.Cells[i, 8].Value);
                        ConsoleBox.Text = "Data importing finished succesful\n Now in DBPreView you can see data from" + filename;
                    }
                    else
                    {
                     break;
                    }
                }
                
                ExcelApp.Quit();
            }
            else
            {
                ConsoleBox.Text = "You MUST to choose name and path of file to open it!";
            }
            
        }
    }
}
