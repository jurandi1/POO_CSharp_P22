namespace POO_CSharp_P22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            Console.WriteLine("Demo 1 - HashSet<T> e SortedSet<T>");
            HashSet<string> set = new HashSet<string>();
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");
            Console.WriteLine(set.Contains("Notebook"));

            foreach (String p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
