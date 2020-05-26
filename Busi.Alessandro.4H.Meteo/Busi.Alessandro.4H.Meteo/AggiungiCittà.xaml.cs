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

namespace Busi.Alessandro._4H.Meteo
{
    /// <summary>
    /// Logica di interazione per AggiungiCittà.xaml
    /// </summary>
    public partial class AggiungiCittà : Window
    {
        public bool uscita;
        public AggiungiCittà()
        {
            InitializeComponent();
        }

        private void salva_Click(object sender, RoutedEventArgs e)
        {
            uscita = true;
            this.Close();
        }

        private void annulla_Click_(object sender, RoutedEventArgs e)
        {
            uscita = false;
            this.Close();
        }
    }
}
