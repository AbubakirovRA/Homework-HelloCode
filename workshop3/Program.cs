// 21. Программа проверяет пятизначное число на палиндромом.
// bool Palindrom(int arg)
// {
//     bool result = false;
//     int i = 0;
//     int j = 5;
//     int[] mass = { 0, 0, 0, 0, 0 };
//     for (i = 4; i >= 0; i--)
//     {
//         if (arg < 10) mass[i] = arg;
//         else mass[i] = arg % 10;
//         arg = arg / 10;
//     }

//     for (i = 0; i <= 2; i++)
//     {
//         j = j - 1;
//         if (mass[i] != mass[j])
//         {
//             result = false;
//             i = 2;
//             break;
//         }
//         else result = true;
//     }
//     return result;
// }
// int num = 12361;
// if (Palindrom(num)) Console.WriteLine("Палиндром");
// else Console.WriteLine("Не палиндром");