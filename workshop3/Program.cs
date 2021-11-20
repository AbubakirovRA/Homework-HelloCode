// 34. Написать программу замену элементов массива на противоположные

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


// int [] CreateArray(int arg, int arg1, int arg2)
//     {
//         int [] array = new int [arg];
//         for( int i = 0; i <array.Length; i++) array[i] = new Random().Next(arg1,arg2);
//         PrintIntArray(array);
//         return array;
//     }


// int[] Change(int[] arg)
// {
//     int[] mas = new int [arg.Length]; 
//     for( int i = 0; i <arg.Length; i++) mas[i] = arg[i] * -1;
//     return mas;
// }
// PrintIntArray(Change(CreateArray(10, -10, 10)))