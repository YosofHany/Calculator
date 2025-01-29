using System;
class Program
{
    
    static void Main()
    {
        Console.WriteLine("1+1\n    =2");
        string tex = "69";
        
            while (tex != "Esc" || tex != "end" || tex != "exit" || tex != "esc")
            {
            try /*           o_0                       */
            {
                tex = Console.ReadLine();

                string a = CutNumbers(tex);

               char  Operator = tex[a.Length];
                if (tex[(a.Length) - 1] == '-') { Operator = '-'; }
                
                string b = CutNumbers((a.Length) + 1, tex);
                int A = int.Parse(a); int B = int.Parse(b);
                if (Operator == '/' && B == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Don't divid by zero" + "\n"); continue;
                }
                switch (Operator)
                {
                    case '+':
                        Console.Write("    =" + (A + B) + "\n");
                        break;

                    case '-':
                        Console.WriteLine("    =" + (A - B) + "\n");
                        break;

                    case '*':
                        Console.WriteLine("    =" + (B * A) + "\n");
                        break;
                    case '×':
                        Console.WriteLine("    =" + (B * A) + "\n");
                        break;

                    case '/':
                        Console.WriteLine("    =" + ((double)A / (double)B) + "\n");
                        break;

                    case '÷':
                        Console.WriteLine("    =" + (A / B) + "\n");
                        break;
                }
           }
           catch {continue; } 
            
        }
        
    }
    public static bool Isin(char a, string b)
    {
        foreach (char n in b)
        {
            if (n == a) { return true; }
        }
        return false;
    }
   public static string CutNumbers(string ss)
    {
        char[] ar = ss.ToCharArray();
        string a = "";
        if (ss[0] != '-')
        {
            foreach (char h in ss)
            {

                if (Isin(h," 0123456789")){ a = a + h; }else{ return a;}

            }
        }
        else {
            for (int i = 1; i < (ss.Length)-1; i++){if (Isin(ss[i]," 0123456789")){a = a + ss[i];}else{ a = '-' + a; return a;}}
        }
        a = '-' + a;
        return a;
    } 
    public static string CutNumbers(int y , string ss)
    {
        int lenth = ss.Length;
        char b;
        string a = "";

        while (y <(lenth))
        {
            b = ss[y];

            a = a + b;
            y++;
        }
        return a;
    }
}