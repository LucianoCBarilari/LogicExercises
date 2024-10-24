

List<int> Lintegers = Enumerable.Range(2, 99).ToList();

foreach (int i in Lintegers) 
{
    var e = Math.Sqrt(i);
    List<int> LessFromI = Enumerable.Range(2, (int)e-1).ToList();

    bool[] IsBolean = new bool[LessFromI.Count()];
    int p = 0;
    foreach (int j in LessFromI)
    {
        var Result = (double) i / j;
        IsBolean[p] = Result % 1 == 0;
        p++;
    }
    if (IsBolean.Contains(true))    
        Console.WriteLine($"no es primo: {i}");    
    else     
        Console.WriteLine($"es primo: {i}");
}
