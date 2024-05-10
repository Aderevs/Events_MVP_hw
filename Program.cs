using System.Reflection.Metadata.Ecma335;

namespace Events_MVP_hw
{
    delegate void MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                try
                {
                    User mainUser = new User("user1");
                    User otherUser = new User("user2");
                    new Presenter(mainUser, new UserInterface());
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("\n\n\n");
                    Console.ResetColor();
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                    Console.ResetColor();
                    Console.WriteLine("\n\n\n");
                    Console.ReadKey();
                }
            }

        }
    }
}
