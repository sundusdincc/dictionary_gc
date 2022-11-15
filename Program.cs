internal class Program
{
    private static void Main(string[] args)
    {
        //system.collections.generic namespace
        Dictionary<int, string> users = new Dictionary<int, string>();
        users.Add(10, "Ayşe Yılmaz");
        users.Add(13, "Ali Yılmaz");
        users.Add(15, "Buse Deniz");
        users.Add(16, "Eda Deniz");

        //Elemanlara erişim
        Console.WriteLine("-users dictionary-");
        Console.WriteLine(users[13]);
        foreach (var item in users)
            Console.WriteLine(item);

        //Count
        Console.WriteLine("\nusers count: " + users.Count);

        //Contains
        Console.WriteLine("\n15 key contains: " + users.ContainsKey(15));
        Console.WriteLine("Ali Yılmaz value contains: " + users.ContainsValue("Ali Yılmaz"));

        //Remove
        Console.WriteLine("\n-15.key Remove-");
        users.Remove(15);
        foreach (var item in users)
            Console.WriteLine(item);

        //Keys,Values
        Console.WriteLine("\n-Key,Value-");
        foreach (var item in users)
            Console.WriteLine("Key:{0} Value:{1}", item.Key, item.Value);

        Console.WriteLine("\n-Keys-");
        foreach (var item in users.Keys)
            Console.WriteLine(item);

        Console.WriteLine("\n-Values-");
        foreach (var item in users.Values)
            Console.WriteLine(item);

        Console.WriteLine("\n-Keys,Values-");
        for (int x = 0; x < users.Count; x++)
        {
            Console.WriteLine("{0} and {1}", users.Keys.ElementAt(x),
                                 users[users.Keys.ElementAt(x)]);
        }

        Console.WriteLine("\n-Key,Value-");
        foreach (KeyValuePair<int, string> ele1 in users)
        {
            Console.WriteLine("{0} and {1}",
                      ele1.Key, ele1.Value);
        }

        // Using Clear() method
        users.Clear();
        Console.WriteLine("\nTotal number of key/value " +
         "pairs present in users:{0}", users.Count);


    }
}