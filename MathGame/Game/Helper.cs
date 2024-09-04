using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Game
{
    internal class Helper
    {
        public static List<string> history = new List<string>();
        public static void AddToHistory(string message)
        {
            history.Add(message);
        }
    }
}
