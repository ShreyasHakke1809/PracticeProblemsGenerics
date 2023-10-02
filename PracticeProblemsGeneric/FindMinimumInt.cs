namespace PracticeProblemsGeneric
{
    internal class FindMinimumInt
    {
        public int MinOfThree(int a, int b, int c)
        {
            if (a.CompareTo(b) <= 0 && a.CompareTo(c) <= 0)
            {
                return a;
            }
            else if (b.CompareTo(a) <= 0 && b.CompareTo(c) <= 0)
            {
                return b;
            }
            else if (c.CompareTo(a) <= 0 && c.CompareTo(b) <= 0)
            {
                return c;
            }
            return default;
        }
    }
}
