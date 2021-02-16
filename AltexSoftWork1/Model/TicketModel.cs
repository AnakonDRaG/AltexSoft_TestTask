using System;

namespace AltexSoftWork1.Model
{
   public class TicketModel
    {
        public static int COUNT_MIN = 4;
        public static int COUNT_MAX = 8;

        private int[] _number;

        public int[] Number
        {
            get => _number;
            private set {
                _number = value;
            }
        }

        public TicketModel(string ticketNumberText) => ParseTicket(ticketNumberText);

        private void ParseTicket(string numberText) {
            char[] numberArray = numberText.ToCharArray();
            int letArra = numberArray.Length;

            if (letArra < COUNT_MIN)
                throw new Exception($"Number less than {COUNT_MIN}!");

            if (letArra > COUNT_MAX)
                throw new Exception($"Number more than {COUNT_MAX}!");

            int evenCheck = letArra % 2;

            _number = new int[letArra + evenCheck];

            for (int i = 0; i < _number.Length - evenCheck; i++)
                _number[i + evenCheck] = int.Parse(numberArray[i].ToString());
            
        }

        public override string ToString()
        {
            var r = "";
            foreach (var num in _number)
                r += num.ToString();
            return r;
        }
    }
}
