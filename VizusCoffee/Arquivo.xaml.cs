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
using System.Windows.Shapes;
using VizusCoffee.DAO;
using VizusCoffee.Models;
using VizusCoffee.Servicos;

namespace VizusCoffee
{
    /// <summary>
    /// Lógica interna para Arquivo.xaml
    /// </summary>
    public partial class Arquivo : Window
    {
        public Arquivo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.gerarJson();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.gerarCSV();
        }

        private void BtnDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON files (*.json) | *.json";
            if(openFileDialog.ShowDialog() == true)
            {
                Relatorio relatorio = new Relatorio();
                CafeDAO cDao = new CafeDAO();
                foreach (Cafe cafe in relatorio.lerJson(openFileDialog.FileName))
                {
                    cDao.inserir(cafe);
                }
            }
        }
    }
}
