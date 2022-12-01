using System.Windows.Forms;

namespace UP_2._4_Graphic_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 41; i <= 80; i++)
            {
                TextBox.Text += i.ToString() + " ";
                if (i % 10 == 0) TextBox.Text += "\n";
            }
        }
    }
}
