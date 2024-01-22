using System.Reflection.Metadata.Ecma335;

namespace Events_MVP_hw
{
    delegate void MyEventHandler();
    internal class Program
    {
        static void Main(string[] args)
        {
            User mainUser = new User("user1");
            User otherUser = new User("user2");
            new Presenter(mainUser, new UserInterface());
        }
    }
}
