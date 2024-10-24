

bool IsAnAnagram(string FirstWord, string SecondWord) 
{
    bool Result = true;
    if (FirstWord.Length == SecondWord.Length && !FirstWord.Equals(SecondWord))
    {
        var ListOfFirstWordChar = FirstWord.ToCharArray();
        var ListOfSecondWordChar = SecondWord.ToCharArray();

        foreach (var item in ListOfFirstWordChar)
        {
            if (!ListOfSecondWordChar.Contains(item)) 
            {
                Result = false;
                break;
            }   
        }
        
    }
    else 
    {
        Console.WriteLine("The words have a different size. They should be the same.");
        Result= false;
    }
    return Result;
}
Console.WriteLine(IsAnAnagram("jura", "raju"));