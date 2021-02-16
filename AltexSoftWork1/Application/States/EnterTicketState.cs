using AltexSoftWork1.Helper;
using AltexSoftWork1.Model;
using AltexSoftWork1.Application.Base;
using System;

namespace AltexSoftWork1.Application.States
{
    public class EnterTicketState : StateBase
    {
        private string _ticketNumberText;
        private TicketModel ticket;
        public override void Enter()
        {
            Console.WriteLine($"Enter a ticket number from {TicketModel.COUNT_MIN} to {TicketModel.COUNT_MAX} length:");
        }

        public override void Exit()
        {
           Console.Clear();
        }

        public override void UpdateState()

        {
            _ticketNumberText = NumberReader.ReadNumberFromComsole();
 
            ticket = new TicketModel(_ticketNumberText);
            base._stateMachine.ChangeState(new CalculationState(ticket));
        }
    }
}
