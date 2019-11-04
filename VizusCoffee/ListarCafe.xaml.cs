﻿using MySql.Data.MySqlClient;
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

namespace VizusCoffee
{
    /// <summary>
    /// Interaction logic for ListarCafe.xaml
    /// </summary>
    public partial class ListarCafe : Window
    {
        CafeDAO cafeDao;
        
        public ListarCafe()
        {
            InitializeComponent();
            cafeDao = new CafeDAO();
            dgCafe.ItemsSource = cafeDao.listar();

        }

        private void DgCafe_AutoGeneratedColumns(object sender, EventArgs e)
        {
            dgCafe.Columns[0].Width = 100;
            dgCafe.Columns[1].Width = 100;
            dgCafe.Columns[2].Width = 60;
            dgCafe.Columns[3].Width = 200;

        }
    }
}
