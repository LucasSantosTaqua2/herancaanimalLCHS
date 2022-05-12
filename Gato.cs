namespace AMS_HerancaAnimal
{
    public class Gato : Animal
    {
        public string Mia = "Miau";

        public void gravarDados(string raca, string nome, int idade, string mia){
            this.Raca = raca;
            this._Nome = nome;
            this.Idade = idade;
            this.Mia = mia;
        }

        public void mostrarDados(){
            Console.WriteLine(this.Raca);
            Console.WriteLine(this._Nome);
            Console.WriteLine(this.Idade);
            Console.WriteLine(this.Mia);
        }
    }
}