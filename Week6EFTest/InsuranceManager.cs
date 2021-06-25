using System;
using Week6EFTest.Models;
using Week6EFTest.Repositories;

namespace Week6EFTest
{
    public class InsuranceManager
    {
        static IRepository<Policy> repPolicy = new RepoPolicy();
        static IRepository<Client> repClient = new RepoClient();
       
        internal static bool Menu()
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1. Add Client");
            Console.WriteLine("2. Add a new Policy");
            Console.WriteLine("4. Check Info");
            Console.WriteLine("5. Exit");
            int choice = InputCheck(4);
            Console.Clear();
            return ChoiceMng(choice);
        }

        private static int InputCheck(int MaxChoice)
        {
            Console.Write("Your Choice ->");
            bool check = Int32.TryParse(Console.ReadLine(), out int choice);
            while (choice > MaxChoice || choice < 0 || check == false)
            {
                Console.WriteLine("Inserisci un valore corretto");
                check = Int32.TryParse(Console.ReadLine(), out choice);
            }
            return choice;
        }

        private static bool ChoiceMng(int choice)
        {
            bool goon = true;
            switch (choice)
            {
                case 1:
                    AddClient();
                    break;
                case 2:
                    AddPolicy();
                    break;
                case 3:
                    SeeInfo();
                    break;
            
                default:
                    goon = false;
                    Console.WriteLine("GoodBye");
                    break;
            }
            return goon;
        }

        private static void SeeInfo()
        {
            Console.WriteLine("What do you want to see?");
            Console.WriteLine("1. Clients - 2. Policies ");
            int scelta = InputCheck(2);
            if (scelta == 1)
            {
                var clients = repClient.GetAll();
                Helper.StampaCollection<Client>(clients);
            }
            else 
            {
                var policy = repPolicy.GetAll();
                Helper.StampaCollection<Policy>(policy);
            }
           
        }

        private static void AddPolicy()
        {
            Policy policyToadd;
            Console.WriteLine("Which kind of policy would you like to submit?");
            int typapolicy = InputCheck(3);
            Console.WriteLine("Insert the corresponding code");
            string num = Console.ReadLine();
            Console.WriteLine("Insert Date");
            DateTime date = CheckDate();
            Console.WriteLine("Insert the price");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert the monthlyfee");
            double monthlyfee = Convert.ToDouble(Console.ReadLine());

            if (typapolicy == 1)
            {
                Console.WriteLine("Insert Plate");
                string plate = Console.ReadLine();
                Console.WriteLine("Insert Displacement");
                int displacement = 

                policyToadd = new Auto()
                {
                    NUM = num,
                    Amount = amount,
                    MonthlyFee = monthlyfee,
                    Date = date,
                    Plate = plate,

                };
            }
            else if (typapolicy == 2)
            {
                Console.WriteLine("Insert Years");
                int years = Convert.ToInt32(Console.ReadLine());
                policyToadd = new Life()
                {
                    NUM = num,
                    Amount = amount,
                    MonthlyFee = monthlyfee,
                    Date = date,
                };
            }
            else
            {
                prodottoDaAggiungere = new Prodotto()
                {
                    Codice = codice,
                    Descrizione = descrizione,
                    Prezzo = prezzo
                };
            }
            var numeroReparto = ScegliNumeroReparto();
            if (numeroReparto > 0)
            {
                repoReparto.AggiungiProdotto(numeroReparto, prodottoDaAggiungere);
            }

        }

        private static void AddClient()
        {
            throw new NotImplementedException();
        }
    }
}