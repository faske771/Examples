int[] array = {1, 12, 13, 14, 1345, 42423, 3131, 41, 42423, 3123};
int n = array.Length;
int find = 42423;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index); 
        break;
    }
    index = index + 1;
}