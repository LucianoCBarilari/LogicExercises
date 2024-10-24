List<int> LIntegere = Enumerable.Range(1,100).ToList();

foreach (int i in LIntegere) 
{
    double IsThreeMulti = (double)i / 3;
    double IsFiveMulti = (double)i / 5;

    if (IsThreeMulti != 0 && IsThreeMulti % 1 == 0 && IsFiveMulti % 1 == 0 &&IsFiveMulti != 0)
        Console.WriteLine($"FizzBuzz {i}");
    else 
    {
        if (IsThreeMulti != 0 && IsThreeMulti % 1 == 0)
        {
            Console.WriteLine($"Fizz {i}");
        }
        else if (IsThreeMulti != 0 && IsFiveMulti % 1 == 0)
            Console.WriteLine($"Buzz {i}");
    }       
}
