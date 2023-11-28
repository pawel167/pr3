using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
        }                
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int x))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(textbox2.Text, out int y))
            {
                MessageBox.Show("Введите число!");
            }
            if (x <= 0 && y <= 0)
            {
                MessageBox.Show("Число должно быть больше нуля!");
                textbox1.Clear();
                textbox2.Clear();
                answer.Clear();
            }
            int a, b, c, d;
            a = x + y;
            b = x - y;
            c = x * y;
            d = x / y;
            answer.Text += $"сумма ={a}\n разность ={b}\n произведение ={c}\n частное ={d}";

        }
    }
}

