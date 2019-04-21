using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coursework
{
    public partial class InputBox : Form
    {        
        private static InputBox newInputBox;
        private Label label1;
        private TextBox SearchBox;
        private Button SubmitButton;
        private Button ExitButton;
        private NumericUpDown SearchUpDown1;
        private static string returnString;

        public InputBox()
        {
            InitializeComponent();
            ToolTip t = new ToolTip();
            t.SetToolTip(SubmitButton, "Submit password");
            t.SetToolTip(ExitButton, "Just close this window");
        }
        
        public static string Show(string inputBoxText,string Password)
        {
            newInputBox = new InputBox();
            newInputBox.SearchUpDown1.Visible = false;
            newInputBox.SearchUpDown1.Enabled = false;
            if (Password == ""|| Password ==null)
            {
               newInputBox.ExitButton.Enabled = false;
            }
            newInputBox.label1.Text = inputBoxText;
            newInputBox.ShowDialog();
            return returnString;
        }

        public static string Show(string inputBoxText)
        {
            newInputBox = new InputBox();
            newInputBox.SearchBox.Visible = false;
            newInputBox.SearchBox.Enabled = false;
            newInputBox.label1.Text = inputBoxText;
            newInputBox.ShowDialog();
            return returnString;
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            if (SearchBox.Enabled && SearchBox.Text == "")
            {
                SearchBox.BackColor = System.Drawing.Color.Red;
                SearchBox.ForeColor = System.Drawing.Color.White;
            }
            else
            {
                returnString = SearchBox.Text;
                newInputBox.Dispose();
                Close();
            }

            if (SearchBox.Enabled==false)
            {
                returnString =Convert.ToString(SearchUpDown1.Value);
                newInputBox.Dispose();
                Close();
            }

        }
        private void ExitButton1_Click(object sender, EventArgs e)
        {
            newInputBox.Dispose();
            Close();
        }







        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SearchUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.SearchUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.SearchBox.Location = new System.Drawing.Point(23, 25);
            this.SearchBox.Name = "textBox1";
            this.SearchBox.Size = new System.Drawing.Size(185, 20);
            this.SearchBox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(23, 52);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(133, 51);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.SubmitButton_Click_1);
            // 
            // SearchUpDown1
            // 
            this.SearchUpDown1.Location = new System.Drawing.Point(23, 25);
            this.SearchUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SearchUpDown1.Name = "SearchUpDown1";
            this.SearchUpDown1.Size = new System.Drawing.Size(185, 20);
            this.SearchUpDown1.TabIndex = 3;
            this.SearchUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // InputBox
            // 
            this.ClientSize = new System.Drawing.Size(237, 87);
            this.ControlBox = false;
            this.Controls.Add(this.SearchUpDown1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "InputBox";
            this.Load += new System.EventHandler(this.InputBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void InputBox_Load(object sender, EventArgs e)
        {

        }
    }
}
