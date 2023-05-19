using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class Referee : Person
    {
        public List<Referee>? Referees { get; set; }
        public List<Assistant> Assistants { get; set; } = new List<Assistant>();

       
    }
    }

