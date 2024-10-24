
//Formula
//F(n) = F(n-1) + F(n-2)
List<long> Linteger = new() 
{
    0,
    1
};
for (int i = 0; i < 50; i++) 
{
    Linteger.Add(Linteger[(Linteger.Count() - 1)] + (Linteger[(Linteger.Count() - 2)]));
   
}
Linteger.ForEach(i => Console.Write($"{i}, "));
