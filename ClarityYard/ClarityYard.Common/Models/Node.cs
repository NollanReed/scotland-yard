using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityYard.Common.Models
{
    public class Node : BaseModel
    {
        public List<Connection> Connections { get; set; }


    }
}
