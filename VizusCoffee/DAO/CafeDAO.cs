using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VizusCoffee.Models;

namespace VizusCoffee.DAO
{
    public class CafeDAO
    {
        private MySqlConnection conn;
        private MySqlDataAdapter daCafe;
        private DataSet dsCafe;
        private const string tabela = "cafe";
        private String connectionString = ConfigurationManager.ConnectionStrings["banco"].ConnectionString;

        public List<Cafe> listar()
        {
            List<Cafe> listaCafe = new List<Cafe>();
            try
            {
                conn = new MySqlConnection(connectionString);
                conn.Open();
                String query = "SELECT * FROM cafe";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Prepare();
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cafe cafe = new Cafe()
                    {
                        Nome = Convert.ToString(dr["Nome"]),
                        Sabor = Convert.ToString(dr["Sabor"]),
                        Valor = Convert.ToDecimal(dr["Valor"]),
                        Descricao = Convert.ToString(dr["Descricao"])
                    };
                    listaCafe.Add(cafe);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return listaCafe;

            
        }

        public void inserir(Cafe cafe)
        {
            conn = new MySqlConnection(connectionString);
            conn.Open();
            String query = "INSERT INTO cafe (nome, sabor, valor, descricao) VALUES(@nome,@sabor,@valor,@descricao)";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@nome", cafe.Nome);
            cmd.Parameters.AddWithValue("@sabor", cafe.Sabor);
            cmd.Parameters.AddWithValue("@valor", cafe.Valor);
            cmd.Parameters.AddWithValue("@descricao", cafe.Descricao);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
