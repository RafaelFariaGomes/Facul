public class Carro {
    String nomeCarro;
    String corCarro;
    String marca;
    String modelo;
    int ano;

    public void mostraAtributos(){
        System.out.printf("""
                Nome do carro: %s
                Cor do carro: %s
                Marca: %s
                Modelo: %s
                Ano do carro: %s""", nomeCarro, corCarro, marca, modelo, ano);
    }

    public void ligaCarro(){
        System.out.println("\n\n" + nomeCarro + " Ligado!");
    }

    public String getNomeCarro() {
        return nomeCarro;
    }

    public void setNomeCarro(String nomeCarro) {
        this.nomeCarro = nomeCarro;
    }

    public String getCorCarro() {
        return corCarro;
    }

    public void setCorCarro(String corCarro) {
        this.corCarro = corCarro;
    }

    public String getMarca() {
        return marca;
    }

    public void setMarca(String marca) {
        this.marca = marca;
    }

    public String getModelo() {
        return modelo;
    }

    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    public int getAno() {
        return ano;
    }

    public void setAno(int ano) {
        this.ano = ano;
    }
}
