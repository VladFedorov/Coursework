using System;
using System.Net.Mail;
using System.Data;
using System.Net;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Text;

namespace coursework
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        string DefPass(System.Windows.Forms.RichTextBox ConsoleBox, string Password)
        {
            ConsoleBox.Text += "\n Error with Password importing. Password set to " + Password;
            return "toor";
        }

        string DefWord(System.Windows.Forms.RichTextBox ConsoleBox, string Password)
        {
            ConsoleBox.Text += "\n Error with SecretWord importing. Password set to " + Password;
            return "toor";
        }

        void PasswordReset(string email, string Password)
        {
            MailAddress from = new MailAddress("nxnxngh@gmail.com","MechStoreEditor");
            MailAddress to = new MailAddress(email);
            MailMessage message = new MailMessage(from,to);
            message.Subject = "Your password";
            message.Body = "<h2>"+" Dear User!"+"</h2 >" +
            "<br>"+" Your Password to MechStoreEditor" + "<h2>" + Password + "</h2>" +
            "<br>"+" Best wishes," +
            "<br>"+" Vlad Fedorov";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("nxnxngh@gmail.com", "********************");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }

        public MainForm()
        {
                InitializeComponent();
            
        }

        string Password;
        bool SuperUser;
        string email;
        string secretword;

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
            t.SetToolTip(ShowAllButton, "Show All products in DataBase");
            t.SetToolTip(ConsoleBox,"Here you can see helpfull information");
            t.SetToolTip(DBPreView, "Here you can see products");
            
            //Console Greeting
            ConsoleBox.Text = "WELCOME!\nThank you for using/testing my programm!\n(To see reference,just hold a mouse on different objects)";

            //Setting password
            Password = InputBox.Show("Please set security password",Password);

            //Setting Secret Word
            secretword = InputBox.Show("Please set secret word", secretword);

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

            int searchnumb = 0;
            searchnumb = Convert.ToInt32(InputBox.Show("Please input number of store", min));
            if (searchnumb != 0)
                try
                {

                    for (int i = 0; i < DBPreView.Rows.Count; i++)
                    {
                            if (Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) != searchnumb)
                            {
                                DBPreView.Rows[i].Visible = false;
                            }
                            ConsoleBox.Text = "Now you can see products ONLY in current store!" + '(' + searchnumb + ')' + "\nToo see ALL products press " + '"' + "Show All" + '"' + "button.";
                    }

                }
                catch
                {
                    ConsoleBox.Text = "It seems we have error.\nPlease recheck store_number collumn.\n(This culmn must have only digits)";
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
            int clearnumb = 0;
            clearnumb = Convert.ToInt32(InputBox.Show("Please input number of store", min));
            //Deleting!
            try
            {
                for (int i = DBPreView.Rows.Count-1; i >= 0; i--)
                {
                  if (Convert.ToInt32(DBPreView.Rows[i].Cells[4].Value) == clearnumb)
                  {
                    DBPreView.Rows.RemoveAt(i);
                  }

                }
                DBPreView.Refresh();
                ConsoleBox.Text = "All products from store #" + clearnumb + " has been deleted!";
            }
            catch
            {
                ConsoleBox.Text = "It seems we have error.\nPlease recheck store_number collumn.\n(This culmn must have only digits)";
            }
        }

        private void ShowMinButton_Click(object sender, EventArgs e)
        {
            //Lets find!
            bool min = true;
            int consignment = 0;
            consignment = Convert.ToInt32(InputBox.Show("Please input MINIMAL consignment", min));
            if (consignment != 0)
                try
                {


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
                catch
                {
                    ConsoleBox.Text = "It seems we have error.\nPlease recheck consignment collumn\n(All cells in this column must contain digits)";
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
            var bytes = Encoding.UTF8.GetBytes(Password);
            string passwd = Convert.ToBase64String(bytes);
            for (int i = 0; i < DBPreView.RowCount; i++)
            {
                for (int j = 0; j < DBPreView.ColumnCount; j++)
                {
                    worksheet.Rows[i+1].Columns[j+1] = DBPreView.Rows[i].Cells[j].Value;
                }
            }

            var bytesecret = Encoding.UTF8.GetBytes(secretword);
            string secword = Convert.ToBase64String(bytesecret);
            worksheet.Rows[1].Columns[8] = secword;

            worksheet.Rows[1].Columns[7] = passwd;
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
            for (int i = (DBPreView.Rows.Count-1); i >= 0; i--)
            {
                DBPreView.Rows.RemoveAt(i);
                DBPreView.Refresh();
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
                ConsoleBox.Text = "Data importing finished succesful\n Now in DBPreView you can see data from " + filename;
                //Old Password
                string passwd = Convert.ToString(ExcelApp.Cells[1, 7].Value);
                if (passwd != "")
                {
                    try
                    {
                        var bytes = Convert.FromBase64String(passwd);
                        Password = Encoding.UTF8.GetString(bytes);
                        SuperUser = false;
                        ConsoleBox.Text += "\nPassword has been succesfully imported";
                    }
                    catch
                    {
                        DefPass(ConsoleBox, Password);
                    }
                } 
                else
                {
                    Password = DefPass(ConsoleBox, Password);
                }
                //Old SecretWord
                string secword = Convert.ToString(ExcelApp.Cells[1, 8].Value);
                if (secword != "")
                {
                    try
                    {
                        var bytesword = Convert.FromBase64String(secword);
                        secretword = Encoding.UTF8.GetString(bytesword);
                        ConsoleBox.Text += "\nSecretWord has been succesfully imported";
                    }
                    catch
                    {
                        DefWord(ConsoleBox, secretword);
                    }
                }
                else
                {
                    secretword = DefPass(ConsoleBox, secretword);
                }
                ExcelApp.Quit();
            }
            else
            {
                //If the user changed the decision
                ConsoleBox.Text = "You MUST to choose name and path of file to open it!";
            }
        }

        private void MainForm_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            //HELP
            Process.Start(@"C:\Users\VUser\source\repos\Coursework\help\index.html");
        }

        private void RecoveryButton_Click(object sender, EventArgs e)
        {
            //E-MAIL password recovery
            string secword = secretword;
            if (secretword == InputBox.Show("Please set secretword", secword))
            {
                email = InputBox.Show("Please set e-mail adress", email);
                try
                { 
                    PasswordReset(email, Password);
                    ConsoleBox.Text = "Please check your e-mail";
                }
                catch
                {
                    ConsoleBox.Text = "Error!";
                }
            }
            else
                ConsoleBox.Text = "Secret word is invalid";
        }
    }
}