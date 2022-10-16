int[] array = { 76, 89, 75, 83, 5, 65, 82, 23, 5 };

int n = array.Length;
int find = 5;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index +1;
    index++;
};