class Fraction

{

    public int numberator; // 분자

    public int denominator; // 분모

    public Fraction(int a) // 1번 정수 한개 받기

    {

        numberator = a;

        denominator = 0;

    }



    public Fraction(int a, int b) // 2번 정수 두개 받기

    {

        numberator = a;

        denominator = b;

    }

    public override string ToString()    // 3번 to string

    {

        return "(" + numberator + " / " + denominator + ")";

    }
    public int GratestCommonDivisor(int a, int b) { // 4번 최대공약수
        int c = 0;
        if (a > b) c = b;
        else c = a;
        for (; c >= 0; c--) {
            if (a % c == 0 && b % c == 0) break;

        }
        return c;
        
    }
    public void irreducibleFraction(Fraction a){ // 기약분수 출력하기
        Console.WriteLine("기약분수는: (" + numberator / GratestCommonDivisor(numberator, denominator) + " / " + denominator / GratestCommonDivisor(numberator, denominator) + ")");
    }
    public void addFraction(Fraction a,Fraction b) { // 덧셈
        int adddeno = a.denominator * b.denominator;
        int addnum = (a.numberator * b.denominator) + (b.numberator * a.denominator);
        
        Console.Write("f1 + f2 = ");
        Console.WriteLine("(" + addnum  + " / " + adddeno + ")");

    }

    public void subFraction(Fraction a, Fraction b) //뺄셈
    {
        int adddeno = a.denominator * b.denominator;
        int addnum = (a.numberator * b.denominator) - (b.numberator * a.denominator);
      
        Console.Write("f1 - f2 = ");
        Console.WriteLine("(" + addnum + " / " + adddeno + ")");

    }
    public void mulFraction(Fraction a, Fraction b) // 곱셈
    {
        int adddeno = a.denominator * b.denominator;
        int addnum = a.numberator *b.numberator ;
       
        Console.Write("f1 * f2 = "); ;
        Console.WriteLine("(" + addnum + " / " + adddeno + ")");

    }
    public void divFraction(Fraction a, Fraction b) // 나눗셈
    {
        int adddeno = a.denominator * b.numberator;
        int addnum = a.numberator * b.denominator;
        
        Console.Write("f1 ÷ f2 = ");
        Console.WriteLine("(" + addnum + " / " + adddeno + ")");

    }
}

class Test // 선언된 클래스 Fraction의 메소드를 테스트 하기 위해 테스트 클래스를 선언.
{
   
    static void Main(string[] args)

    {

        Fraction f1, f2; // 분수를 나타낼 클래스 f1, f2를 선언.



        f1 = new Fraction(5, 6);

        // 생성자를 이용하여 분수식 f1을 분자 5, 분모 6으로 초기화

        f2 = new Fraction(2, 4);

        // 생성자를 이용하여 분수식 f2를 분자 2, 분모 4로 초기화



        Console.WriteLine("분수식 f1: " + f1.ToString());

        Console.WriteLine("분수식 f2: " + f2.ToString());

        // f1, f2를 분수식의 형태로 출력



        Console.WriteLine("분수식 f1의 최대공약수: "

        + f1.GratestCommonDivisor(f1.numberator, f1.denominator));

        Console.WriteLine("분수식 f2의 최대공약수: "

        + f2.GratestCommonDivisor(f2.numberator, f2.denominator));

        // 분수식 f1, f2의 최대공약수를 출력한다.



        f1.irreducibleFraction(f1);

        f2.irreducibleFraction(f2); // 분수식 f1, f2의 기약분수를 출력.



        f1.addFraction(f1,f2);
        f1.subFraction(f1,f2);
        f1.mulFraction(f1,f2);
        f1.divFraction(f1,f2);
    }
}