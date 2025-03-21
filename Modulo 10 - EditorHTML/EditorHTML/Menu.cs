using System;
using System.Drawing;

namespace EditorHTML
{
    class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");


            for (int line = 0; line <= 10; line++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(" ");
                }

                Console.Write("|");
                Console.Write("\n");

            }

            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");
        }
    }
}