/// 35. Определить, присутствует ли в заданном массиве, некоторое число 

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


// int[] CreateArray(int arg, int arg1, int arg2)
// {
//     int[] array = new int[arg];
//     for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(arg1, arg2);
//     PrintIntArray(array);
//     return array;
// }

// bool FindNumber(int num, int[] array)
// {
//     int j = 0;
//     while (j < array.Length-1)
//     {
//         if (array[j] == num) break;
//         j += 1;
//     }
//     return num == array[j];
// }
// int n = 44;
// Console.WriteLine(FindNumber(n, CreateArray(10, 1, 50)));