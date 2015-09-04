namespace LearnLINQ.Generics
{

    class GenericDelegates
    {
        public delegate T Add<T>(T param1, T param2);

        public static int Addnumber(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concate(string val1, string val2)
        {
            return val1 + val2;
        }
    }
}
