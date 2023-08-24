LengthOfLastWord("   fly me   to   the moon  ");

int LengthOfLastWord(string s)
{
    if (string.IsNullOrEmpty(s))
    {
        return 0;
    }
    int lastspace = 0;
    int length = 0;
    string sTrim = s.Trim();
    for (int i = 0; i < sTrim.Length; i++)
    {
        if (sTrim[i] == ' ')
        {
            lastspace = i;
        }
    }
    string word = sTrim.Substring(lastspace, sTrim.Length - lastspace);
    string strimmer = word.Trim();
    length = strimmer.Length;
    return length;
}