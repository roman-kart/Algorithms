Console.WriteLine(global::Recursion.Factorial.Recursion(5));
global::Recursion.Field.PrintMinSquare(14, 21);
Console.WriteLine(global::Recursion.Sum.GetSum(new int[] { 1, 2, 3}));
Console.WriteLine(global::Recursion.CountOfElements.Get<int>(new int[] {1, 2, 3, 4, 5}));
Console.WriteLine(global::Recursion.BiggestInArray.Get(new int[] {1, 2, 3, 4, 5, 55}));

int[] items = new int[1000];
for (int i = 0; i < items.Length; i++)
{
    items[i] = i;
}
Console.WriteLine(global::Recursion.BinarySearchClass.Search(items, 256));