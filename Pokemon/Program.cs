namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool x = true;
            while (x)
            {
                Console.WriteLine("Enter Charmander's name: ");
                string char_name = Console.ReadLine();
                Charmander charmander = new Charmander(char_name, "fire", "water", 100);
                Console.WriteLine("Name: " + charmander.GetName());
                Console.WriteLine("Type: " + charmander.GetType());
                Console.WriteLine("Weakness: " + charmander.GetWeakness());
                Console.WriteLine("Hp: " + charmander.GetHp());
                for (int i = 0; i <= 10; i++)
                { Console.WriteLine(char_name); }
                Console.WriteLine("Do you want to continue y/n: ");
                string check_state = Console.ReadLine().ToLower();
                if (check_state == "y")
                {
                    x = true;
                }
                else
                {
                    x = false; break;
                }
            }
        }

    }
}