using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VizusCoffee.DAO;
using VizusCoffee.Models;

namespace VizusCoffee.Servicos
{
    public class Relatorio
    {
        public void gerarJson()
        {
            CafeDAO cdao = new CafeDAO();

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Cafe>));
            diretorioExiste();
            FileStream fs = new FileStream(@"C:\VizuCafe - Relatorio\cafe.json", FileMode.OpenOrCreate);
            ser.WriteObject(fs, cdao.listar());
            fs.Close();
            MessageBox.Show("Arquivo criado com sucesso no diretorio - C:\\VizuCafe - Relatorio\\");
        }

        public void gerarCSV()
        {
            CafeDAO cdao = new CafeDAO();

            Stream saida = File.Open(@"C:\VizuCafe - Relatorio\cafe.csv", FileMode.Create);
            StreamWriter sw = new StreamWriter(saida);
            foreach(Cafe cafe in cdao.listar())
            {
                sw.WriteLine(cafe.ToCSV());
            }
            sw.Close();
            saida.Close();
        }


        public List<Cafe> lerJson(String FileName)
        {
            List<Cafe> cafes = new List<Cafe>();
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Cafe>));
            FileStream fs = new FileStream(@FileName, FileMode.OpenOrCreate);
            cafes = (List<Cafe>)ser.ReadObject(fs);
            fs.Close();
            return cafes;
        }
        private void diretorioExiste()
        {
            string diretorio = @"C:\VizuCafe - Relatorio";

            if (!Directory.Exists(diretorio))
            {
                Directory.CreateDirectory(diretorio);
                
            }

        }
    }
}
