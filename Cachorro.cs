namespace AMS_HerancaAnimal
{
    public class Cachorro : Animal
    {
        public string Latir = "AuAu";

        public void gravarDados(string raca, string nome, int idade, string latir){
            this.Raca = raca;
            this._Nome = nome;
            this.Idade = idade;
            this.Latir = latir;
        }

        public void mostrarDados(){
            Console.WriteLine(this.Raca);
            Console.WriteLine(this._Nome);
            Console.WriteLine(this.Idade);
            Console.WriteLine(this.Latir);
        }
    }
}