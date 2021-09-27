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

namespace kmPorLitro
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

        public void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            double kmIncial, kmFinal, qtdeLitros, kmRodado, media;

            // entrada de dados
            kmIncial = Convert.ToDouble(txtKMInicial.Text);
            kmFinal = Convert.ToDouble(txtKMFinal.Text);
            qtdeLitros = Convert.ToDouble(txtKMQtde);

            //Saber qtos km foram rodados
            kmRodado = kmFinal - kmIncial;

            //calculando km/ litro
            media = kmRodado / qtdeLitros;


        }
    }
}
