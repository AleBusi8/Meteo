using System;
using System.Collections.Generic;
using System.IO;
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

namespace Busi.Alessandro._4H.Meteo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Meteo[] arr = new Meteo[20];
        double max = 0;
        string città;
        int conta = 0;

        public MainWindow()
        {
            int j = 0;
            int pos = j;
            InitializeComponent();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Meteo();
                arr[i].Nome = "";
                arr[i].Max = 0;
                arr[i].Min = 0;
                arr[i].Escursione = 0;
            }




            // scrittura();
            while (j < arr.Length && arr[j].Nome != "")
            {
                if (arr[j].Escursione > arr[pos].Escursione)
                {
                    pos = j;
                }
                j++;
            }

            città = $"Città: {Convert.ToString(città)}  Escursione termica: {Convert.ToString(max)}";

            dgdati.ItemsSource = arr;
        }

        void scrittura()
        {
            StreamWriter dati = new StreamWriter("dati.txt");
            for (int i = 0; i < arr.Length; i++)
            {
                dati.WriteLine($"{arr[i].Nome};{arr[i].Max};{arr[i].Min};{arr[i].Escursione}");
            }
            dati.Close();
        }





        private void Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (conta < arr.Length)
            {
                Meteo nuova = new Meteo();
                AggiungiCittà facciata = new AggiungiCittà();
                facciata.ShowDialog();

                if (facciata.uscita)
                {
                    try
                    {
                        nuova.Nome = facciata.nuovoNome.Text;
                        nuova.Max = Convert.ToDouble(facciata.nuovoMax.Text);
                        nuova.Min = Convert.ToDouble(facciata.nuovoMin.Text);
                        nuova.Escursione = nuova.Max - nuova.Min;
                        arr[conta++] = nuova;
                        scrittura();
                        dgdati.Items.Refresh();
                    }
                    catch
                    {
                        MessageBox.Show("Non hai completato tutti i campi richiesti");
                    }

                }

            }
            else
            {
                MessageBox.Show("NON VA BENE");
            }
        }
    }
}
