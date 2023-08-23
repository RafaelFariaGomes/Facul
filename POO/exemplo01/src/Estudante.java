public class Estudante {
    //Atributos
    String nome;
    int idade;

    //Métodos
    public void escreveAtributos(){
        System.out.println("este é o nome: " + nome);
        System.out.println("sua Idade: "+ idade);


    }
    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public int getIdade() {
        return idade;
    }

    public void setIdade(int idade) {
        if(idade >= 0)
        this.idade = idade;
        else
            System.out.println("idade Invalida!");
    }
}
