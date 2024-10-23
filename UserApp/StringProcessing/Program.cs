namespace StringProcessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringWrapper str = new StringWrapper("anianiani");
            Console.WriteLine(str.Length);
            Console.WriteLine(str.MyIndexOf("i"));
            //string strrr = "vefxistyaosani";
            //Console.WriteLine(strrr.Substring(strrr.Length - 4));
            Console.WriteLine(str.MyLastIndexOf("i"));
            Console.WriteLine(str.MyToUpper());
            StringWrapper str2 = new StringWrapper("VEFXISTYAOSANI");
            Console.WriteLine(str2.MyToLower());
            string s1 = "bayayi wyalshi yiyinebs";
            string[] arr = s1.MySplit();
            Console.WriteLine(arr.Length);
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
            string shtring = StringExtensions.MyJoin(arr, "/");
            Console.WriteLine(shtring);
            Console.WriteLine(s1.MyContains(""));
            Console.WriteLine("iwyeva tu ara: " + s1.MyStartsWith("bay"));
        }
    }
}
