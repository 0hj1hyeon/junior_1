using System.ComponentModel;

class n1a { 
    int a; int b; int c;

    public n1a(int a, int b, int c) {
        this.a = a; this.b = b; this.c = c;

    }
    public int Cal() {
        return Math.Abs((b * b) - (4 * a * c));
    }
}

class n1b {
    double x; double y;

    public n1b(double x, double y)
    {
        this.x = x; this.y = y;

    }

    public double Cal() {
       return Math.Log10(Math.Pow(x + y, 3));
    }
}

class n1c {
    double x1, x2, y1, y2;

    public n1c(double x1, double x2, double y1, double y2)
    {
        this.x1 = x1;
        this.x2 = x2;
        this.y1 = y1;
        this.y2 = y2;
    }   
    public double Cal()
    {
        return Math.Sqrt(Math.Pow (x1-x2,2)+ Math.Pow(y1 - y2, 2));
    }
}

class n2 {

    double 원금, 이율, 기간;

    public n2(double 원금, double 이율, double 기간)
    {
        this.원금 = 원금;
        this.이율 = 이율;
        this.기간 = 기간;
    }
    public double Cal()
    {
        return 원금 * Math.Pow(1 + 이율, 기간);

    }
}
class n3 {
    double r;
    public n3(double r) {
        this.r = r;
    }
    public double Cal() {
        return 4 * 3.14 * Math.Pow(r, 2);    
     }
}

class n4 {
    int y;
    public n4(int y) {
        this.y = y;

    }

    public void Cal() {
        if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
        {
            Console.WriteLine($"{y}년은 윤년");
        }
        else
        {
            Console.WriteLine($"{y}년은 평년");
        }
    }
}

class n5 {
    int[] n = new int[10];

    public n5() {
        for (int i = 0; i < n.Length; i++)
        {
            Console.WriteLine($"{i}번째 숫자 입력");
            n[i] = int.Parse(Console.ReadLine());
        }
    }
    public int Cal() {
        int maxN = n[0]; 

        
        for (int i = 1; i < n.Length; i++)
        {
            if (n[i] > maxN)
            {
                maxN = n[i];
            }
        }

        return maxN;
    }
}

class Program { 
    static void Main(string[] args) {
        /*
        //1_a
        Console.WriteLine($"1_a번째 문제 a 입력");
        int a  = int.Parse(Console.ReadLine());
        Console.WriteLine($"1_a번째 문제 b 입력");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"1_a번째 문제 c 입력");
        int c = int.Parse(Console.ReadLine());
    
        n1a n1a = new n1a(a, b, c);
        Console.WriteLine($"1-a: {n1a.Cal()}");  // 1-a
        
        
        //1_b
        Console.WriteLine($"1_b번째 문제 x 입력");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"1_b번째 문제 y 입력");
        double y = double.Parse(Console.ReadLine());

        n1b n1b = new n1b(x,y);
        Console.WriteLine($"1-b: {n1b.Cal()}");  // 1-b

        
        
        //1_c
        Console.WriteLine($"1_c번째 문제 x1 입력");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"1_c번째 문제 x2 입력");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"1_c번째 문제 y1 입력");
        double y1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"1_c번째 문제 y2 입력");
        double y2 = double.Parse(Console.ReadLine());

        n1c n1c = new n1c(x1,x2,y1, y2);
        Console.WriteLine($"1-c: {n1c.Cal()}");  // 1-c
        
       
        //2
        Console.WriteLine($"2번째 문제 원금 입력");
        double 원금 = double.Parse(Console.ReadLine());
        Console.WriteLine($"2번째 문제 이율 입력");
        double 이율 = double.Parse(Console.ReadLine());
        Console.WriteLine($"2번째 문제 기간 입력");
        double 기간 = double.Parse(Console.ReadLine());

        n2 n2 = new n2(원금,이율,기간);
        Console.WriteLine($"2: {n2.Cal()}");  // 2
        
        
       //3
       Console.WriteLine($"3번째 문제 r 입력");
       double r = double.Parse(Console.ReadLine());

       n3 n3 = new n3(r);
       Console.WriteLine($"3: {n3.Cal()}");  // 3
       

        
       //4
       Console.WriteLine($"4번째 문제 y 입력");
       int y4 = int.Parse(Console.ReadLine());

       n4 n4 = new n4(y4);
       n4.Cal(); // 4
         */
        
       //5
       Console.WriteLine($"5번째 문제 입력");
       n5 n5 = new n5();
       Console.WriteLine($"5: {n5.Cal()}");  // 5
       




    }
}
