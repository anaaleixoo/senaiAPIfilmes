
using System.Reflection.Metadata.Ecma335;
using api_filmes_senai1.Context;
using api_filmes_senai1.Domains;
using api_filmes_senai1.interfaces;

namespace api_filmes_senai1.Repositories
{
 /// <summary>
 /// Classe que vai imprementar a interface IGeneroRepository
 /// Ou seja, vamos implementar os metodos, toda a logica dos metodos
 /// </summary>
public class FilmeRepository : IFilmeRepository
  {

   private readonly Filmes_Context _context;

   public FilmeRepository(Filmes_Context context)
   {
    _context = context;
   }

   public void Atualizar(Guid id, Filme filme)
        {
        try
        {
         Filme filmeBuscado = _context.Filme.Find(id)!;

        if (filmeBuscado != null)
        {
         filmeBuscado.Título = filme.Título;
         filmeBuscado.IdGenero = filme.IdGenero;
         }

         _context.SaveChanges();
        }
        catch (Exception)
        {

        throw;
        }
             
        }

        public Filme BuscarPorId(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                return filmeBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastar(Filme novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                if (filmeBuscado == null)
                {
                    _context.Filme.Remove(filmeBuscado);
                }

                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Filme> Listar()
        {
            try
            {
                List<Filme> listaDeFilmes = _context.Filme.ToList();
                return listaDeFilmes;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Filme> ListaDeFilmes = Filmes_Context.Filmes
        {

            try 
	        {

            List<Filme> listaDeFilmes = Filmes_Context.Filmes 

              .Include(g => g.Genero)
            .Where(f => f.IdGenero == idGenero)
            .ToList();

         return listaDeFilmes;
         }
	      catch (global::System.Exception)
	     {

		throw;
     	}
        
      }
}
