namespace Anonymous_and_Lambda
{
    internal class Program
    {
        public delegate int FilterDelegate(string s);
        static void Main(string[] args)
        {
            FilterDelegate filterDelegate;

            // anonymous method
            filterDelegate = delegate (string s)
            {
                int num = 0;
                foreach (char c in s)
                {
                    if (c >= 'a' && c <= 'z') num++;
                }
                return num;
            };
            int result1 = filterDelegate("tEST strING");  // 4

            // lamda expression
            filterDelegate = (str) =>
            {
                int num = 0;
                foreach (char c in str) if (Char.IsLower(c)) num++;
                return num;
            };
            int result2 = filterDelegate("tEST strING"); // 4


        }

    }

}