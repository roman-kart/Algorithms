using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchInGraph
{
    public static class Extension
    {
        public static void ShowAllElements(this NetworkElement networkElement)
        {
            ShowElements(networkElement, "");
        }
        private static void ShowElements(NetworkElement networkElement, string spaces)
        {
            if (networkElement.NetworkElements == null)
            {
                Console.WriteLine($"{spaces}{networkElement.IPAddress}");
            }
            else
            {
                Console.WriteLine($"{spaces}{networkElement.IPAddress} : ");
                for (int i = 0; i < networkElement.NetworkElements.Count; i++)
                {
                    ShowElements(networkElement.NetworkElements[i], spaces + '\t');
                }
            }
        }
    }
}
