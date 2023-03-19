using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_avaliativa
{
    class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int QuantidadeExemplares { get; set; }

        public void EmprestarLivro(int quantidadeEmprestada)
        {
            if (quantidadeEmprestada <= QuantidadeExemplares)
            {
                QuantidadeExemplares -= quantidadeEmprestada;
                Console.WriteLine("Livro emprestado com sucesso.");
            }
            else
            {
                Console.WriteLine("Não há exemplares suficientes deste livro disponíveis.");
            }
        }

        public void DevolverLivro(int quantidadeDevolvida)
        {
            QuantidadeExemplares += quantidadeDevolvida;
            Console.WriteLine("Livro devolvido com sucesso.");
        }
    }
}
