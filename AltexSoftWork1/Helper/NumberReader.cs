using System;

namespace AltexSoftWork1.Helper
{
    public static class NumberReader
    {
        public static string ReadNumberFromComsole() => TryParseInt(Console.ReadLine());

        private static string TryParseInt(string text) {
            bool check = int.TryParse(text, out _);

            if (!check)
                throw new Exception($"Value '{text}' is not number!");

            return text;

        }
    }
}
