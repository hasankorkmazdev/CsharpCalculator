using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            History.Text = "";
            
        }
        #region FormProp


        private void btn_Exit_MouseHover(object sender, EventArgs e)
        {
                btn_Exit.BackColor = Color.Red;
                btn_Exit.ForeColor = Color.White;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
                btn_Exit.BackColor = SystemColors.Control;
                btn_Exit.ForeColor = SystemColors.ControlText;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }
        #endregion




        double value = 0;
        string Operation = "";//Uygulanacak İşlem
        bool operation_pressed = false;//Operator Kullanıldımı
        
        private bool operation_flag;

        private void ButtonClick(object sender, EventArgs e)
        {
            if ((Display.Text == "0" || operation_pressed==true))
                Display.Clear();
            operation_pressed = false;
            Button btn = (Button)sender;
            Display.Text = Display.Text + btn.Text;
          
        }

        private void Clear(object sender, EventArgs e)
        {
            Display.Text = "0";
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            if (!operation_flag)
            {
                operation_flag = true;
            }
            else if (operation_flag == true)
            {
                Calc();
            }
            Button btn = (Button)sender;
            Operation = btn.Text;
            value = Convert.ToDouble(Display.Text);
            operation_pressed = true;
            History.Text += value + " " + Operation;
           
            
        }

        private void EqualsClick(object sender, EventArgs e)
        {
            History.Text = "";
            Calc();
        }

        private void HistoryClear(object sender, EventArgs e)
        {
            Display.Text = "0";
            History.Text = "";
            value = 0;
        }
        private void Calc()
        {
            switch (Operation)
            {
                case "+":
                    Display.Text = (value + Convert.ToDouble(Display.Text)).ToString();
                    break;
                case "-":
                    Display.Text = (value - Convert.ToDouble(Display.Text)).ToString();
                    break;
                case "x":
                    Display.Text = (value * Convert.ToDouble(Display.Text)).ToString();
                    break;
                case "/":
                    Display.Text = (value / Convert.ToDouble(Display.Text)).ToString();
                    break;
                default: break;
            }
            operation_pressed = false;
            value = double.Parse(Display.Text);
        }

        private void ShiftCClick(object sender, EventArgs e)
        {
            byte charcount = 0;
            charcount =(byte)(Display.Text.Count());
            if (charcount==0 || charcount==1)
            {
                Display.Text = "0";
            }
            else if (charcount>1)
            {
                Display.Text = Display.Text.Substring(0, charcount - 1);
            }
            
          


        }
    }
}
