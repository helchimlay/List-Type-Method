using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MetodaLista
    {
        public double a, b, c;
        public List<double> PrimaryList = new List<double>{};
        public List<double> MetodaZLista(List<double> ToSort)
        {
            return new List<double>() {ToSort.Min(),ToSort.Max(),ToSort.Average() };
        }
    }
}
