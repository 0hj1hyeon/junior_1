using Microsoft.VisualBasic;

class student {
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







class n1 {

    int[,] transpose(int[,] a)
    {
        int r = a.GetLength(0);
        int c = a.GetLength(1);

        int[,] transa = new int[c, r];

        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                transa[j, i] = a[i, j];
            }
        }

        return transa;

    }

    int[,] a = { { 1, 2, 3 },
                      { 4, 5, 6 } };
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
    /*
     */
}

class n7
{
    /*
     */
}

class n8
{
    /*
     */
}