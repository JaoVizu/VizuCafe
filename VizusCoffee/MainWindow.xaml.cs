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
using VizusCoffee.Servicos;

namespace VizusCoffee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CadastrarCafe frmCadCafe;
        public MainWindow()
        {
            frmCadCafe = new CadastrarCafe();
            InitializeComponent();
        }

        private void btnCadastrarCafe_Click(object sender, RoutedEventArgs e)
        {
            frmCadCafe.Show();
        }

        private void btnListarCafe_Click(object sender, RoutedEventArgs e)
        {
            ListarCafe frmListCafe = new ListarCafe();
            frmListCafe.Show();
        }

        private void BtnRelatorio_Click(object sender, RoutedEventArgs e)
        {
            Arquivo arq = new Arquivo();
            arq.Show();
        }
    }
}
