// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int x = 5;

if (x > 5)
{
    Console.WriteLine("Yes");
}else{
    Console.WriteLine("NO");
}

int [] arr = {1,2,3,3};

static double average(int[] arr)
{
    int sum = 0;
    foreach (var i in arr)
    {
        sum += i;
    }

    return sum / arr.Length;
}

static int maxVal(int[] arr)
{
    int max = arr[0];
    foreach (var i in arr)
    {
        if (max < i)
        {
            max = i;
        }
    }

    return max;
}