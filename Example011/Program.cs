void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index<Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int possition = 0;
    while (possition < count)
    {
        Console.WriteLine(col[possition]);
        possition++;
    }
}
int[] array = new int[10];
int indexof(int[] collection, int find)
{
  int count = collection.Length;
  int index = 0;
  int possition = -1;
  while (index<count)
  {
    if (collection[index] == find)
    {
        possition = index;
        break;
    }
    index++;
  }
  return possition;  
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = indexof(array, 4);
Console.WriteLine(pos);