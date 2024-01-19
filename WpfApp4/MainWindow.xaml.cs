using Microsoft.Win32;
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
using System.IO;
using System.Collections.ObjectModel;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {




        ObservableCollection<Ujdiak> diakok = new ObservableCollection<Ujdiak>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Importalas_Click(object sender, RoutedEventArgs e)
        {
            if (diakok.Count > 0)
            {
                ShowDialog();
            }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt vagy csv fajlok (*.txt;*.csv)|*.txt;*.csv";
            if (ofd.ShowDialog() == true)
            {
                foreach (string fajl in File.ReadAllLines(ofd.FileName).Skip(1))
                {
                    diakok.Add(new Ujdiak(fajl.Split(";")));
                }
            }

            dgLista.ItemsSource = diakok;
        }

        private void Torles_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in dgLista.SelectedItems)
            {
                diakok.Remove((Ujdiak)item);
            }
        }

        private void Felvetel_Click(object sender, RoutedEventArgs e)
        {
            Ujdiak asd = new Ujdiak();
            Bekeres ujablak = new Bekeres(asd);
            ujablak.Show();
            diakok.Add(asd);
            dgLista.ItemsSource = diakok;
        }
    }
}
