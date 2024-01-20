using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_Metodos_abstratos_.Entities
{
    internal class Company : TaxPayer
    {

        public int Employees { get; set; }



        public Company(string name, double anualIncome, int employees) : base(name, anualIncome)
        {
            Employees = employees;
        }


        public override double Tax()
        {
            if (Employees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
