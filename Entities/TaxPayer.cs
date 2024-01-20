﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Proposto_Metodos_abstratos_.Entities
{
    internal abstract class TaxPayer
    {
        public string Name { get; set; }

        public double AnualIncome { get; set; }



        public TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}