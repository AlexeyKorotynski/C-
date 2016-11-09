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
    /// Логика взаимодействия для Copy_Data.xaml
    /// </summary>
    public partial class Copy_Data : Window
    {
        public Collection tmpcol { get; set; }
        public Copy_Data(Collection col)
        {
            tmpcol = col;
            InitializeComponent();
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            tmpcol.Save_to_File();
            tmpcol.ClearCollection();
            Close();
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            tmpcol.ClearCollection();
            Close();
        }
    }
}
