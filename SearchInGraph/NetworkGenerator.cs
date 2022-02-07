using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInGraph
{
    public class NetworkGenerator
    {
        private static Random _rand = new Random();
        private static NetworkElement _testNetworkElement = new NetworkElement("123.97.123.12", null);
        private static string _getIpAddress
        {
            get
            {
                return $"{_rand.Next(0, 255)}.{_rand.Next(0, 255)}.{_rand.Next(0, 255)}.{_rand.Next(0, 255)}";
            }
        }
        public static NetworkElement GetNetwork(int countOfLayers = 3, int CountOfElementsInEdge = 5)
        {
            var networkRootElement = new NetworkElement(_getIpAddress, null);
            networkRootElement.NetworkElements = GetNetworkForElement(countOfLayers, CountOfElementsInEdge, networkRootElement);
            _testNetworkElement.ParentNetwork = networkRootElement.NetworkElements[1].NetworkElements[2];
            networkRootElement.NetworkElements[1].NetworkElements[2].NetworkElements.Add(_testNetworkElement);
            return networkRootElement;
        }
        private static List<NetworkElement> GetNetworkForElement(int currentLayer, int CountOfElementsInEdge, NetworkElement parentElement)
        {
            if (currentLayer <= 1)
            {
                List<NetworkElement> networks = new List<NetworkElement>();
                for (int i = 0; i < CountOfElementsInEdge; i++)
                {
                    networks.Add(new NetworkElement($"{_getIpAddress}", parentElement));
                }
                return networks;
            }
            else
            {
                List<NetworkElement> networks = new List<NetworkElement>();
                for (int i = 0; i < CountOfElementsInEdge; i++)
                {
                    var newNetwork = new NetworkElement(_getIpAddress, parentElement);
                    newNetwork.NetworkElements = GetNetworkForElement(currentLayer - 1, CountOfElementsInEdge, newNetwork);
                    networks.Add(newNetwork);
                }
                return networks;
            }
        }
    }
}
