using System.Diagnostics;

int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i < n; i++)
    // Debug.WriteLineIf(i == 3, "The count is 0 and this may cause an exception.");
    Trace.WriteLineIf(i == 4, "The count is 0 and this may cause an exception.");

    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}