int[] array = {1, 2, 3, 456, 16, 74, 456};

int n = array.Length;
int find = 456;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    
    index++;
}