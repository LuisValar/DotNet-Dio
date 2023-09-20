using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
           
        }
        public Pessoa(string nome, string sobreNome)
        {
           NomePessoa = nome;
           SobreNome = sobreNome; 
        }
        private string _nomePessoa;
        private int _idade;
        public string NomePessoa { 
            get => _nomePessoa.ToUpper();
             

            set{
                if (value == ""){
                    throw new ArgumentException ("O nome não pode ser vazio");
                }
                _nomePessoa = value;
            } 
        }


        public int Idade { 
            get => _idade;
             
            set{
                if(value < 0){
                    throw new ArgumentException ("A idade precisa ser maior que 0");
                }
                _idade = value;
            } 
        }

        public string SobreNome { get; set; }

        public string NomeCompleto => $"{NomePessoa} {SobreNome}".ToUpper();

        public void Apresentar(){
            Console.WriteLine($"Nome: {NomeCompleto}, idade: {Idade}");
        }
    }
}   