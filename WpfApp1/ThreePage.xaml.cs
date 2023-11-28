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
    /// Логика взаимодействия для ThreePage.xaml
    /// </summary>
    public partial class ThreePage : Page
    {   
        public ThreePage()
        {
            InitializeComponent();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!double.TryParse(textbox1.Text, out double a))
            {
                MessageBox.Show("Поле А только число!");
            }          
           if (a < 0 || a > 360)
            {
               MessageBox.Show("А должно быть больше чем 0 и меньше чем 360!");
                textbox1.Clear();
                answer.Clear();
            }
            a /= 180.0;
            answer.Text += $"{a} радианн";
        }
    }
}
