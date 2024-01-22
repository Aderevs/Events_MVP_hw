using Events_MVP_hw;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_MVP_hw
{
    internal class UserInterface
    {
        public HotkKeys hotKeys = new HotkKeys();
        public void ShowMenu()
        {
            Console.WriteLine("1.to send a messege:\n" +
                "\t1) press key S than press enter;\n" +
                "\t2) enter id of user who you want to send the messege;\n" +
                "\t3) enter the messege you want to send");

            Console.WriteLine(new string('-', 25));

            Console.WriteLine("to exit: \nenter exit");

            hotKeys.ReadHotKey();
            Console.WriteLine(new string('+', 100) + "\n\n\n\n\n");
        }

    }
}
