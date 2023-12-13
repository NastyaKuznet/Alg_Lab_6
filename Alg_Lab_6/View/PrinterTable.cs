using Alg_Lab_6.Model.FolderHashTable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab_6.View
{
    public class Printer
    {
        public void PrintCell(string str, int lenght, int startLeftCursorPosition, int startTopCursorPosition, ConsoleColor color)
        {
            Console.ForegroundColor= color;
            StringBuilder lineHor = new StringBuilder();
            StringBuilder certain = new StringBuilder();
            for(int i = 0; i < lenght + 4; i++)
            {
                lineHor.Append("-");
                
                if(i == 0 || i ==lenght + 3)
                    certain.Append("|");
                else
                    certain.Append(" ");
            }
            if (startLeftCursorPosition >=120) return;
            Console.SetCursorPosition(startLeftCursorPosition, startTopCursorPosition);
            Console.WriteLine(lineHor.ToString());
            Console.SetCursorPosition(startLeftCursorPosition, startTopCursorPosition + 1);
            Console.WriteLine(certain.ToString());
            Console.SetCursorPosition(startLeftCursorPosition , startTopCursorPosition + 2);
            Console.WriteLine(lineHor.ToString());
            Console.SetCursorPosition(startLeftCursorPosition + 2, Console.GetCursorPosition().Top - 2);
            Console.WriteLine(str);
            Console.SetCursorPosition(0, Console.GetCursorPosition().Top + 2);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
