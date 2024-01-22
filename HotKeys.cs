using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_MVP_hw
{
    public delegate void PressKeyEventHandler();
    internal class HotkKeys
    {
        public event PressKeyEventHandler PressKeyS;
        public void PressKeySEvent()
        {
            if (PressKeyS != null)
            {
                PressKeyS();
            }
        }

        public void ReadHotKey()
        {
            bool exit = false;
            while (!exit)
            {
                string option = Console.ReadLine();

                switch (option)
                {
                    case "s":
                    case "S":
                        PressKeySEvent();
                        break;
                    case "exit":
                    case "Exit":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("there is no such option");
                        break;
                }
            }
        }
    }
}
