//3
        string s1 = "это тест", s2;
        
        s2 = s1.Insert(4, "простой ");

        Console.WriteLine( s2);

        Console.WriteLine();  
//4

        string m1 = "это простой тест", m2;
        Console.WriteLine(m1);
        m2 = m1.Insert(4, "не");
        Console.WriteLine(s2);
        m2 = m2.Replace("не", "но");
        m2 = m2.Replace("те", "то");
        Console.WriteLine(m2);
        Console.WriteLine();

//5

string n = "Один на суше другой на море";
string[] words = n.Split(' ');

foreach (string word in words)
{
    if (word == "суше")
    {
        Console.WriteLine();
    }
    Console.WriteLine(word + "!");
}
Console.WriteLine();


