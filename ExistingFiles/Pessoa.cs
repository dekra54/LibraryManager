using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_avaliativa
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public List<Livro> LivrosEmprestados { get; set; }

        public Pessoa()
        {
            LivrosEmprestados = new List<Livro>();
        }

        public void AdicionarLivroLista(Livro livro)
        {
            LivrosEmprestados.Add(livro);
            Console.WriteLine("Livro adicionado à lista de empréstimos.");
        }

        public void RemoverLivroLista(int idLivro)
        {
            Livro livroARemover = null;
            foreach (Livro livro in LivrosEmprestados)
            {
                if (livro.Id == idLivro)
                {
                    livroARemover = livro;
                    break;
                }
            }
            if (livroARemover != null)
            {
                LivrosEmprestados.Remove(livroARemover);
                Console.WriteLine("Livro removido da lista de empréstimos.");
            }
            else
            {
                Console.WriteLine("Livro não encontrado na lista de empréstimos.");
            }
        }
    }
}
