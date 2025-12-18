using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedeSocial_Enum.Entities
{
    class Post
    {
        public DateTime Momento { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentarios> Comentario { get; set; } = new List<Comentarios>();

        public Post() { }

        public Post(DateTime momento, string titulo, string conteudo, int likes)
        {
            Momento = momento;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AddComentario(Comentarios comentario)
        {
            Comentario.Add(comentario);
        }
        public void RemoveComentario(Comentarios comentario)
        {
            Comentario.Remove(comentario);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Titulo);
            sb.Append(Likes + " Likes - ");
            sb.AppendLine(Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Conteudo);
            sb.AppendLine("comentários:");
            foreach (Comentarios c in Comentario)
            {
                sb.AppendLine(c.Txt);
            }
            return sb.ToString();
        }
    }
}
