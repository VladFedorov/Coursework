using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public string Password1 { get => Password; set => Password = value; }

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

                ConsoleBox.Text = "It seens you have a mistake\nYou must to cooret red box!";
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int searchnumb = Convert.ToInt32(InputBox.Show("Please input number of drugstore"));
            for (int i = 0; i<DBPreView.Rows.Count; i++)
            {
                if(Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) != searchnumb)
                {
                    DBPreView.Rows[i].Visible = false;
                }
            }
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {
             DBPreView.Rows[i].Visible = true;  
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DBPreView.Rows.Count; i++)
            {

                date = Convert.ToString(DBPreView.Rows[i].Cells[4].Value).Split('.').Select(Int32.Parse).ToArray();
                //if (date[0]+ date[1]*31+date[2]*365 > System.DateTime.Now.Day + System.DateTime.Now.Month * 31 + System.DateTime.Now.Year * 365)
                //{
                //    DBPreView.Rows[i].Visible = false;
                //}
            }
        }

        private void ShowMinButton_Click(object sender, EventArgs e)
        {
            int minprice = Convert.ToInt32(InputBox.Show("Please input Minimal price"));
            for(int i =0; i<DBPreView.RowCount; i++)
            if (Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) <= minprice)
            {
                DBPreView.Rows[i].Visible = false;
            }
        }
    }
}
