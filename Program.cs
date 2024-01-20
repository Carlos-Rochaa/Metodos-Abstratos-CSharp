// See https://aka.ms/new-console-template for more information

using Exercicio_Proposto_Metodos_abstratos_.Entities;
using System.Globalization;

List<TaxPayer> list = new List<TaxPayer>();
Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Tax payer #{i} data: ");
    Console.Write("Individual or company (i/c)? ");
    char option = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual Income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (option == 'i')
    {
        Console.Write("Health expenditures: ");
        double expenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, income, expenditures));

    }
    else
    {
        Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine()); 
        list.Add(new Company(name, income, employees));
    }
}

Console.WriteLine();

Console.WriteLine("TAXES PAID: ");
double total = 0.0; 
foreach (TaxPayer taxPayer in list)
{
    Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
    total += taxPayer.Tax(); 
}
Console.WriteLine();
Console.Write("Total taxes: $ " + total.ToString("F2", CultureInfo.InvariantCulture)); 


