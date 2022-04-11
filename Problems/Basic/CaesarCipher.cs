namespace HackerRank_Solutions.Problems.Basic
{
    public class CaesarCipher
    {
        public CaesarCipher()
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            string s = Console.ReadLine();

            int k = Convert.ToInt32(Console.ReadLine().Trim());

            caesarCipher(s, k);
        }

        private string caesarCipher(string s, int k)
        {
            List<string> alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(' ').ToList();
            string encrStr = "";
            int idx, encrIdx;

            for(int i = 0; i<s.Length; i++)
            {
                if (!alphabet.Contains(s[i].ToString().ToLower()))
                    encrStr += s[i];
                else
                {
                    idx = alphabet.IndexOf(s[i].ToString().ToLower());
                    encrIdx = (idx + k) % alphabet.Count;

                    if(Char.IsUpper(s[i]))
                        encrStr += alphabet[encrIdx].ToUpper();
                    else
                        encrStr += alphabet[encrIdx];

                }
            }

            return encrStr;
        }

    }
}
