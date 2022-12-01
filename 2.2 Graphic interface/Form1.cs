using System;
using System.Windows.Forms;

namespace _2._2_Graphic_interface
{
    public partial class Form1 : Form
    {
        private int number;
        public Form1()
        {
            InitializeComponent();
        }

        private void KnowButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(CardNumberBox.Text, out number))
            {
                MessageBox.Show("Поле содержит недопустимые данные");
                return;
            }
            switch (number)
            {
                case 1: MessageBox.Show("Пики"); break;
                case 2: MessageBox.Show("Трефы"); break;
                case 3: MessageBox.Show("Бубны"); break;
                case 4: MessageBox.Show("Червы"); break;
                default: MessageBox.Show($"Масти с номером {number} не сущеcтвует!"); break;
            }

        }
    }
}
