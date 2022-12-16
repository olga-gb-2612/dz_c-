// ввод массива в строку + foreach

int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
foreach (int element in s)
   Console.WriteLine(element*2);
