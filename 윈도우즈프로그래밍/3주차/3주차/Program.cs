using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("1000원이하 숫자 입력: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int w500 = n / 500;
        n %= 500;
        Console.WriteLine("500원: "+ w500+"개");
        int w100 = n / 100;
        n %= 100;
        Console.WriteLine("100원: " + w100 + "개");
        int w50 = n / 50;
        n %= 50;
        Console.WriteLine("50원: " + w50 + "개");
        int w10 = n / 10;
        n %= 10;
        Console.WriteLine("10원: " + w10 + "개");
        int w5 = n / 5;
        n %= 5;
        Console.WriteLine("5원: " + w5 + "개");
        int w1 = n / 1;
        n %= 1;
        Console.WriteLine("1원: " + w1 + "개");

    }
}



  

class solving {
    void n1s()
    {
        int a = 0;
        for (int i = 1; i <= 100; i++)
        {
            a += 2 * i;
        }


        int b = 1;
        for (int i = 1; i <= 10; i++)
        {
            b *= i;
        }

        int result = a + b;

        Console.WriteLine("1번 결과: " + result);
    }
    void n2as() {
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            int jsum = 1;
            for (int j = 1; j <= i; j++)
            {
                jsum *= j;
            }
            sum += jsum;
        }




        Console.WriteLine("2-a번 결과: " + sum);
    }
    void n2bs() {
        double sum = 0.0;
        for (int i = 1; i <= 10; i++)
        {

            if (i % 2 == 0)
                sum -= 1.0 / i;
            else
                sum += 1.0 / i;
        }

        Console.WriteLine("2-b 결과: " + sum);
    }
    void n3s() {
        for (int i = 0; i <= 4; i += 4)
        {
            int a = 2 + i; int b = 3 + i; int c = 4 + i; int d = 5 + i;
            for (int j = 1; j <= 9; j++)
            {
                Console.WriteLine(a + "*" + j + "=" + (a * j) + " " + b + "*" + j + "=" + (b * j) + " " + c + "*" + j + "=" + (c * j) + " " + d + "*" + j + "=" + (d * j));
            }
        }
    }
    void n4s() {
        Console.WriteLine("100 이하의 소수:");

        for (int i = 2; i <= 100; i++)
        {
            bool p = true;


            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    p = false;
                    break;
                }
            }


            if (p)
            {
                Console.Write(i);
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
    void n5s(){
        Console.WriteLine("500 이하의 완전수:");

        for (int i = 2; i <= 500; i++)
        {
            int sum = 0;
            for (int j = 1; j <= i / 2; j++)
            {
                if (i % j == 0)
                    sum += j;
            }

            if (sum == i)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
    void n6s(){
        Console.Write("정수 입력: ");
        int num = Convert.ToInt32(Console.ReadLine());

        string ns = num.ToString();
        int l = 0;
        int r = ns.Length - 1;
        bool p = true;

        while (l < r)
        {
            if (ns[l] != ns[r])
            {
                p = false;
                break;
            }
            l++;
            r--;
        }

        if (p)
            Console.WriteLine("회문수");
        else
            Console.WriteLine("회문수 아님");
    }
    void n7s(){
        Console.Write("암스트롱수: ");
        for (int i = 100; i <= 500; i++)
        {
            int a = i / 100;
            int j = i % 100;
            int b = j / 10;
            int c = j % 10;

            int r = (int)Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3);
            if (i == r)
            {
                Console.WriteLine(" " + i);
            }

        }
    }
    void n8s(){
    }

    void n9s(){
        int n = 5;

        for (int i = 1; i <= n; i++)
        {

            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");


            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");

            Console.WriteLine();
        }


        for (int i = n - 1; i >= 1; i--)
        {

            for (int j = 1; j <= n - i; j++)
                Console.Write(" ");


            for (int k = 1; k <= 2 * i - 1; k++)
                Console.Write("*");

            Console.WriteLine();
        }
    }
    void n10s(){
        Console.Write("1000원이하 숫자 입력: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int w500 = n / 500;
        n %= 500;
        Console.WriteLine("500원: " + w500 + "개");
        int w100 = n / 100;
        n %= 100;
        Console.WriteLine("100원: " + w100 + "개");
        int w50 = n / 50;
        n %= 50;
        Console.WriteLine("50원: " + w50 + "개");
        int w10 = n / 10;
        n %= 10;
        Console.WriteLine("10원: " + w10 + "개");
        int w5 = n / 5;
        n %= 5;
        Console.WriteLine("5원: " + w5 + "개");
        int w1 = n / 1;
        n %= 1;
        Console.WriteLine("1원: " + w1 + "개");
    }
}