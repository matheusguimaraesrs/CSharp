using RedeSocial_Enum.Entities;
using System;

namespace RedeSocial_Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentarios c1 = new Comentarios("Tenha uma boa viagem");
            Comentarios c2 = new Comentarios("Maneiro");
            Post p1 = new Post(
                    DateTime.Parse("18/12/2025 13:45:28"),
                    "Viajando pela Europa",
                    "virei mochileiro",
                    12
                );
            p1.AddComentario(c1);
            p1.AddComentario(c2);
            Comentarios c3 = new Comentarios("Boa noite pra vc tbm!");
            Comentarios c4 = new Comentarios("Boa boa");
            Post p2 = new Post(
                    DateTime.Parse("17/12/2025 13:49:58"),
                    "Boa noite!",
                    "Boa noite pra todos meus amigos",
                    45
                );
            p2.AddComentario(c3);
            p2.AddComentario(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}