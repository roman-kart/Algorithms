using TheBackpackProblem;

var items = new Item[]
{
    new Item {Name = "Chocolate", Weight = 2000, Cost = 3000},
    new Item{ Name = "Book", Weight = 300, Cost = 500},
    new Item{ Name = "Water", Weight = 1000, Cost = 30},
    new Item{ Name = "Whiskey", Weight = 500, Cost = 2500},
    new Item{ Name = "Cupcakes", Weight = 300, Cost = 200},
    new Item{ Name = "Vodka", Weight = 500, Cost = 1000},
    new Item{ Name = "Pea", Weight = 1000, Cost = 2000}
};

int backpackCapacity = 2000;
int step = 100;

Combination[,] combinations = new Combination[(backpackCapacity / step), items.Length];

// перебираем элементы
for (int i = 0; i < items.Length; i++)
{
    var currentItem = items[i];
    // перебираем "подрюкзаки"
    for (int currentCapacity = 100; currentCapacity <= backpackCapacity; currentCapacity += step)
    {
        var backpackIndex = (currentCapacity / step) - 1; // идекс текущего "подрюкзака" в массиве комбинаций
        // если элемент не помещается в рюкзак
        if (currentItem.Weight > currentCapacity)
        {
            var bestCombination = new Combination { TotalWeight = 0, TotalCost = 0, Items = new List<Item>() };
            // выбираем прошлую комбинацию
            if (i - 1 >= 0)
            {
                bestCombination = combinations[backpackIndex, i - 1];
            }
            combinations[backpackIndex, i] = bestCombination;
        }
        // если помещается
        else
        {
            int currentCost = currentItem.Cost;
            int currentWeight = currentItem.Weight; // текущий вес
            int currentRemains = currentCapacity - currentWeight; // текущий остаток
            int currentBackpackIndex = (currentRemains / step) - 1; // текущий индекс подрюкзака в массиве комбинаций
            var bestRemainsCombination = new Combination { TotalWeight = 0, TotalCost = 0, Items = new List<Item>() }; // лучшая комбинация для остатка
            if (i - 1 >= 0 && currentBackpackIndex > 0)
            {
                bestRemainsCombination = combinations[currentBackpackIndex, i - 1 >= 0 ? i - 1 : 0].GetCopy(); // лучшей комбинацией является последняя возможная комбинация из списка
            }
            bestRemainsCombination.Items.Add(currentItem);
            bestRemainsCombination.Items.DistinctBy(i => i.Name); // удаляем дубликаты
            var newCombination = new Combination
            {
                TotalWeight = currentWeight + bestRemainsCombination.TotalWeight,
                TotalCost = currentCost + bestRemainsCombination.TotalCost,
                Items = bestRemainsCombination.Items
            };
            // если новая комбинация стоит дешевле прошлой комбинации для данного веса, то оставляем прошлую комбинацию 
            if (i - 1 > 0 && combinations[backpackIndex, i - 1].TotalCost > newCombination.TotalCost)
            {
                // добавляем комбинацию в список комбинаций
                combinations[backpackIndex, i] = combinations[backpackIndex, i - 1];
            }
            else
            {
                // добавляем комбинацию в список комбинаций
                combinations[backpackIndex, i] = newCombination;
            }
        }
    }
}


string header = "";
for (int i = 100; i <= backpackCapacity; i+=step)
{
    header += $"{i}\t";
}
Console.WriteLine(header);

for (int i = 0; i < combinations.GetLength(1); i++)
{
    string row = "";
    for (int j = 0; j < combinations.GetLength(0); j++)
    {
        row += combinations[j, i].TotalCost + "\t";
    }
    Console.WriteLine(row);
}

Console.WriteLine(combinations[combinations.GetLength(0) - 1, combinations.GetLength(1) - 1].TotalWeight);
foreach (var item in combinations[combinations.GetLength(0) - 1, combinations.GetLength(1) - 1].Items)
{
    Console.WriteLine($"{item.Name}: Weight: {item.Weight}, Cost: {item.Cost}");
}