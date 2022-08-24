using System.Text.Json;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections;

namespace MilTec.Model
{


    public class Books
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public Specifications specifications { get; set; }

        public static List<Books> Todos()
        {
            try
            {                
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();

                return lista;
            }
            catch (Exception ex)
            {
                List<Books> erro = null;
                return erro;
            }
        }
        public static Books RetornaPorId(int id)
        {
            try
            {
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();
                Books buscaId= new Books();
                Frete(id);
                foreach (Books item in lista)
                {
                    if (item.id == id)
                    {
                        buscaId = item;
                    }
                    else
                    {

                    }
                }
                return buscaId;
            }
            catch (Exception ex)
            {
                Books erro = null;
                return erro;
            }            
        }

        public static List<Books> RetornaPorAutor(string autor)
        {
            try
            {
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();
                List<Books> buscaAutor = new List<Books>();

                foreach (Books item in lista)
                {                    
                    if (item.specifications.Author == autor)
                    {
                        buscaAutor.Add(item);
                    }
                    else
                    {
                        
                    }
                }
                return buscaAutor;
            }
            catch (Exception ex)
            {
                List<Books> erro = null;
                return erro;
            }
        }

        public static List<Books> RetornaPorNomeLivro(string nome)
        {
            try
            {
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();
                List<Books> buscaNome = new List<Books>();
                
                foreach (Books item in lista)
                {
                    if (item.name == nome)
                    {
                        buscaNome.Add(item);
                    }
                    else
                    {

                    }
                }
                return buscaNome;
            }
            catch (Exception ex)
            {
                List<Books> erro = null;
                return erro;
            }
        }

        public static List<Books> RetornaPorGenero(string genero)
        {
            try
            {
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();
                List<Books> buscaGenero = new List<Books>();
                ArrayList listaGenero = new ArrayList();
                List<object> teste = new List<object>();
                
                foreach (Books item in lista)
                {
                    listaGenero.Add(item.specifications.Genres);
                    for (int i = 0; i < listaGenero.ToArray().Count(); i++)
                    {
                        if (listaGenero[i].ToString() == genero)
                        {
                            listaGenero.Add(item);
                        }
                    }
                }  
                return buscaGenero;
            }
            catch (Exception ex)
            {
                List<Books> erro = null;
                return erro;
            }
        }
        public static double Frete(int id)
        {
            double vfrete = 0;
            try
            {
                List<Books> lista = new List<Books>();
                lista = Books.BuscaJson();
                Books Busca = new Books();

                foreach (Books item in lista)
                {
                    Math.Round(vfrete = item.price * 0.2, 2);
                }
                return vfrete;
            }
            catch (Exception ex)
            {
                return vfrete;
            }
        }

        public static List<Books> BuscaJson()
        {
            string json = "";

            using (var sr = System.IO.File.OpenText(@"D:\MilTecApi\MilTec\MilTec\Arquivo\books.json"))
            {
                json = sr.ReadToEnd();
            }

            Books[]? livros = JsonSerializer.Deserialize<Books[]>(json);
            List<Books> vRetorno = new List<Books>();
            foreach (var item in livros)
            {
                vRetorno.Add(item);
            }
            return vRetorno;            
        }
    }

    public class Specifications
    {
        public string Originallypublished { get; set; }
        public string Author { get; set; }
        public int Pagecount { get; set; }
        public object Illustrator { get; set; }
        public object Genres { get; set; }
    }



}
