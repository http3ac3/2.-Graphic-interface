using System.Windows.Forms;

namespace UP_2._3_Graphic_interface
{
    public partial class Form1 : Form
    {
        int n;
        int start = 25;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GetButton_Click(object sender, System.EventArgs e)
        {
            ForBox.Text = "";
            WhileBox.Text = "";
            DoWhileBox.Text = "";
            if (!int.TryParse(NValueBox.Text, out n) || n <= 0 || n > 11)
            {
                MessageBox.Show("Введено неверное значение! Количество строк должно быть от 1 до 11!");
                return;
            }

            for (int i = 0; i < n; i++)
            {
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                ForBox.Text += s;
                start++;
            }

            start = 25;
            while (count < n)
            {
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                WhileBox.Text += s;
                start++;
                count++;
            }

            start = 25;
            count = 0;
            do
            {
                string s = $"{start} {start + 0.5} {start - 0.2}\n";
                s = s.Replace(',', '.');
                DoWhileBox.Text += s;
                start++;
                count++;
            } while (count < n);
        }
    }
}
