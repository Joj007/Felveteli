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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for Bekeres.xaml
    /// </summary>
    public partial class Bekeres : Window
    {
        Ujdiak hhh;
        public Bekeres()
        {
            InitializeComponent();

            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtOm);
            textBoxes.Add(txtDatum);
            textBoxes.Add(txtNev);
            textBoxes.Add(txtEmail);
            textBoxes.Add(txtCim);
            textBoxes.Add(txtMatek);
            textBoxes.Add(txtMagyar);
        }

        public Bekeres(Ujdiak aa):this()
        {
            this.hhh = aa;
        }

        private void txtMagyar_LostFocus(object sender, RoutedEventArgs e)
        {
            hhh.OM_Azonosito = txtOm.Text;
            hhh.Neve = txtNev.Text;
            hhh.Email = txtEmail.Text;
            hhh.SzuletesiDatum = DateTime.Parse(txtDatum.Text);
            hhh.ErtesitesiCime = txtCim.Text;
            hhh.Magyar = Convert.ToInt32(txtMagyar.Text);
            hhh.Matematika = Convert.ToInt32(txtMatek.Text);
            Close();

        }

    }
}
