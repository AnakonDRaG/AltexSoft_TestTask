using System;
using AltexSoftWork1.Application.Base;
using AltexSoftWork1.Model;
using AltexSoftWork1.Logic;

namespace AltexSoftWork1.Application.States
{
    public class CalculationState : StateBase
    {
        private TicketModel _ticket;

        public CalculationState(TicketModel ticket) => _ticket = ticket;
        public override void Enter()
        {
            Console.WriteLine($"Ticket № {_ticket}");
          
        }

        public override void Exit()
        {
           Console.Clear();  
        }

        public override void UpdateState()
        {
            bool isLucky = LuckyTicketLogic.CheckLuckyTicket(_ticket);

            Console.ForegroundColor = isLucky ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(isLucky? "Congratulations, this was lucky ticket!!!!!!" : "Sorry, this unlucky ticket :(");
            Console.ResetColor();
            Console.WriteLine("\nPress any button for check new ticket!");
            Console.ReadLine();
            _stateMachine.ChangeState(new EnterTicketState());

        }
    }
}
