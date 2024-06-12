using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComfortCalculator
{
    public class Country
    {
        public double SocProgressScore {  get; set; }
        public double CrimeIndex { get; set; }
        public double FreedomIndex { get; set; }

        public double getComfortScore()
        {
            double score = (SocProgressScore + (100 - CrimeIndex) + FreedomIndex) / 3;

            score = score * 100;

            score = (int)score;
            double _out = score;
            _out /= 100;
            return _out;
        }

    }
}
