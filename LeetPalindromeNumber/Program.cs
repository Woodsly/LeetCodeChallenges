string roman = Console.ReadLine();
Console.WriteLine(RomanToInt(roman));
int RomanToInt(string s)
{
    List<int> numbers = new List<int>();
    foreach (char c in s)
    {
        if (c == 'I')
        {
            numbers.Add(1);
        }
        else if (c == 'V')
        {
            numbers.Add(5);
        }
        else if (c == 'X')
        {
            numbers.Add(10);
        }
        else if (c == 'L')
        {
            numbers.Add(50);
        }
        else if (c == 'C')
        {
            numbers.Add(100);
        }
        else if (c == 'D')
        {
            numbers.Add(500);
        }
        else if (c == 'M')
        {
            numbers.Add(1000);
        }
    }
    int sum = 0;
    for (int i = 0; i < numbers.Count; i++)
    {
        if (i != numbers.Count - 1)
        {
            if (numbers[i] < numbers[i + 1])
            {
                sum += (numbers[i + 1] - numbers[i]);
                numbers.RemoveAt(i + 1);
            }
            else
            {
                sum += numbers[i];
            }
        }
        else
        {
            sum += numbers[i];
        }
    }
    return sum;
}