using SearchInGraph;

var networkRoot = NetworkGenerator.GetNetwork();

var elem = AnalizeNetwork.GetNetworkElementByAddress(networkRoot, "123.97.123.12");
if (elem != null)
{
    Console.WriteLine(AnalizeNetwork.GetPathToElement(elem, networkRoot));
}
else
{
    Console.WriteLine("Element's not found");
}

networkRoot.ShowAllElements();