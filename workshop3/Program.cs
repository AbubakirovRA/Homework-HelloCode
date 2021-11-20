// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int[] CreateArray(int arg, int arg1, int arg2)
// {
//     int[] array = new int[arg];
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(arg1, arg2);
//     return array;
// }

// int[] RandomArray = CreateArray(11, 1, 10);
// Console.WriteLine(String.Join(',', RandomArray));

// int[] SummOddPosition(int[] mass)
// {
//     int[] work = new int[mass.Length/2];
//     int len = mass.Length-1;
//     for (int j = 0; j < mass.Length/2; j++)
//         {
//         work[j] = mass[j] * mass[len];
//         len -=1;
//         }
//     return work;
// }

// Console.WriteLine(String.Join(',', SummOddPosition(RandomArray)));