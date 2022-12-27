string[] arrayinitial;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
arrayinitial = stroka.Split(' ');
string[] arrayfinal = new string[arrayinitial.Length];
void SecondArrayWithIF(string[] arrayinitial, string[] arrayfinal)
{
    int count = 0;
    for (int i = 0; i < arrayinitial.Length; i++)
    {
    if(arrayinitial[i].Length <= 3)
        {
        arrayfinal[count] = arrayinitial[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayinitial, arrayfinal);
PrintArray(arrayfinal);