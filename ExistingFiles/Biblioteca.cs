using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_avaliativa
{
    class Biblioteca
    {
        public List<Pessoa> Pessoas { get; set; }
        public List<Livro> Livros { get; set; }

        public Biblioteca()
        {
            Pessoas = new List<Pessoa>();
            Livros = new List<Livro>();
        }

        public void CadastrarPessoa(Pessoa pessoa)
        {
            if (Pessoas.Exists(p => p.Id == pessoa.Id))
            {
                Console.WriteLine("Pessoa já cadastrada");
                return;
            }
            Pessoas.Add(pessoa);
        }

        public void CadastrarLivro(Livro livro)
        {
            if (Livros.Exists(l => l.Id == livro.Id))
            {
                Console.WriteLine("Livro já cadastrado");
                return;
            }
            Livros.Add(livro);
        }

        public void EmprestarLivroBiblioteca(int idLivro, int idPessoa)
        {
            var livro = Livros.Find(l => l.Id == idLivro);
            var pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro == null)
            {
                Console.WriteLine("Livro não cadastrado");
                return;
            }
            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não cadastrada");
                return;
            }

            livro.EmprestarLivro(1);
            pessoa.AdicionarLivroLista(livro);

            Console.WriteLine($"O Livro {livro.Titulo} foi emprestado para a pessoa {pessoa.Nome}");
        }

        public void DevolverLivroBiblioteca(int idLivro, int idPessoa)
        {
            var livro = Livros.Find(l => l.Id == idLivro);
            var pessoa = Pessoas.Find(p => p.Id == idPessoa);

            if (livro == null)
            {
                Console.WriteLine("Livro não cadastrado");
                return;
            }
            if (pessoa == null)
            {
                Console.WriteLine("Pessoa não cadastrada");
                return;
            }

            livro.DevolverLivro(1);
            pessoa.RemoverLivroLista(livro.Id);

            Console.WriteLine($"O Livro {livro.Titulo} que estava com a pessoa {pessoa.Nome} foi devolvido com sucesso");


        }
    }
}
