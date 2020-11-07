using System;
using System.Linq;

// ReSharper disable All

namespace Youtube
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("+(1) Crear usuario        +");
                Console.WriteLine("+(2) Acceder              +");
                Console.WriteLine("+(5) Salir                +");
                Console.WriteLine("+-------------------------+");
                string input = Console.ReadLine();
                switch (Int16.Parse(input))
                {
                    case 1:
                        createUser();
                        break;
                    case 2:
                        acceder();
                        break;
                    case 5:
                        Console.WriteLine("Exit...");
                        execute = false;
                        Environment.Exit(1);
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        public static void createUser()
        {
            Console.WriteLine("Intoduce un nombre de usuario: ");
            string nameUser = Console.ReadLine();
            while (Usuario.NomUsuarios.Contains(nameUser))
            {
                Console.WriteLine("Lo siento este usuario no está disponible, intoduce un nombre de usuario: ");
                nameUser = Console.ReadLine();
            }

            Console.WriteLine("Intoduce tu nombre: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Intoduce tu apellido: ");
            string cog = Console.ReadLine();
            Console.WriteLine("Intoduce tu cotraseña: ");
            string password = Console.ReadLine();
            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(cog) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(nameUser))
            {
                throw new ArgumentException("No se puede crear el ususarion, los carácteres no pueden estar vacios");
            }
            else
            {
                Usuario.Usuarios.Add(new Usuario(nameUser, nom, cog, password));
            }
        }

        public static void acceder()
        {
            // ReSharper disable once StringLiteralTypo
            Console.WriteLine("Intoduce un nombre de usuario: ");
            string nameUser = Console.ReadLine();
            string password;
            if (Usuario.NomUsuarios.Contains(nameUser))
            {
                Console.WriteLine("Intoduce una contraseña: ");
                password = Console.ReadLine();
                int index = Usuario.NomUsuarios.IndexOf(nameUser);
                if (Usuario.Usuarios.ElementAt(index).Pasword == password)
                {
                    Console.WriteLine("Se ha iniciado seccion correctamente.");
                    userMenu(Usuario.Usuarios.ElementAt(index));
                }
            }
            else
            {
                Console.WriteLine("Este usuario no existe, error.");
            }
        }

        private static void userMenu(Usuario s)
        {
            Usuario user = s;
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("+(1) Listar mis videos    +");
                Console.WriteLine("+(2) Crear video          +");
                Console.WriteLine("+(3) Seleccionar un video +");
                Console.WriteLine("+(4) Ver fecha de registro+");
                Console.WriteLine("+(5) Salir del menu.      +");
                Console.WriteLine("+-------------------------+");
                string input = Console.ReadLine();
                switch (Int16.Parse(input))
                {
                    case 1:
                        foreach (var u in user.UserVideos)
                        {
                            Console.WriteLine(u.Titulo);
                        }

                        break;
                    case 2:
                        Console.WriteLine("Intoduce un titulo de video: ");
                        string nomVideo = Console.ReadLine();
                        Console.WriteLine("Intoduce una url: ");
                        string url = Console.ReadLine();
                        if (string.IsNullOrEmpty(nomVideo) || string.IsNullOrEmpty(url))
                        {
                            throw new ArgumentException(
                                "No se puede crear el ususarion, los carácteres no pueden estar vacios");
                        }
                        else
                        {
                            user.CreateVideo(url, nomVideo);
                        }

                        break;
                    case 3:
                        for (int i = 0; i < user.UserVideos.Count; i++)
                        {
                            Console.WriteLine(i + ") " + user.UserVideos[i].Titulo);
                        }

                        Console.WriteLine("Intoduce un nuvero de video: ");
                        string selectedVideo = Console.ReadLine();
                        if (Int16.Parse(selectedVideo) <= user.UserVideos.Count && Int16.Parse(selectedVideo) >= 0)
                        {
                            videoMenu(user.UserVideos[Int16.Parse(selectedVideo)]);
                        }
                        else
                        {
                            Console.WriteLine("Numero no es valido");
                        }

                        break;
                    case 4:
                        Console.WriteLine(user.FechaRegistro);
                        break;
                    case 5:
                        Console.WriteLine("Exit...");
                        execute = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }

        private static void videoMenu(Video selectVideo)
        {
            bool execute = true;
            while (execute)
            {
                Console.WriteLine("+-------------------------+");
                Console.WriteLine("+(1) Crear tag           +");
                Console.WriteLine("+(2) Ver tags del video      +");
                Console.WriteLine("+(3) Ver titulo del video +");
                Console.WriteLine("+(5) Salir del menu.      +");
                Console.WriteLine("+-------------------------+");
                string input = Console.ReadLine();
                switch (Int16.Parse(input))
                {
                    case 1:
                        Console.WriteLine("Intoduce un tag: ");
                        string tag = Console.ReadLine();
                        if (string.IsNullOrEmpty(tag))
                        {
                            throw new ArgumentException(
                                "No se puede crear el tag, los carácteres no pueden estar vacios");
                        }
                        else
                        {
                            selectVideo.CreateTag(tag);
                        }

                        break;
                    case 2:
                        foreach (var i in selectVideo.GroupOfTags)
                        {
                            Console.WriteLine(i);
                        }

                        break;
                    case 3:
                        Console.WriteLine(selectVideo.Titulo);
                        break;
                    case 5:
                        Console.WriteLine("Exit...");
                        execute = false;
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }
        }
    }
}