// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

// double[] CreateArray(int arg)
// {
//     double[] array = new double[arg];
//     for (int i = 0; i < arg; i++) array[i] = new Random().NextDouble();
//     return array;
// }

// double[] RandomArray = CreateArray(11);
// Console.WriteLine(String.Join(',', RandomArray));

// double Difference(double[] mass)
// {
//     double max = mass[0];
//     double min = mass[0];
//     for (int j = 0; j < mass.Length; j++)
//     {
//         if (mass[j] > max) max = mass[j];
//         else min = mass[j];
//     }
//     return max - min;
// }

// Console.WriteLine(String.Join(',', Difference(RandomArray)));