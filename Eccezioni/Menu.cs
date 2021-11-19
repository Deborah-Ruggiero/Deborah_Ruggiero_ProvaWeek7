using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    static class Menu
    {
        private static DbManager user = new DbManager();


        static public void Start()
        {

            Console.WriteLine("---  Database Users ---");
            bool continua = true;
            while (continua)

                while (continua)

                {
                    Console.WriteLine("\n------ Menu ------");
                    //Console.WriteLine("Premi 1 - Visualizza tutti gli utenti");
                    Console.WriteLine("Premi 2 - Visualizza utente per nome");

                    Console.WriteLine("Premi 0 - Exit");


                    int scelta;
                    do
                    {
                        Console.Write("\nFai la tua scelta: ");
                    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 2));

                    switch (scelta)
                    {
                        case 1:
                            VisualizzaUsers();
                            break;
                        case 2:
                            //VisualizzaUsersPerNome();
                            break;
                        case 0:
                            return;
                    }
                }
        }

        //private static void VisualizzaUsersPerNome() //TODO
        //{
        //    Console.WriteLine("Inserisci nome utente da ricercare");
        //    string nomeDaRicercare = Console.ReadLine();
        //    List<User> users = user.GetByName(nomeDaRicercare);
        //    foreach (var item in users)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    throw new NotImplementedException("Utente inesistente!");
        //}



        private static void VisualizzaUsers()
        {
            List<User> users = user.GetAll();
            foreach (var item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}


