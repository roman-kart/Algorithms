using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInGraph
{
    public class AnalizeNetwork
    {
        /// <summary>
        /// Возвращает null, если элемента нет в сети
        /// </summary>
        /// <param name="rootNetworkElement"></param>
        /// <param name="searchedIPAddress"></param>
        /// <returns></returns>
        public static NetworkElement GetNetworkElementByAddress(NetworkElement rootNetworkElement, string searchedIPAddress)
        {
            // если элемент для поиска является корневым элементом
            if (rootNetworkElement.IPAddress == searchedIPAddress)
            {
                return rootNetworkElement;
            }

            Queue<NetworkElement> networksQueue = new Queue<NetworkElement>(); // очередь для поиска элементов сети
            Dictionary<string, string> alreadyCheckedIP = new Dictionary<string, string>();
            

            foreach (var element in rootNetworkElement.NetworkElements)
            {
                networksQueue.Enqueue(element);
            }

            while (networksQueue.Count >= 1)
            {
                var currentElement = networksQueue.Dequeue();
                if (currentElement.IPAddress == searchedIPAddress)
                {
                    return currentElement;
                }
                else if (currentElement.NetworkElements != null)
                {
                    foreach (var element in currentElement.NetworkElements)
                    {
                        if (alreadyCheckedIP.ContainsValue(element.IPAddress))
                        {
                            continue;
                        }
                        alreadyCheckedIP.Add(element.IPAddress, element.IPAddress);
                        networksQueue.Enqueue(element);
                    }
                }
            }
            return null;
        }

        //public string pathToElement(NetworkElement endpointElement, NetworkElement startPoint)
        //{
        //    var currentElement = endpointElement;
        //    string path = "";
        //    while (currentElement.ParentNetwork != null)
        //    {
        //        path += currentElement.IPAddress + "/";
        //        currentElement = currentElement.ParentNetwork;
        //    }
        //}
    }
}
