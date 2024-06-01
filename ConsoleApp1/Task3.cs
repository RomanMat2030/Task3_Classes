using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task3
{
    class CreditCard
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private string familyName;
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }
        private string numberCard;
        public string NumberCard
        {
            get { return numberCard; }
            set
            {
                if (value.Length == 16)
                {
                    numberCard = value;
                }
                else
                {
                        throw new Exception("Incorrect number of card!");
                }
            }
        }
        private int Cvc;
        public int cvc
        {
            get { return Cvc; }
            set
            {
                if (value >= 3 && value <= 999)
                {
                    Cvc = value;
                }
                else
                {
                    throw new Exception("Incorrect cvc of card!");
                }
            }
        }
        DateTime completion_date;
        public DateTime Completion_Date
        {
            get { return completion_date; }
            set
            {
                if (value >= DateTime.Now)
                {
                    completion_date = value;
                }
                else
                {
                    throw new ArgumentException("The expiration date of the card cannot be in the past.");
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Family Name: {FamilyName}");
            Console.WriteLine($"Number of the credit card: {NumberCard}");
            Console.WriteLine($"CVC of the card: {cvc}");
            Console.WriteLine($"Completion date: {Completion_Date}");
        }
    }
    class Task3
    {
        static void Main(string[] args)
        {
            CreditCard[] creditCards = new CreditCard[1];
            for (int i = 0; i < creditCards.Length; i++)
            {
                creditCards[i] = new CreditCard();
                try
                {
                    Console.Write("Enter your first name: ");
                    creditCards[i].FirstName = Console.ReadLine();
                    Console.Write("Enter your last name: ");
                    creditCards[i].LastName = Console.ReadLine();
                    Console.Write("Enter your family name: ");
                    creditCards[i].FamilyName = Console.ReadLine();
                    Console.Write("Enter your number card: ");
                    creditCards[i].NumberCard = Console.ReadLine();
                    Console.Write("What's your CVC?: ");
                    creditCards[i].cvc = int.Parse(Console.ReadLine());
                    Console.Write("Completion date: ");
                    creditCards[i].Completion_Date = DateTime.Parse(Console.ReadLine());
                }
                catch (FormatException Fex)
                {
                    Console.WriteLine(Fex.Message);
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                }
            }
            foreach (var credit_Card in creditCards)
            {
                credit_Card.Print();
            }
        }
    }
}