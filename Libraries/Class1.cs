namespace Libraries;
public static class ExtensionsForArray
{
    public static void InsertRandomInt(this int[] sourceArr, int min = -1000, int max = 1000)
    {
        Random rnd = new Random();
        for (int i = 0; i < sourceArr.Length; i++)
        {
            sourceArr[i] = rnd.Next(min, max);
        }
    }
    public static type[] GetCopy<type>(this type[] sourceArr)
    {
        var copyArr = new type[sourceArr.Length];
        Array.Copy(sourceArr, copyArr, sourceArr.Length);
        return copyArr;
    }
    public static void PrintItems<type>(this type[] sourceArr)
    {
        foreach (var item in sourceArr)
        {
            Console.Write($"{item?.ToString()} ");
        }
    }
    public static void InsertSequence(this int[] sourceArr)
    {
        for (int i = 0;i < sourceArr.Length; i++)
        {
            sourceArr[i] = i;
        }
    }
}