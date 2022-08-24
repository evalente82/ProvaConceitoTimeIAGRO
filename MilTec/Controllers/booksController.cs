using Microsoft.AspNetCore.Mvc;
using MilTec.Model;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace MilTec.Controllers
{
    [Route("books/")]
    [ApiController]
    public class booksController : ControllerBase
    {
        [HttpGet]
        public List<Books> Index()
        {
            return Books.Todos();
        }
        [HttpGet]
        [Route("{id}")]
        public Books RetornaPorId(int id)
        {
            return Books.RetornaPorId(id);
        }

        [HttpGet]
        [Route("autor/{autor}")]
        public List<Books> RetornaPorAutor(string autor)
        {
            List<Books> retornaPorAutores = Books.RetornaPorAutor(autor);

            return retornaPorAutores;
        }

        [HttpGet]
        [Route("livro/{nome}")]
        public List<Books> RetornaPorNomeLivro(string nome)
        {
            List<Books> retornaPorNomes = Books.RetornaPorNomeLivro(nome);

            return retornaPorNomes;
        }

        [HttpGet]
        [Route("genero/{genero}")]
        public List<Books> RetornaPorGenero(string genero)
        {
            List<Books> retornaPorGenero = Books.RetornaPorGenero(genero);

            return retornaPorGenero;
        }


    }
}
