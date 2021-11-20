// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int [] CreateArray(int arg, int arg1, int arg2)
//     {
//         int [] array = new int [arg];
//         for( int i = 0; i <array.Length; i++) array[i] = new Random().Next(arg1,arg2);
//         return array;
//     }

// int[] RandomArray = CreateArray(12, -1000, 1000);
// Console.WriteLine(String.Join(',',RandomArray));

// int Find(int[] mass)
// {
//     int sum=0;
//     for( int j = 0; j < mass.Length; j++) 
//         if (mass[j] > 9 && mass[j] < 99) sum +=1;
//     return sum;
// }

// Console.WriteLine(Find(RandomArray));