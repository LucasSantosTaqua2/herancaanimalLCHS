using AMS_HerancaAnimal;
using System;

namespace AMS_HerancaAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro cachorro = new Cachorro();
            cachorro.gravarDados("Fox Paulistinha", "Teca", 2, "Auuuu"); 
            cachorro.mostrarDados();      
            Gato gato = new Gato();
            gato.gravarDados("Munchkin", "Mike", 3, "Miauuuu"); 
            gato.mostrarDados(); 
        }

    }
}

