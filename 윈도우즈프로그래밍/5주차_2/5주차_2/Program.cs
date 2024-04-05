
using System;
using System.Runtime.ExceptionServices;
//도서를 저장하는 2차원 배열 선언
string[,] book = new string[10,2];
int i = 0;
bool tf = true;
do
{
    Console.WriteLine("*********************************************************");
    Console.WriteLine("1: 도서추가, 2 : 도서 검색, 3. 도서 리스트 출력, 0 : 종료");
    Console.WriteLine("*********************************************************");

    int num = int.Parse(Console.ReadLine());

    switch (num) //switch 를 통해 해당 메뉴로 넘어감
    {
        case 1:
            if (i >= 9) {
                Console.WriteLine("더 이상 책의 정보를 입력하실 수 없습니다.");
                break;
            }
            Console.WriteLine("입력할 도서와 저자를 입력하시오");
            string bookinfor = Console.ReadLine();
            string[] bookp = bookinfor.Split(',');

            
            book[i,0] = bookp[0];
            book[i,1] = bookp[1];
            i++;
            break;
        case 2:
            Console.WriteLine("찾을 책이나 저자를 입력하시오");
            string finds = Console.ReadLine();
            bool fi = false;
            foreach (string infor in book)
            {
                if (finds.Equals(infor)) {
                    Console.WriteLine("찾고자하는 도서나 저자가 있습니다");
                    fi = true;
                    break;
                }
             
            }
            if (!fi) {
                Console.WriteLine("찾고자하는 도서나 저자가 없습니다");
            }
            break;
        case 3:
            for (int q = 0; q <i; q++)
            {
                Console.Write(q + 1 + ". ");
                for (int w = 0; w < book.GetLength(1); w++)
                {
                   
                    Console.Write(book[q, w] + " ");
                }
                Console.WriteLine();
            }
                break;
        case 0:
            Console.WriteLine("종료");
            tf = false;
            break;
        
        default:
            Console.WriteLine("숫자를 제대로 입력해주세요");
            
            break;
    }
} while (tf);





class n1 {
    /*
     * int[] gugu = new int[9];
Console.WriteLine("단을 입력하세요:");

int dan = int.Parse(Console.ReadLine());


for ( int i =0; i<9; i++ )//for문을 통해 배열에 결과값 저장
{
    gugu[i] = dan * (i + 1);
}

int j = 1;
foreach (int gu in gugu) //foreach문으로 배열에 있는 값 전부 출력
{
    Console.WriteLine(dan+" * "+ j+" = "+gu);
    j++;
}
     */
}


class n2 {
    /*
      //배열 생성
    bool tf = false;
    String[] str = { "computer", "science", "ENGINEERING", "android", "VISUALSTUDIO" };

    Console.Write("검색할 단어을 입력하세요:");
    String a = Console.ReadLine();
    foreach (String b in str) //foreach문으로 배열 탐색
    {
        if (a.Equals(b) ){
            tf = true;
            Console.WriteLine("검색한 단어 '"+a+"'(이)가 배열에 있습니다");
            break;
        }
    }
    if (!tf) {
        Console.WriteLine("검색한 단어 '" + a + "'(이)가 배열에 없습니다");
    }
    //결과 출력
     */
}

class n3 {
    /*
     * using System;
    using System.Runtime.ExceptionServices;
    //도서를 저장하는 2차원 배열 선언
    string[,] book = new string[10,2];
    int i = 0;
    bool tf = true;
    do
    {
        Console.WriteLine("*********************************************************");
        Console.WriteLine("1: 도서추가, 2 : 도서 검색, 3. 도서 리스트 출력, 0 : 종료");
        Console.WriteLine("*********************************************************");

        int num = int.Parse(Console.ReadLine());

        switch (num) //switch 를 통해 해당 메뉴로 넘어감
        {
            case 1:
                if (i >= 9) {
                    Console.WriteLine("더 이상 책의 정보를 입력하실 수 없습니다.");
                    break;
                }
                Console.WriteLine("입력할 도서와 저자를 입력하시오");
                string bookinfor = Console.ReadLine();
                string[] bookp = bookinfor.Split(',');


                book[i,0] = bookp[0];
                book[i,1] = bookp[1];
                i++;
                break;
            case 2:
                Console.WriteLine("찾을 책이나 저자를 입력하시오");
                string finds = Console.ReadLine();
                bool fi = false;
                foreach (string infor in book)
                {
                    if (finds.Equals(infor)) {
                        Console.WriteLine("찾고자하는 도서나 저자가 있습니다");
                        fi = true;
                        break;
                    }

                }
                if (!fi) {
                    Console.WriteLine("찾고자하는 도서나 저자가 없습니다");
                }
                break;
            case 3:
                for (int q = 0; q <i; q++)
                {
                    Console.Write(q + 1 + ". ");
                    for (int w = 0; w < book.GetLength(1); w++)
                    {

                        Console.Write(book[q, w] + " ");
                    }
                    Console.WriteLine();
                }
                    break;
            case 0:
                Console.WriteLine("종료");
                tf = false;
                break;

            default:
                Console.WriteLine("숫자를 제대로 입력해주세요");

                break;
        }
    } while (tf);
     */
}