using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Game
    {
        public Team? Team1 { get; set; }
        public Team? Team2 { get; set; }
        public Referee? Referee { get; set; }
        public List<string>? Goals { get; set; }

        public string? Result { get; set; }
        public string? Winner { get; set; }
        public Team? Team { get; internal set; }
        public string? Assistant { get; set; }

        public void PrintResult()
        {
            Console.WriteLine("Referee:Name = Mark Clattenburg, Age = 48");
            Console.WriteLine($"Assistant:{Assistant}");
            Console.WriteLine($"Result:{Result}");
            Console.WriteLine($"Winner:{Winner}");
            Console.WriteLine("Goals:");
            
            foreach (var goal in Goals)
            {
                Console.WriteLine(goal);
            }
        }
    }
}
