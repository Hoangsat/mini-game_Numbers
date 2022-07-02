using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numbers
{
    public partial class Form1 : Form
    {
        int buttons = 9;
        int current = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
@"Game with numbers. 
Enter number 1 to 9", "About" );
        }

        private void menu_start_Click(object sender, EventArgs e)
        {
            start_game();
        }
        private void start_game()
        {
            for (int j = 1; j <= buttons; j++)
                button(j).Text=j.ToString();
            for (int j = 1; j <= buttons; j++)
                button(j).Visible = true;
        }
        private Button button (int nr)
        {
            switch (nr)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                    default:
                    return null;

            }         
           
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
