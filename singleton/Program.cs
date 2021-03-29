using System;

namespace Singleton  // Tomasz Wiśniewski, Artur Janiak   
{                    //Zespuł onomatopeja
    class Singleton
    {
        // private instance of the class
        private static Singleton instance = new Singleton();

        // some variables 
        private int count;
        private int count2;

        // private constructor
        private Singleton() { }

        // static accessories for the instance of singleton class
        // The internal keyword is an access modifier for types and type members.
        internal static Singleton Instance
        {
            get => instance;
            set => instance = value;
        }

        public int Count { get => count; set => count = value; }
        public int Count2 { get => count2; set => count2 = value; }

        public void Dodawanie()
        {
            Console.WriteLine(Count + Count2);
        }
        public void Odejmowanie()
        {
            Console.WriteLine(Count - Count2);
        }
        public void Mnożenie()
        {
            Console.WriteLine(Count * Count2);
        }
        public void Dzielenie()
        {
            Console.WriteLine(Count / Count2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Singleton s1 = Singleton.Instance;

            Console.WriteLine(" Podaj 1 liczbe ");
            s1.Count = int.Parse(Console.ReadLine());

            Console.WriteLine(" Podaj 2 liczbe ");
            s1.Count2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Podaj + : - : * : /   ");
            string znak = Console.ReadLine();
            if (znak == "+")
                s1.Dodawanie();
            if (znak == "-")
                s1.Odejmowanie();
            if (znak == "*")
                s1.Mnożenie();
            if (znak == "/")
                s1.Dzielenie();
            

        }
    }
}



