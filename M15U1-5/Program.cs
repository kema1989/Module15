using System;
using System.Collections.Generic;
using System.Linq;

namespace M15U1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var softwareManufacturers = new List<string>()
{
   "Microsoft", "Apple", "Oracle"
};

            var hardwareManufacturers = new List<string>()
{
   "Apple", "Samsung", "Intel"
};
            var itCompanies = softwareManufacturers.Union(hardwareManufacturers);

            foreach(var company in itCompanies)
                Console.WriteLine(company);
        }
    }
}
