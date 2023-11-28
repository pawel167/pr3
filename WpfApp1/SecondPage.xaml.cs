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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int A))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(textbox2.Text, out int B))
            {
                MessageBox.Show("Введите число!");
            }
            if (!int.TryParse(textbox3.Text, out int C))
            {
                MessageBox.Show("Введите число!");
            }
            int a, b, c;
            a = B;
            b = C;
            c = A;
            answer.Text += $"a = {a}\n b = {b}\n c = {c}";
        }
    }
}
