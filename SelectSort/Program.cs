// входные данные
int[] arr = new int[50];
int[] sortedArr = new int[arr.Length];
arr.InsertRandomInt();

int leftIndex = 0; // левая границы (включена)
int rightIndex = arr.Length; // правая граница (не включена)
int currentMin; // текущее минимальное
int currentMax; // текущее максимальное
int currentMinIndex = 0; // индекс текущего минимального
int currentMaxIndex = 0; // индекс текущего максимального
int tmp; // переменная для хранения временного значения
while (leftIndex < rightIndex)
{
    // присваиваем текущим значениям максимума и минимума элементы, которые находяться на правой и левой границах соответственно
    currentMax = arr[rightIndex - 1];
    currentMin = arr[leftIndex];
    // ищем минимальный и максимальный элементы в текущей области
    for (int j = leftIndex; j < rightIndex; j++)
    {
        // если нашли элемент, который больше текущего максимального
        if (arr[j] > currentMax)
        {
            currentMax = (int)arr[j]; // обновляем значение
            currentMaxIndex = j; // обновляем индекс
        }
        // если нашли элемент, который меньше текущего минимального
        if(arr[j] < currentMin)
        {
            currentMin = (int)arr[j]; // обновляем значение
            currentMinIndex = j; // обновляем индекс
        }
    }
    sortedArr[leftIndex] = currentMin;
    sortedArr[rightIndex - 1] = currentMax;
    leftIndex++;
    rightIndex--;
}

sortedArr.PrintItems();

Action[] actions = new Action[10];
for (int i = 0; i < 10; i++)
{
    actions[i] = () => { 
        global::System.Console.WriteLine(i);
    };
}
foreach (var action in actions)
{
    action();
}