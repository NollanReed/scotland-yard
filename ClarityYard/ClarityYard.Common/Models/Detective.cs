using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityYard.Common.Models
{
    public class Detective : BaseModel
    {
        public int TrainTickets { get; set; }

        public int BusTickets { get; set; }

        public int TaxiTickets { get; set; }

        public Node CurrentNode { get; set; }

        public int CurrentNodeId { get; set; }
    }
}
