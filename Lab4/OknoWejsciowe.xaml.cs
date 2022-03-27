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
using Geometria;
namespace Lab4
{
    /// <summary>
    /// Logika interakcji dla klasy OknoWejsciowe.xaml
    /// </summary>
    public partial class OknoWejsciowe : Window
    {
        public OknoWejsciowe()
        {
            InitializeComponent();
        }
        double Szerokosc { 
            get { 
            return Convert.ToDouble(this.txtSzer.Text);
            }
        }
        double Wysokosc { 
            get
            {
                return Convert.ToDouble(this.txtWysokosc.Text);
            } }

        private void btnKoniec_Click(object sender, RoutedEventArgs e)
        {
            double wysokosc = Wysokosc;
            double szerokosc = Szerokosc;
            var Okno = new OknoWyjsciowe(szerokosc,wysokosc);
            Okno.ShowDialog();
        }

        private void btnStozek_Click(object sender, RoutedEventArgs e)
        {
            Stozek s = new Stozek("Stozek1",100, 100, double.Parse(txtWysokosc.Text), double.Parse(txtPromien.Text));
            var Okno = new OknoWyjsciowe(s.ToString());
            Okno.lblPole.Visibility = Visibility.Hidden;
            Okno.ShowDialog();

        }

        private void btnKula_Click(object sender, RoutedEventArgs e)
        {
            Kula k = new Kula("Kula1", 100, 100, double.Parse(txtPromien.Text));
            var Okno = new OknoWyjsciowe(k.ToString());
            Okno.lblPole.Visibility = Visibility.Hidden;
            Okno.ShowDialog();
        }
    }
}
