using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListVsDictionary
{
    class Country
    {
        public string Ime { get; set; }
        public string ID { get; set; }
        public string GlavniGrad { get; set; }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country() { ID = "AUS", Ime = "AUSTRALIA", GlavniGrad = "Canberra" };
            Country country2 = new Country() { ID = "IND", Ime = "INDIA", GlavniGrad = "New Delhi" };
            Country country3 = new Country() { ID = "USA", Ime = "UNITED STATES", GlavniGrad = "Washington D.C." };
            Country country4 = new Country() { ID = "GBR", Ime = "UNITED KINGDOM", GlavniGrad = "London" };
            Country country5 = new Country() { ID = "CRO", Ime = "CROATIA", GlavniGrad = "Zagreb" };

            List<Country> listCountries = new List<Country>();
            listCountries.Add(country1);
            listCountries.Add(country2);
            listCountries.Add(country3);
            listCountries.Add(country4);
            listCountries.Add(country5);
            listCountries.Add(country1);
            string userChoice = string.Empty;
            do
            {
                Console.WriteLine("Enter country ID");
                string strCountryID = Console.ReadLine().ToUpper();
                //pronalazak grada po ID-u koji je unesao korisnik
                try
                {
                    Country c = listCountries.Find(Id => Id.ID == strCountryID);
                    Console.WriteLine($"Country = {c.Ime}, Capital City = {c.GlavniGrad}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Country ID is invalid");
                    Console.WriteLine(e.Message);
                }
                do
                {
                   Console.WriteLine("Do you want to continue - YES or NO?");
                   userChoice = Console.ReadLine().ToUpper();
                }
                while (userChoice != "NO" && userChoice != "YES");

            }
            while (userChoice == "YES");
        }
    }
}
