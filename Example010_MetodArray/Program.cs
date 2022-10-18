int[] array = {12,23,30,94,84,75,46,37,84};

int n = array.Length;
int find = 84;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}