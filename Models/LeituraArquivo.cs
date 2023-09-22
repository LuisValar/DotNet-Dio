using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] LinhasArquivo, int QtdLinhas) LerArquivo(string caminhoArquivo)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminhoArquivo);
                
                return (true, linhas, linhas.Count());
            }
            catch(Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}