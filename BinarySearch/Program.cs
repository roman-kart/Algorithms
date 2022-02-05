// подготавливаем данные
int[] arr = new int[50000000];
arr.InsertSequence();
int searched = 43567825;

int leftIndex = 0;
int rightIndex = arr.Length - 1;
int currentCentre = 0;
while (leftIndex <= rightIndex)
{
    currentCentre = ((rightIndex - leftIndex) / 2) + leftIndex;
    // если значение больше искомого
    if (arr[currentCentre] > searched)
    {
        rightIndex = currentCentre - 1; // сдвигаем правую границу  на элемент, который идет до текущего центра
    }
    else if (arr[currentCentre] == searched)
    {
        break;
    }
    else
    {
        leftIndex = currentCentre + 1; // сдвигаем левую границу  на элемент, который идет после текущего центра
    }
}

if (arr[currentCentre] == searched)
{
    Console.WriteLine($"Index of {searched} = {currentCentre}");
}
else
{
    Console.WriteLine($"Such element ({searched}) doesn't exist!");
}