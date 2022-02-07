using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInGraph
{
    public class NetworkElement
    {
        public NetworkElement ParentNetwork { get; set; }
        public string IPAddress { get; set; }
        public List<NetworkElement> NetworkElements { get; set; }
        public NetworkElement(string ipAddress, NetworkElement parentNetwork)
        {
            this.IPAddress = ipAddress;
            ParentNetwork = parentNetwork;
        }
    }
}
