using System.Globalization;
Double ans = 0;

Double[] a = new Double[5] { 2,4,6,8,10 };

for (int i = 0; i <= 4; i++)
{

    Double q = 1 /a[i];
    Console.WriteLine(1 + " / " + a[i]  + " = " + q);
    if (i % 2 == 0)
    {
        q = -1 * q;
    }
    ans += q;
}
Console.WriteLine("-----------------------");
Console.WriteLine("답: " + ans);



class n1
{ /*
            

    // 변수 선언

    // 숫자 입력
    Console.Write("a를 입력하세요 : ");
    Double a = Convert.ToDouble(Console.ReadLine());
    Console.Write("b를 입력하세요 : ");
    Double b = Convert.ToDouble(Console.ReadLine());
    Console.Write("c를 입력하세요 : ");
    Double c = Convert.ToDouble(Console.ReadLine());

    Double g = Math.Pow(b,2)-(4*a*c);

    Double ans;
    Double ans1,ans2;
    if (g > 0)
    {
        ans1 = (-b + Math.Sqrt(g))/(2*a);
        ans2 = (-b - Math.Sqrt(g)) / (2 * a);
        Console.WriteLine("첫번째 근: "+ans1+" 두번째 근:"+ans2);
    }
    else if (g == 0)
    {
       ans =  (-1*b)/(2*a);
        Console.WriteLine("첫번째 근: " + ans);
    }
    else {
        Console.WriteLine("허근: " );
    }*/
}

class n2_1{
    /*
   int ans = 0;
int[] b = new int[5] { 9, 7, 5, 3, 1 };
 
for (int i = 0; i <= 4; i++)
{
    int a = 1;
    
    for (int j = 0; j <= 4; j ++)
    {
        if (j >= i)
        {

            Console.Write(b[j]);
            a *= b[j];
            if (j != 4)
            {
                Console.Write("*");
            }
        }
        
       
        
    }
    Console.Write(" " + a);
    ans += a;
    Console.WriteLine("");
}
Console.Write("답: " + ans);
     */
}

class n2_2 {
    /*
     Double ans = 0;
for (Double i = 1; i<=5;i++) {

    Double q = 1 / (i * 2);
    Console.WriteLine(1+" / "+(i*2)+" = "+q);
    if (i % 2 == 0) {
        q = -1 * q;
    }
    ans += q;
}
Console.WriteLine("-----------------------");
Console.WriteLine("답: "+ans);*/
}

class n3 {
    /*
     for (int j = 9; j >=1; j--) {
    for (int i = 9; i >= 1; i--) {
        if (j>=i)
        Console.Write(i);
        else Console.Write(" ");
    }
    for (int k = 2; k <= 9; k++) {
        if (j >= k)
            Console.Write(k);
    }
    Console.WriteLine();

}*/
}

class n4 {
    /*
     for (int j = 4; j >=1; j--) {
    for (int k = 1; k <= 4; k++)
    {
        if (j >= k)
            Console.Write("*");
        else Console.Write(" ");
    }
    Console.Write(" ");
    for (int i = 4; i >= 1; i--) {
        if (j>=i)
        Console.Write("*");
        else Console.Write(" ");
    }
    
    Console.WriteLine();

}
for (int j = 1; j <= 4; j++)
{
    if (j == 1) {
        continue;
    }
    for (int k = 1; k <= 4; k++)
    {
        if (j >= k)
            Console.Write("*");
        else Console.Write(" ");
    }
    Console.Write(" ");
    for (int i = 4; i >= 1; i--)
    {
        if (j >= i)
            Console.Write("*");
        else Console.Write(" ");
    }

    Console.WriteLine();

}*/
}

class n5 {
    /* 
     * int a = 0;
for (int i = 1; i<10; i += a){
    
    for (int k = 1; k <= 9 ;k++) {
        for (int j=i; j<=i+a;j++) {
            Console.Write(j+"*"+k+"="+j*k+" ");
        }
        Console.WriteLine();
    }

    a += 1;
    
}
     */
}