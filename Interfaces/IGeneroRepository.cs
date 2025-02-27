using api_filmes_senai1.Domains;

namespace api_filmes_senai1.interfaces
{
    /// <summary>
    /// Interface para Genero : Contrato
    /// Toda classe que herdar(implementar) essa interface, devera implementar
    /// todos os metodos definidos aqui dentro
    /// </summary>
    public interface IGeneroRepository
    {
        //CRUD : Metodos
        //C : Create : Cadastrar um novo objeto 
        //R : Read : Listar todos os objetos 
        //U : Update : Alterar um objeto
        //D : Delete : Deleto pu excluo um objeto 

        // Metodo = TipoDeRetorno NomeDoMetodo(Argumnetos) 

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();

        void Atualizar(Guid id, Genero genero);

        void Deletar(Guid Id);

        Genero BuscarPorId(Guid Id);


    }

}
