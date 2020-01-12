namespace HackerRank.Algorithms.Easy
{
    class XorStringsSolution
    {
        public string StringsXor(string s, string t)
        {
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i])
                    res += '0';
                else
                    res += '1';
            }

            return res;
        }
    }
}