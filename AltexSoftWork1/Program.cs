using System;
using AltexSoftWork1.Application;
using AltexSoftWork1.Application.States;

namespace AltexSoftWork1
{
    public class Program
    {
  
        public static void Main(string[] args)
        {
            ApplicationContext applicationContext = new ApplicationContext(new EnterTicketState());

            while (true) {
                try
                {
                    applicationContext.StateUpdate();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{e.Message}\nRepeat your action, please.\n");
                    Console.ResetColor();
                }
            }
        }

    }
}
