// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Net.Http.Headers;

/*public abstract class Game {
    protected int userWin, computerWin, drawMatch;
    protected Game() {
        userWin = computerWin = drawMatch = 0;
    }
    ~Game() {
        result();
    }
    public abstract void result();

    public void recordPrint() {
        Console.WriteLine(userWin +" 승 "+ computerWin +" 패 "+ drawMatch + "무승부입니다");
    }
}

public class Srp : Game {
    public void play() {
        while (true)
        {
            Console.WriteLine("입력하세요 가위: 1 바위: 2 보: 3 종료: 0");
            int userChoice = int.Parse(Console.ReadLine());
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            if (userChoice == 0)  break; 

            if (userChoice == computerChoice)
            {
                computerhand(computerChoice);
                Console.WriteLine("무승부!");
                drawMatch++;
            }
            else if ((userChoice == 1 && computerChoice == 3) || // 사용자가 가위를 선택하고, 컴퓨터가 보를 선택한 경우
                     (userChoice == 2 && computerChoice == 1) || // 사용자가 바위를 선택하고, 컴퓨터가 가위를 선택한 경우
                     (userChoice == 3 && computerChoice == 2)) // 사용자가 보를 선택하고, 컴퓨터가 바위를 선택한 경우
            {
                computerhand(computerChoice);
                Console.WriteLine("사용자 승리!");
                userWin++;  
            }
            else
            {
                computerhand(computerChoice);
                Console.WriteLine("컴퓨터 승리!");
                computerWin++;  
            }
        }
        result();
    }
    public void computerhand(int i) {
        if (i == 1) Console.WriteLine("컴퓨터는 가위를 냈습니다");
        if (i == 2) Console.WriteLine("컴퓨터는 바위를 냈습니다");
        if (i == 3) Console.WriteLine("컴퓨터는 보위를 냈습니다");



    }
    public override void result()
    {
        recordPrint();
    }
}

public class Mjb : Srp {
    new public void play() {
        do
        {
            Random random = new Random();
            Console.WriteLine("가위, 바위, 보 중 하나를 선택하세요 (가위: 1, 바위: 2, 보: 3 종료: 0):");
            
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 0) break;
            int attacker = 1; // 1이면 유저 0이면 컴퓨터

            int computerChoice = random.Next(1, 4);

            if (userChoice == computerChoice)
            {
                computerhand(computerChoice);
                Console.WriteLine("무승부!");
                drawMatch++;
                continue;
            }
            else if ((userChoice == 1 && computerChoice == 3) || // 사용자가 가위를 선택하고, 컴퓨터가 보를 선택한 경우
                     (userChoice == 2 && computerChoice == 1) || // 사용자가 바위를 선택하고, 컴퓨터가 가위를 선택한 경우
                     (userChoice == 3 && computerChoice == 2)) // 사용자가 보를 선택하고, 컴퓨터가 바위를 선택한 경우
            {
                computerhand(computerChoice);
                Console.WriteLine("공격자는 유저입니다.");
                attacker = 1;

            }
            else
            {
                computerhand(computerChoice);
                Console.WriteLine("공격자는 컴퓨터입니다");
                attacker = 0;

            }


            while (true)
            {
                Console.WriteLine("묵찌빠 시작입니다");
                Random random1 = new Random();
                Console.WriteLine("가위, 바위, 보 중 하나를 선택하세요 (가위: 1, 바위: 2, 보: 3):");
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 0) break;

                computerChoice = random.Next(1, 4);

                if (userChoice == computerChoice)
                {
                    computerhand(computerChoice);
                    if (attacker == 1) {
                        Console.WriteLine("유저의 승리");
                        userWin++;
                        break;
                    }
                    if (attacker == 0) {
                        Console.WriteLine("유저의 승리");
                        computerWin++;
                        break;
                    }
                }
                else if ((userChoice == 1 && computerChoice == 3) || // 사용자가 가위를 선택하고, 컴퓨터가 보를 선택한 경우
                         (userChoice == 2 && computerChoice == 1) || // 사용자가 바위를 선택하고, 컴퓨터가 가위를 선택한 경우
                         (userChoice == 3 && computerChoice == 2)) // 사용자가 보를 선택하고, 컴퓨터가 바위를 선택한 경우
                {
                    computerhand(computerChoice);
                    Console.WriteLine("공격자는 유저입니다.");
                    attacker = 1;

                }
                else
                {
                    computerhand(computerChoice);
                    Console.WriteLine("공격자는 컴퓨터입니다");
                    attacker = 0;

                }


            }
        } while (true);

        result(); 
    }
}


class Program {
    static void Main(string[] args) {
        Console.Write("선택하세요 가위바위보 게임 1, 묵찌빠 게임 2: ");
        int i = Convert.ToInt32(Console.ReadLine());
        if (i == 1) new Srp().play();
        else if (i == 2) new Mjb().play();
        else Console.WriteLine("잘못 입력했습니다.");
    }

}
*/
public interface Unit
{
    string Name { get; set; }  // 이름
    string Clan { get; set; }  // 종족
    string Skill { get; set; } // 스킬
    int Damage { get; set; } // 공격력
    int Strength { get; set; } // 체력

}

public abstract class ProtossUnit : Unit
{
    public string Name { get; set; } // 이름
    public string Clan { get; set; } // 종족
    public string Skill { get; set; } // 스킬
    public int Damage { get; set; } // 공격력
    public int Strength { get; set; } // 체력

    public int Shield { get; set; } // 쉴드

    public ProtossUnit()
    {
        Clan = "프로토스";
    }

    public string getClan()
    {
        return Clan;
    }
    public int getDamage()
    {
        return Damage;
    }

    public int getStrength()
    {
        return Strength;
    }

    public int getShield()
    {
        return Shield;
    }



    public string getName()
    {
        return Name;
    }

    public string getSkill()
    {
        return Skill;
    }

}

public class DarkTemplar : ProtossUnit {



    
    public DarkTemplar() {
        Name = "다크템플러";
        Shield = 80;
        Strength = 40;
        Damage = 45;
        Skill = "클로킹";
       
    }
    

}

class Nexus {
    int mineral { get; set; }
    int gas { get; set; }
    public Nexus(int mineral) {
        this.mineral = mineral ;
        if (mineral >= 50)
        {
            Console.WriteLine("프로브 생산");
        }
        else {
            Console.WriteLine("광물이 부족합니다");
        }
    }

    public Nexus(int mineral, int gas)
    {
        this.mineral = mineral;
        this.gas = gas;

        if (mineral >= 300 && gas >= 300)
        {
            Console.WriteLine("모선 생산");
        }
        else {
            Console.WriteLine("광물 혹은 가스가 부족합니다");
        }
    }
}

class Program {
    static void Main(string[] args)
    {
        ProtossUnit DT = new DarkTemplar();

        int Damage = DT.getDamage();
        int Strength = DT.getStrength();
        int Shield = DT.getShield();

        Console.WriteLine("종족: " + DT.getClan());
        Console.WriteLine("이름: " + DT.getName());
        Console.WriteLine("쉴드: " + Shield);
        Console.WriteLine("체력: " + Strength);
        Console.WriteLine("데미지: " + Damage.ToString());
        Console.WriteLine("스킬: " + DT.getSkill());

        Console.WriteLine();

        Nexus N1 = new Nexus(40);
        Nexus M1 = new Nexus(30, 30);

        Console.WriteLine();

        Nexus N2 = new Nexus(50);
        Nexus M2 = new Nexus(300, 300);

        Console.WriteLine();
    }

}