using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Spisok> spisok = new ObservableCollection<Spisok>();
        public MainWindow()
        {
            InitializeComponent();
            dt_grid.ItemsSource= spisok;
        }
        public class Spisok
        {
            public string Thing { get; set; }
            public string Date { get; set; }
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            SpisokAdd spisokAdd = new SpisokAdd();
            if (spisokAdd.ShowDialog() == true)
            {
                spisok.Add(new Spisok { Thing = spisokAdd.Thing, Date = spisokAdd.Date});
            }

        }

        private void btn_delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                spisok.Remove((Spisok)dt_grid.SelectedItem);
            }
            catch 
            {
                MessageBox.Show("Брат, оно того не стоит");
            }
            
        }
    }
}
