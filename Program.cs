using System;
using System.Text;

namespace CompanyEnum
{
    enum Company
    {
        KievFirm1,
        KievFirm2,
        KievFirm3,
        KharkivFirm1,
        KharkivFirm2,
        KharkivFirm3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Перелік фірм:");
            Console.WriteLine($"{(int)Company.KievFirm1} - Київська фірма 1");
            Console.WriteLine($"{(int)Company.KievFirm2} - Київська фірма 2");
            Console.WriteLine($"{(int)Company.KievFirm3} - Київська фірма 3");
            Console.WriteLine($"{(int)Company.KharkivFirm1} - Харківська фірма 1");
            Console.WriteLine($"{(int)Company.KharkivFirm2} - Харківська фірма 2");
            Console.WriteLine($"{(int)Company.KharkivFirm3} - Харківська фірма 3");

            Console.WriteLine("Введіть номери фірм через кому:");
            string input = Console.ReadLine();
            string[] companyNumbers = input.Split(',');

            Console.WriteLine("Прізвище автора програми: Мощенко Дмитро");

            Console.WriteLine("Фірми в місті Київ:");
            foreach (string number in companyNumbers)
            {
                int companyNumber = int.Parse(number.Trim());
                if (companyNumber >= (int)Company.KievFirm1 && companyNumber <= (int)Company.KievFirm3)
                {
                    Console.WriteLine(GetCompanyName((Company)companyNumber));
                }
            }

            Console.WriteLine("Фірми в місті Харків:");
            foreach (string number in companyNumbers)
            {
                int companyNumber = int.Parse(number.Trim());
                if (companyNumber >= (int)Company.KharkivFirm1 && companyNumber <= (int)Company.KharkivFirm3)
                {
                    Console.WriteLine(GetCompanyName((Company)companyNumber));
                }
            }

            Console.ReadLine();
        }

        static string GetCompanyName(Company company)
        {
            switch (company)
            {
                case Company.KievFirm1:
                    return "Київська фірма 1";
                case Company.KievFirm2:
                    return "Київська фірма 2";
                case Company.KievFirm3:
                    return "Київська фірма 3";
                case Company.KharkivFirm1:
                    return "Харківська фірма 1";
                case Company.KharkivFirm2:
                    return "Харківська фірма 2";
                case Company.KharkivFirm3:
                    return "Харківська фірма 3";
                default:
                    return "";
            }
        }
    }
}
