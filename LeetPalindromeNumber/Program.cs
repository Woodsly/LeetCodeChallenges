string[] inputWords = { "flower", "flow", "flight" };

Console.WriteLine(longestCommonPrefix(inputWords));

string longestCommonPrefix(string[] strs)
{
    if (strs.Length == 0)
    {
        return "";
    }
    string prefix = strs[0];
    for (int i = 1; i < strs.Length; i++)
    {
        while (strs[i].IndexOf(prefix) != 0)
        {
            prefix = prefix.Substring(0, prefix.Length - 1);
        }
    }
    return prefix;
}