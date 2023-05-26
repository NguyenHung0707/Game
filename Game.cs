// See https://aka.ms/new-console-template for more information
class game
{
    protected string Name;
    protected int lever;
    protected int Score;

    public game(string name, int lever, int score)
    {
        Name = name;
        this.lever = lever;
        Score = score;
    }

    public void Infomation()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Enter Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter lever:  ");
        lever = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Score: ");
        Score = Convert.ToInt32(Console.ReadLine());
    }

    public game()
    {
    }

    public virtual String ToString()
    {
        return "Name is: " + Name + "\nLever is: " + lever + "\nScore is: " + Score;
    }
}

class Weapan  : game
{
    protected int Dame;

    public Weapan()
    {
    }

    public void InputDame()
    {
        Console.Write("Enter Dame: ");
        Dame = Convert.ToInt32(Console.ReadLine());
    }

    public override String ToString()
    {
        return "Name is: " + Name + "\nLever is: " + lever + "\nScore is: " + Score + "\nDame is: " + Dame;
    }
}

class Amor : game
{
    protected string HP;

    public Amor()
    {
    }

    public void InputAmor()
    {
        Console.WriteLine("Enter Amor: ");
        HP = Console.ReadLine();
    }
    public override String ToString()
    {
        return "Name is: " + Name + "\nLever is: " + lever + "\nScore is: " + Score + "\nHP is: " + HP;

    }
}

class Cosumable : game { 

    protected string ItemName;

    public Cosumable()
    {
    }

    public void InputCosnumable()
    {
        Console.WriteLine("Enter Cosumable: ");
        ItemName = Console.ReadLine();
    }
    public override string ToString()
    {
        return "Name is: " + Name + "\nLever is: " + lever + "\nScore is: " + Score + "\nItemName is: " + ItemName;
    }
}

class Test
{
    static void Main(string[] args)
    {
       Weapan w = new Weapan();
        w.Infomation();
        w.InputDame();
        Console.WriteLine(w.ToString());

        Amor amor = new Amor();
        amor.Infomation();
        amor.InputAmor();
        Console.WriteLine(amor.ToString());

        Cosumable cosumable = new Cosumable();
        cosumable.Infomation();
        cosumable.InputCosnumable();
        Console.WriteLine(cosumable.ToString());

    }
}

