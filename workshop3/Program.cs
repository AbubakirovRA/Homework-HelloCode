// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// void PrintIntArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write($"{col[position]} ");
//         position++;
//     }

//     Console.WriteLine();
// }

// (int arg1, int arg2) EvenNotEven(int arg)
// {
//     int[] array = new int[arg];
//     int sumEven = 0;
//     int sumNotEven = 0;
//     for (int i = 0; i < arg; i++)
//         {
//             array[i] = new Random().Next(99, 1000);
//             if (array[i] % 2 == 0) sumEven += 1;
//             else sumNotEven += 1;
//         }
//     PrintIntArray(array);
//     // Console.WriteLine(String.Join(',',RandomArray));

//     return (sumEven, sumNotEven);
// }

// var evenNotEven = EvenNotEven(10);
// Console.WriteLine($"Summ Even Numbers = {evenNotEven.Item1}, Summ not Even Numbers ={evenNotEven.Item2}");
