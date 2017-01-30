using ClarityYard.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarityYard.Common.Data
{
    public class Board
    {
        public Board()
        {
            List<Node> Nodes = new List<Node>();


            List<Connection> Connections = new List<Connection>();
            Connections.Add(new Connection
            {
                Id = 1,
                Taxi = true,
                Bus = true,
                Train = true,
                River = false,

            });
        }

    }
}
