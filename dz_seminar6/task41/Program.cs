// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.Write("Введите несколько чисел через пробел: ");
int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
foreach (int element in s)
  {
  if(element > 0)
   count++;
  }
   Console.WriteLine($"Введено {count} числа/ел больше 0.");
