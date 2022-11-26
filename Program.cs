namespace exo_POO_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void programmeFacture()
            {
                Facture facture = new Facture(0.14975);
                int choix = 1;

                while (choix < 3 && choix > 0)
                {
                    Console.Clear();
                    Console.WriteLine("1. Entrer item\n 2. Imprimer facture\n 3. Quitter");
                    // Quand on rentre autre chose qu'un int avec int.TryParse
                    // La méthode retourne faux, sinon vrai
                    if (!int.TryParse(Console.ReadLine(), out choix))
                    {
                        Console.WriteLine("Recommencer l'opération, choix invalide");
                    }

                    if (choix == 1)
                    {
                        string nom = "";
                        double prix = 0.0;
                        Console.WriteLine("Entrer le nom de l'item");
                        nom = Console.ReadLine();
                        Console.WriteLine("Entrer le prix de l'item");
                        double.TryParse(Console.ReadLine(), out prix);

                        facture.ajouterItem(nom, prix);
                    }
                    else if (choix == 2)
                    {
                        facture.afficherFacture();
                    }
                    else if (choix == 3)
                    {
                        // quand je veux quitter mettre un nombre qui fait arrêter la boucle
                        // dans choix
                        choix = 0;
                    }
                    else
                    {
                        // pour ne pas sortir de la boucle quand le choix n'est pas bon
                        // remettre choix à 1
                        choix = 1;
                    }

                    Console.WriteLine("Appuyer sur une touche pour continuer");
                    Console.ReadKey();
                }
            }
        }
    }
}