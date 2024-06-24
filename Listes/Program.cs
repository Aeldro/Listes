namespace Listes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("aaa");
            list.Add("bbb");
            list.Add("ccc");
            list.RemoveAt(0);
            list.Remove("ccc");
            list[0] = "ddd";
            Console.WriteLine(list[0]);
        }
    }
}
