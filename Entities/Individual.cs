using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_Metodos_abstratos_.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }



        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
                return (0.15 * AnualIncome) - (HealthExpenditures * 0.5);
            }
            else
            {
                return 0.25 * AnualIncome - (HealthExpenditures * 0.5);
            }
        }
    }
}
