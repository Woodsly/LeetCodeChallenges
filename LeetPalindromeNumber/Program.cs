Console.WriteLine("Enter a number...");
int input = int.Parse(Console.ReadLine());
Console.WriteLine(IsPalindrome(input));

bool IsPalindrome(int x)
{
    string xString = x.ToString();
    string reversedString = "";
    for (int i = xString.Length - 1; i >= 0; i--)
    {
        reversedString += xString[i];
    }
    if (reversedString.Contains("-"))
    {
        return false;
    }
    else
    {
        long reversedNumber = long.Parse(reversedString);
        if (reversedNumber == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
}