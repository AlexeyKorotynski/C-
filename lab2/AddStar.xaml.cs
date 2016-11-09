using lab2;
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
using System.Windows.Shapes;

namespace lab2
{
    /// <summary>
    /// Логика взаимодействия для AddStar.xaml
    /// </summary>
    public partial class AddSt : Window
    {
        Star tmpStar = new Star();
        Collection tmpcol;

        public AddSt(ref Collection col)
        {
            InitializeComponent();
            this.DataContext = tmpStar;
            tmpcol = col;
        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            tmpcol.AddStar(tmpStar);
            this.Close();
        }
    }
}
