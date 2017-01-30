using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityYard.Common.Models
{
    public class Connection : BaseModel
    {
        public bool Train { get; set; }

        public bool Bus { get; set; }

        public bool Taxi { get; set; }

        public bool River { get; set; }
    }
}
