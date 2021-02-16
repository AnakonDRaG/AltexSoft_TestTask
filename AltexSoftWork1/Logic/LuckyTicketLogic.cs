using AltexSoftWork1.Model;

namespace AltexSoftWork1.Logic
{
    public static class LuckyTicketLogic
    {
        public static bool CheckLuckyTicket(TicketModel ticket) {
            int[] numbers = ticket.Number;

            int sum = 0;
            for (int i = 0; i < numbers.Length/2; i++)
                sum += numbers[i] - numbers[(numbers.Length - 1) - i];


            return sum == 0;
        }
    }
}
