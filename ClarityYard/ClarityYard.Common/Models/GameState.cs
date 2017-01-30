using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityYard.Common.Models
{
    public class GameState : BaseModel
    {
        public List<Node> Nodes { get; set; }

        public int TurnNumber { get; set; }

        public List<Detective> Detectives { get; set; }

        public MrX MrX { get; set; }

        public EndGame EndGame {get; set;}
    }
}
