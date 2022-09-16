Console.Clear();
Console.WriteLine("Первоночальный массив");
string[] array1 = new string[5]{"Hello","2","world","32","cat"};
string[] array2 = new string[array1.Length];
int count=0;
for (int i = 0; i < array1.Length; i++)
{
 Console.Write($"{array1[i]} ");
}
for (int i = 0; i < array2.Length; i++)
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        Console.Write($"[{array1[i]}] ");
        }
    