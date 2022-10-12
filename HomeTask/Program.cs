//  метод считывает с консоли число тип int положительное и >0
int ReadNamberInt()
{
    int a=0;
    bool parsNIsOk=false;
    while (!parsNIsOk)
    {
        
        parsNIsOk=int.TryParse(Console.ReadLine(), out int numberN);
        if ((!parsNIsOk)||(numberN<=0))
        {
            Console.WriteLine("Введено неверно, введите заново:");
            parsNIsOk=false;
        }
        else a=numberN;
    }
    return a;
}

// метод выделяет из массива заданную длину строк 

void ArrangeArray(string[] array)
{
    int n=array.Length;
    int strLength=0;
    for(int j=0; j<n; j++)
    {
      strLength=array[j].Length;
      if (strLength<=3)
        {
            Console.WriteLine(array[j]);
        }
    }


}

int n=0;
Console.Clear();
Console.Write("Введите размерность массива :");
 n=ReadNamberInt();
string[] array=new string[n];
for(int j=0; j<n; j++)
    {
        Console.Write($"Введите {j} элемент массива :");
        array[j]=Console.ReadLine();
        // Console.Write($" {j} = [{ array[j] }] ");
    }
    ArrangeArray(array);