using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_MVP_hw
{
    internal class Presenter
    {
        User model = null;
        UserInterface view = null;

        public Presenter(User model, UserInterface view)
        {
            this.view = view;
            this.model = model;

            this.view.hotKeys.PressKeyS += new PressKeyEventHandler(SendMessegeEvent);

            view.ShowMenu();
        }
        public void SendMessegeEvent()
        {
            int userId = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            string info = model.SendMessege(message, userId);
            Console.WriteLine(info);
            Console.WriteLine(new string('=', 100) + "\n\n\n");
        }

    }
}
