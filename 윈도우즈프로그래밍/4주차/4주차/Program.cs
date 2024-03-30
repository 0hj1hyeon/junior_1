using Microsoft.VisualBasic;

using System;

Console.WriteLine("홀수 입력:");
int n = int.Parse(Console.ReadLine());



int[,] m = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        m[i, j] = 0;
    }
}

int r = 0;
int c = n / 2;

for (int num = 1; num <= n * n; num++)
{
    m[r, c] = num;

    int nr = (r - 1 + n) % n;
    int nc = (c + 1) % n;

    if (m[nr, nc] != 0)
    {
        r = (r + 1) % n;
    }
    else
    {
        r = nr;
        c = nc;
    }
}

Console.WriteLine("홀수 마방진:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(m[i, j] + "\t");
    }
    Console.WriteLine();
}








class n1 {

    /*
     * class Program
{
    static int[,] Transpose(int[,] m)
    {
        int r = m.GetLength(0);
        int c = m.GetLength(1);

        int[,] t = new int[c, r];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                t[j, i] = m[i, j];
            }
        }

        return t;
    }

    static void Main(string[] args)
    {
        
        int[,] d = {
            {1, 2, 3},
            {4, 5, 6}
        };

       
        int[,] t = Transpose(d);

        // 결과 출력
        Console.WriteLine("원래:");
        Printing(d);

        Console.WriteLine("\n바뀐값:");
        Printing(t);
    }

    static void Printing(int[,] m)
    {
        int r = m.GetLength(0);
        int c = m.GetLength(1);

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
     * */
}

class n2 {

    /*char[] com = { 'C', 'o', 'm', 'p', 'u', 't', 'e', 'r' };
    foreach (char c in com)
    {
        Console.Write(c);
    }*/
}
class n3
{
    /*
     int[][] arr = new int[3][];
arr[0] = new int[] { 0,1,2};
arr[1] = new int[] { 4,5,6,7};
arr[2] = new int[] { 10,11,12,13,14};


for (int i = 0; i <= 2; i++) {
    Console.Write("arr[{0}]: ",i);
    for (int j = 0; j < arr[i].Length; j++) { 
        Console.Write("{0} ", arr[i][j]);
    }
    Console.WriteLine();
}
     */
}
class n4
{
    /*
     Random r = new Random();

int[] a = new int[5];

for (int i = 0; i < 5; i++)
{
    a[i] = r.Next(99) + 1;
}

Array.Sort(a);
Array.Reverse(a);


Console.WriteLine("랜덤정수 내림차순 출력");


foreach (int value in a) {
    Console.Write("{0,5}",value);
}
     */
}

class n5
{
    /*
     Random r = new Random();

double[] a = new double[5];

for (int i = 0; i < 5; i++)
{
    a[i] = r.NextDouble() *100;
}

Array.Sort(a);
Array.Reverse(a);


Console.WriteLine("랜덤정수 내림차순 출력");


foreach (double value in a) {
    Console.Write("{0,5} ",value);
}
     */
}

class n6
{
    /*int[,] a = {
            {1, 1},
            {2, 2},
            {3, 3}  };

int[,] b = { {1, 2, 3},
            {1, 2, 3} };

int ra = a.GetLength(0);
int ca = a.GetLength(1);
int cb = b.GetLength(1);

int[,] r = new int[ra, cb];

for (int i = 0; i < ra; i++)
{
    for (int j = 0; j < cb; j++)
    {
        for (int k = 0; k < ca; k++)
        {
            r[i, j] += a[i, k] * b[k, j];
        }
    }
}
     */
}

class n7
{
    /*
     * class student {
    public int sn;
    public double k;
    public double eng;
    public double math;

    public student(int sn, double k, double eng, double math)
    {
        this.sn = sn;
        this.k = k;
        this.eng = eng;
        this.math = math;
    }
    public double totalp() {

        return k + eng + math;
    }

    public double aver()
    {

        return (k + eng + math)/3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        student[] a = new student[5];

        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"학생 {i + 1}의 정보를 입력하세요.");
            Console.Write("학번: ");
            int sn = int.Parse(Console.ReadLine());
            Console.Write("국어 성적: ");
            double k = double.Parse(Console.ReadLine());
            Console.Write("영어 성적: ");
            double eng = double.Parse(Console.ReadLine());
            Console.Write("수학 성적: ");
            double math = double.Parse(Console.ReadLine());

            
            a[i] = new student(sn, k, eng, math);
        }

        double tk =0 ;
        double teng =0;
        double tmath=0;

        Console.WriteLine("학생 정보");
        foreach (student s in a) {
            Console.WriteLine($"학번:{s.sn}, 총점: {s.totalp()}, 평균: {s.aver()}" );
            tk += s.k;
            teng += s.eng;
            tmath += s.math;
            

        }
        tk /= 5;
        teng /= 5;
        tmath /= 5;
        Console.WriteLine($"국어 평균: {tk}, 영어 평균: {teng}, 수학 평균: {tmath}");

    }
}
     */
}

class n8
{
    /*
     */
}