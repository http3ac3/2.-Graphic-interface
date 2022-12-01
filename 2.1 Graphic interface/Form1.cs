using System;
using System.Windows.Forms;

namespace _2._1_Graphic_interface
{
    public partial class Form1 : Form
    {
        private double x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(XPosBox.Text, out x) || !double.TryParse(YPosBox.Text, out y))
            {
                MessageBox.Show("В полях с координтами содержатся недопустимые данные!", "Ошибка");
                return;
            }

            if ((x * x + y * y < 64 && x <= 0) && (x * x + y * y > 9 && x <= 0))
            {
                MessageBox.Show("Да");
            }
            else if ((x * x + y * y > 64) || (x * x + y * y < 9) || x > 0)
            {
                MessageBox.Show("Нет");
            }
            else
            {
                MessageBox.Show("На границе");
            }
        }
    }
}
