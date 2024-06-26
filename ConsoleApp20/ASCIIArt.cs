using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal static class ASCIIArt
    {
        public static void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" $$$$$$\\   $$$$$$\\  $$\\      $$\\ $$$$$$$$\\        $$$$$$\\  $$\\    $$\\ $$$$$$$$\\ $$$$$$$\\  ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("$$  __$$\\ $$  __$$\\ $$$\\    $$$ |$$  _____|      $$  __$$\\ $$ |   $$ |$$  _____|$$  __$$\\ ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("$$ /  \\__|$$ /  $$ |$$$$\\  $$$$ |$$ |            $$ /  $$ |$$ |   $$ |$$ |      $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("$$ |$$$$\\ $$$$$$$$ |$$\\$$\\$$ $$ |$$$$$\\          $$ |  $$ |\\$$\\  $$  |$$$$$\\    $$$$$$$  |");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("$$ |\\_$$ |$$  __$$ |$$ \\$$$  $$ |$$  __|         $$ |  $$ | \\$$\\$$  / $$  __|   $$  __$$< ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("$$ |  $$ |$$ |  $$ |$$ |\\$  /$$ |$$ |            $$ |  $$ |  \\$$$  /  $$ |      $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\\$$$$$$  |$$ |  $$ |$$ | \\_/ $$ |$$$$$$$$\\        $$$$$$  |   \\$  /   $$$$$$$$\\ $$ |  $$ |");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" \\______/ \\__|  \\__|\\__|     \\__|\\________|       \\______/     \\_/    \\________|\\__|  \\__|");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
