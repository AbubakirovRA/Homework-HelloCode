// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int[] CreateArray(int arg, int arg1, int arg2)
// {
//     int[] array = new int[arg];
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(arg1, arg2);
//     return array;
// }

// int[] RandomArray = CreateArray(12, 1, 10);
// Console.WriteLine(String.Join(',', RandomArray));

// int SummOddPosition(int[] mass)
// {
//     int sum = 0;
//     for (int j = 0; j < mass.Length; j++) if (j % 2 != 0) sum += mass[j]; 
//     return sum;
// }

// Console.WriteLine(SummOddPosition(RandomArray));