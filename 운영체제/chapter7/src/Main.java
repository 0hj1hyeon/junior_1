import java.util.Scanner;

public class Main {
    static void gugudan(int a){
        for(int i = 1 ;i<=9;i++){
            System.out.println(a+"*"+i+"="+a*i);
        }

    }
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int a = sc.nextInt();
        gugudan(a);
    }
}
