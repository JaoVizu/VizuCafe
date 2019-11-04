using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizusCoffee.Models
{
    public class Cafe
    {
        public string Nome { get; set; }
        public string Sabor { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }

        public String ToCSV()
        {
            return String.Format("{0},{1},{2},{3}", Nome, Sabor, Valor, Descricao);
        }
    }
}
