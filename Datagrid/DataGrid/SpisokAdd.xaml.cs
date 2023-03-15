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

namespace DataGrid
{
    /// <summary>
    /// Логика взаимодействия для SpisokAdd.xaml
    /// </summary>
    public partial class SpisokAdd : Window
    {
        public string Thing { get; set; }
        public string Date { get; set; }
        public SpisokAdd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Thing = tb_thing.Text;
            Date = tb_date.Text;
            DialogResult = true;
        }
    }
}
