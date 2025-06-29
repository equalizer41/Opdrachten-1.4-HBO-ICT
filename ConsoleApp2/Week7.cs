
class Program
{
    static void Main()
    {
        Console.WriteLine(KloppenHaakjes("[((3+2))]"));      // waar
        Console.WriteLine(IsPalindroom("lepel"));            // waar
        Console.WriteLine(BerekenRPN("3 2 5 * +"));           // 13
    }


    public static bool KloppenHaakjes(string tekst)
    {
        Stack<char> stapel = new Stack<char>();

        foreach (char teken in tekst)
        {
            if (teken == '(' || teken == '[' || teken == '{')
            {
                stapel.Push(teken);
            }
            else if (teken == ')' || teken == ']' || teken == '}')
            {
                if (stapel.Count == 0) return false;

                char laatste = stapel.Pop();

                if ((teken == ')' && laatste != '(') ||
                    (teken == ']' && laatste != '[') ||
                    (teken == '}' && laatste != '{'))
                {
                    return false; 
                }
            }
        }

        return stapel.Count == 0; 
    }


    public static bool IsPalindroom(string woord)
    {
        Stack<char> stapel = new Stack<char>();
        Queue<char> rij = new Queue<char>();

        foreach (char letter in woord.ToLower())
        {
            if (char.IsLetter(letter))
            {
                stapel.Push(letter);
                rij.Enqueue(letter);
            }
        }

        while (stapel.Count > 0)
        {
            char vanStapel = stapel.Pop();
            char vanRij = rij.Dequeue();

            if (vanStapel != vanRij)
            {
                return false;
            }
        }

        return true;
    }


    public static int BerekenRPN(string invoer)
    {
        Stack<int> stapel = new Stack<int>();
        string[] delen = invoer.Split(' ');

        foreach (string deel in delen)
        {
            if (int.TryParse(deel, out int getal))
            {
                stapel.Push(getal); 
            }
            else
            {
                int b = stapel.Pop(); 
                int a = stapel.Pop(); 

                if (deel == "+") stapel.Push(a + b);
                else if (deel == "-") stapel.Push(a - b);
                else if (deel == "*") stapel.Push(a * b);
                else if (deel == "/") stapel.Push(a / b);
            }
        }

        return stapel.Pop(); 
    }

}
