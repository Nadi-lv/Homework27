int[] FillArray(int N)
{   int [] array = new int[N];
    int len = array.Length;
    for (int i = 0; i < len; i++){
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
void PrintArray(int[] array)
{
    int len = array.Length;
    System.Console.Write("[");
    for (int i = 0; i<len; i++){
      if (i ==len - 1) 
       
        System.Console.Write($"{array[i]}]");
     else System.Console.Write($"{array[i]},");   
     }
}

System.Console.WriteLine("Zadacha28");
System.Console.WriteLine("Введите размерность массива");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);
System.Console.WriteLine("Ваш массив");
PrintArray(arr);
