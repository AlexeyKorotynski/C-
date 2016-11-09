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
    /// Логика взаимодействия для Edit_Asterism.xaml
    /// </summary>
    public partial class Edit_Asterism : Window
    {
        public Collection tmpcol { get; set; }
        public Edit_Asterism(ref Collection col)
        {
            InitializeComponent();
            tmpcol = col;
            AsterismsList.DataContext = tmpcol;
        }
        private void AstreismList_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            Asterism_Edit_Window Asterism_Edit_Window = new Asterism_Edit_Window(tmpcol.Asterisms[AsterismsList.SelectedIndex]);
            Asterism_Edit_Window.Show();
        }

        private void Remove_Asterism(object sender, RoutedEventArgs e)
        {
            tmpcol.Asterisms.Remove(tmpcol.Asterisms[AsterismsList.SelectedIndex]);
        }
    }
}
