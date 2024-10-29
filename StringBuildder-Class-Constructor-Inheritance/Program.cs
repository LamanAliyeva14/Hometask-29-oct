namespace StringBuildder_Class_Constructor_Inheritance;
class Program
{
    static void Main(string[] args)
    {
       
        Gadgets g1 = new Gadgets();
        g1.Name = "Phone";
        g1.Weight = 200;
        g1.Memory = 256;
        g1.SerialNumber = "13a9r482hy3";


        Gadgets g2 = new Gadgets();
        g2.Name = "Laptop";
        g2.Weight = 800;
        g2.Memory = 512;
        g2.SerialNumber = "112a2d3asa23b9";

        Gadgets g3 = new Gadgets();
        g3.Name = "Tablet";
        g3.Weight = 600;
        g3.Memory = 128;
        g3.SerialNumber = "1dq3c9s2";


        Account a1 = new Account("lorem123", "123456*");
        string username = "lorem123";
        string password="123456*";
        a1.CheckInfo(username, password);


        string sentence = "Hello honey";
        string reversedsentence = ReverseWords(sentence);
        Console.WriteLine(reversedsentence);
       
    }


    public static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            char[] charArray = words[i].ToCharArray();
            Array.Reverse(charArray);
            words[i] = new string(charArray);
        }
        return string.Join(" ", words);
    }





}
class Gadgets
{
    public string Name;
    public int Weight;
    public int Memory;
    public string SerialNumber;


    public Gadgets()
    {
    }

    public Gadgets(string name)
    {
        Name = name;
    }

    public Gadgets(string name, int weight):this(name)
    { 
        Weight = weight;
    }

    public Gadgets(string name, int weight, int memory):this(name, weight)
    {
        Memory = memory;
    }

    public Gadgets(string name, int weight, int memory, string serialnumber):this(name, weight, memory)
    {
        SerialNumber = serialnumber;
    }
}

class Account
{
    public string Username { get; private set; }
    public string Password { get; private set;}

    public Account()
    {

    }
   
    public Account(string username, string password)
    {
        Username = username;
        Password = password;
            
    }

    public void CheckInfo(string username, string password)
    {
        if ( Username==username && Password==password)
        {
            Console.WriteLine("Entered succesfully");
        }
        else
        {
            Console.WriteLine("Password or login is wrong");
        }
    }


   
    
}
