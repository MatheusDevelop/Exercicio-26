using System.IO;
using System;
namespace xdb
{
    public class Produto
    {
        
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH ="./Database/produto.csv";

        public Produto(){
            if(!File.Exists(PATH))
            {
                Directory.CreateDirectory("./Database");
                
                File.Create(PATH).Close();
            }
            
        }
    

        public void Cadastrar(Produto prod)
        {   
             if(!File.Exists(PATH))
            {
                    Console.WriteLine("erro");
            }
            var linha = new string[] { PrepararLinha(prod) }; 
        
            

            File.AppendAllLines(PATH,linha); 
            
        }
        
        private string PrepararLinha(Produto p){
            return $"codigo={p.Codigo};nome={p.Nome};preco={p.Preco}";
        }


    }
}