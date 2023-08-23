import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int bzin, bzaum, altura, areaTrapezio;
        System.out.println("Digite o valor da base maior do trapézio");
        bzaum = scan.nextInt();

        System.out.println("Digite a base menor do trapézio");
        bzin = scan.nextInt();

        System.out.println("Digite a Altura do Trapézio");
        altura = scan.nextInt();

        areaTrapezio = (bzaum+bzin) * altura / 2;

        System.out.println("A area do trapézio é " + areaTrapezio);
    }
}