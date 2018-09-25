using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_TwentyOne
{
        public class Player
        {
            public List<Class> Hand { get; set; }
            public int Balance { get; set; }
            public string Name { get; set; }
            public bool isActivelyPlaying { get; set; }
        }
    
}
