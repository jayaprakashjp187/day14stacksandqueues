namespace stacksandqueeues
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Stack<int> s = new Stack<int>();
            s.Push(70);
            s.Push(30);
            s.Push(56);
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }
        }
    }
}