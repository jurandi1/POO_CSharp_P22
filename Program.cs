namespace POO_CSharp_P22
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Demo 2 - HashSet<T> e SortedSet<T>");

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            Console.WriteLine("union");
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            Console.WriteLine("intersection");
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //difference
            Console.WriteLine("difference");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

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

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}
