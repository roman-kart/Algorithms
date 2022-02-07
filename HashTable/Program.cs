Dictionary<string, int> dict = new Dictionary<string, int>();
dict.Add("Apple", 10);
//dict.Add("Apple", 10);
//dict.Add("Apple", 213);

var queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(1);

queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(4);
queue.Enqueue(5);
queue.Enqueue(6);
queue.Enqueue(7);
queue.Enqueue(8);
queue.Enqueue(9);

while (queue.Count > 0)
{
    Console.WriteLine(queue.Dequeue());
}