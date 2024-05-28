
int DecimalToBinary(int num, bool verbose)
{
    var binar = new Stack<int>();
    int outValue = 0;
    int rem = 0;
    while (num > 0)
    {
        rem = num % 2;
        num = num / 2;
        binar.Push(rem);
    }
    binar.Reverse();
    while (binar.Count() > 0)
    {
        if (verbose)
            Console.Write(binar.Peek());
        if (binar.Pop() == 1)
            outValue++;
    }
    if (verbose)
        Console.WriteLine("");
    return outValue;
}

Console.WriteLine(DecimalToBinary(42,true));