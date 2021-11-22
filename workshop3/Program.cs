// 47. Написать программу копирования массива
int [] CreateArray(int arg, int arg1, int arg2)
    {
        int [] array = new int [arg];
        for( int i = 0; i < array.Length; i++) array[i] = new Random().Next(arg1,arg2);
        //Console.WriteLine(String.Join(',', array(10, -10, 10)));
        return array;
    }


int[] CopyArray(int[] arg)
{
    int[] mas = new int [arg.Length]; 
    for( int i = 0; i <arg.Length; i++) mas[i] = arg[i];
    return mas;
}

Console.WriteLine(String.Join(',',CopyArray(CreateArray(10, -10, 10))));