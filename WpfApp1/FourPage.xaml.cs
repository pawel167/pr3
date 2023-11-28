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
using static System.Math;

namespace WpfApp1
{  
    public partial class FourPage : Page
    {
        public FourPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            answer.Clear();
            if (!int.TryParse(textbox1.Text, out int u))
            {
                MessageBox.Show("Поле А только число!");
            }
            double x = Pow(u,2);
            double m = u / 3;
            double y, z, d, b;
            z = Pow(Pow(m,4)+m-Pow(Cos(x + m),2),0.5);
            d = m - Pow(m, 2);
            b = Sqrt(m) - m + x;
            y = z / d + b;
            answer.Text += y;
        }
    }
}
