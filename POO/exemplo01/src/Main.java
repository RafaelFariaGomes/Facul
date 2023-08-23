public class Main {
    public static void main(String[] args) {

        Estudante e1 = new Estudante();
        Estudante e2 = new Estudante();

        e1.nome = "José";
        e1.idade = 22;

        e2.setNome("Rafael Faria");
        e2.setIdade(-8);
        e2.escreveAtributos();

        //e1.escreveNome("Rafael Faria");
    }
}