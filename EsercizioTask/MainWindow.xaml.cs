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

namespace EsercizioTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static int Multipli(int n)
        {
            int n_multipli = 0;
            for (int i = 0; i < 200000000; i++)
            {
                if ((i / n) % 2 == 0)
                {
                    n_multipli++;
                }
            }
            return n_multipli;
        }

    
        private void btnEsegui_Click(object sender, RoutedEventArgs e)
        {
        int n = int.Parse(txtNumero.Text);
        Task<int> risultato = Task.Factory.StartNew(() => Multipli(n));
            lblMultpli.Content = $"{risultato.Result}";

        }
    }
}
