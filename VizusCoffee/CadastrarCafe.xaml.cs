using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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
using VizusCoffee.DAO;
using VizusCoffee.Models;

namespace VizusCoffee
{
    /// <summary>
    /// Interaction logic for CadastrarCafe.xaml
    /// </summary>
    public partial class CadastrarCafe : Window
    {
    
        public CadastrarCafe()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CafeDAO cdao = new CafeDAO();
            Cafe cafe = new Cafe()
            {
                Nome = txtNome.Text,
                Sabor = txtSabor.Text,
                Valor = Convert.ToDecimal(txtValor.Text),
                Descricao = txtDesc.Text
            };

            cdao.inserir(cafe);
            MessageBox.Show("Cafe inserido com sucesso!");
        }
    }
}
