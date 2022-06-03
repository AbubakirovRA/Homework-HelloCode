
// 66. Показать натуральные числа от 1 до N, N задано (рекурсивной функцией)

int Foo(int n){  // второе решение 
  if (n == 0) return 1; 
  Console.Write("{0,4}", Foo(n - 1)); 
  return n + 1; 
}

Foo(10); System.Console.WriteLine();



