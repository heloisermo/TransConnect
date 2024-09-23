using System.Collections.Generic;

namespace TransConnect_Stone_Romeo
{
    static class Program
    {
        /// <summary>
        ///  Point de départ de l'application, on y charge nos fichiers, ou on les crée s'ils n'existent pas déja
        /// </summary>
        [STAThread]
        static void Main()
        {
            string cheminFichier = "salaries.json";

            // Si le fichier n'existe pas on le crée
            if (!File.Exists(cheminFichier))
            {
                // Créer les adresses
                Adresse adresseDupond = new Adresse(1, "Rue des Dupond", "Paris", 75000);
                Adresse adresseFiesta = new Adresse(2, "Rue de la Fiesta", "Paris", 75000);
                Adresse adresseForge = new Adresse(3, "Rue de la Forge", "Paris", 75000);
                Adresse adresseFermi = new Adresse(4, "Rue de Fermi", "Paris", 75000);
                Adresse adresseFetard = new Adresse(5, "Rue des Fetard", "Paris", 75000);
                Adresse adresseRoyal = new Adresse(6, "Rue Royal", "Paris", 75000);
                Adresse adresseRomu = new Adresse(7, "Rue de Romu", "Paris", 75000);
                Adresse adresseRomi = new Adresse(8, "Rue de Romi", "Paris", 75000);
                Adresse adresseRoma = new Adresse(9, "Rue de Roma", "Paris", 75000);
                Adresse adressePrince = new Adresse(10, "Rue Prince", "Paris", 75000);
                Adresse adresseRome = new Adresse(11, "Rue de Rome", "Paris", 75000);
                Adresse adresseRimou = new Adresse(12, "Rue de Rimou", "Paris", 75000);
                Adresse adresseJoyeuse = new Adresse(13, "Rue Joyeuse", "Paris", 75000);
                Adresse adresseCouleur = new Adresse(14, "Rue de Couleur", "Paris", 75000);
                Adresse adresseToutleMonde = new Adresse(15, "Rue de ToutleMonde", "Paris", 75000);
                Adresse adresseGripSous = new Adresse(16, "Rue GripSous", "Paris", 75000);
                Adresse adressePicsou = new Adresse(17, "Rue de Picsou", "Paris", 75000);
                Adresse adresseFournier = new Adresse(18, "Rue Fournier", "Paris", 75000);
                Adresse adresseGautier = new Adresse(19, "Rue de Gautier", "Paris", 75000);
                Adresse adresseGrosSous = new Adresse(20, "Rue de GrosSous", "Paris", 75000);

                // Créer les salariés avec le mot de passe "123"
                Salarie mrDupond = new Salarie("Dupond", "Mr", new DateTime(1960, 1, 1), 1, adresseDupond, "mr.dupond@example.com", "0123456789", "123", "Directeur Général", 100000);
                Salarie mmeFiesta = new Salarie("Fiesta", "Mme", new DateTime(1970, 1, 1), 2, adresseFiesta, "mme.fiesta@example.com", "0123456789", "123", "Directrice Commerciale", 80000);
                Salarie mrForge = new Salarie("Forge", "Mr", new DateTime(1980, 1, 1), 3, adresseForge, "mr.forge@example.com", "0123456789", "123", "Commercial", 50000);
                Salarie mmeFermi = new Salarie("Fermi", "Mme", new DateTime(1985, 1, 1), 4, adresseFermi, "mme.fermi@example.com", "0123456789", "123", "Commerciale", 50000);
                Salarie mrFetard = new Salarie("Fetard", "Mr", new DateTime(1975, 1, 1), 5, adresseFetard, "mr.fetard@example.com", "0123456789", "123", "Directeur des opérations", 80000);
                Salarie mrRoyal = new Salarie("Royal", "Mr", new DateTime(1980, 1, 1), 6, adresseRoyal, "mr.royal@example.com", "0123456789", "123", "Chef Equipe", 60000);
                Chauffeur mrRomu = new Chauffeur("Romu", "Mr", new DateTime(1990, 1, 1), 7, adresseRomu, "mr.romu@example.com", "0123456789", "123", "Chauffeur", 30000);
                Chauffeur mmeRomi = new Chauffeur("Romi", "Mme", new DateTime(1990, 1, 1), 8, adresseRomi, "mme.romi@example.com", "0123456789", "123", "Chauffeur", 30000);            
                Chauffeur mrRoma = new Chauffeur("Roma", "Mr", new DateTime(1990, 1, 1), 9, adresseRoma, "mr.roma@example.com", "0123456789", "123", "Chauffeur", 30000);
                Salarie mmePrince = new Salarie("Prince", "Mme", new DateTime(1980, 1, 1), 10, adressePrince, "mme.prince@example.com", "0123456789", "123", "Chef d'Equipe", 60000);
                Chauffeur mmeRome = new Chauffeur("Rome", "Mme", new DateTime(1990, 1, 1), 11, adresseRome, "mme.rome@example.com", "0123456789", "123", "Chauffeur", 30000);
                Chauffeur mmeRimou = new Chauffeur("Rimou", "Mme", new DateTime(1990, 1, 1), 12, adresseRimou, "mme.rimou@example.com", "0123456789", "123", "Chauffeur", 30000);
                Salarie mmeJoyeuse = new Salarie("Joyeuse", "Mme", new DateTime(1970, 1, 1), 13, adresseJoyeuse, "mme.joyeuse@example.com", "0123456789", "123", "Directrice des RH", 80000);
                Salarie mmeCouleur = new Salarie("Couleur", "Mme", new DateTime(1975, 1, 1), 14, adresseCouleur, "mme.couleur@example.com", "0123456789", "123", "Formation", 60000);
                Salarie mmeToutleMonde = new Salarie("ToutleMonde", "Mme", new DateTime(1975, 1, 1), 15, adresseToutleMonde, "mme.toutlemonde@example.com", "0123456789", "123", "Contrats", 60000);
                Salarie mrGripSous = new Salarie("GripSous", "Mr", new DateTime(1965, 1, 1), 16, adresseGripSous, "mr.gripsous@example.com", "0123456789", "123", "Directeur Financier", 90000);
                Salarie mrPicsou = new Salarie("Picsou", "Mr", new DateTime(1960, 1, 1), 17, adressePicsou, "mr.picsou@example.com", "0123456789", "123", "Direction comptable", 80000);
                Salarie mmeFournier = new Salarie("Fournier", "Mme", new DateTime(1980, 1, 1), 18, adresseFournier, "mme.fournier@example.com", "0123456789", "123", "Comptable", 50000);
                Salarie mmeGautier = new Salarie("Gautier", "Mme", new DateTime(1980, 1, 1), 19, adresseGautier, "mme.gautier@example.com", "0123456789", "123", "Comptable", 50000);
                Salarie mrGrosSous = new Salarie("GrosSous", "Mr", new DateTime(1970, 1, 1), 20, adresseGrosSous, "mr.grossous@example.com", "0123456789", "123", "Controleur de Gestion", 70000);
                mrDupond.Subordonnes.Add(mmeFiesta);
                mrDupond.Subordonnes.Add(mmeJoyeuse);
                mrDupond.Subordonnes.Add(mrGripSous);
                mrDupond.Subordonnes.Add(mrFetard);

                mmeFiesta.Subordonnes.Add(mrForge);
                mmeFiesta.Subordonnes.Add(mmeFermi);

                mrFetard.Subordonnes.Add(mrRoyal);
                mrFetard.Subordonnes.Add(mmePrince);

                mrRoyal.Subordonnes.Add(mrRomu);
                mrRoyal.Subordonnes.Add(mmeRomi);
                mrRoyal.Subordonnes.Add(mrRoma);

                mmePrince.Subordonnes.Add(mmeRome);
                mmePrince.Subordonnes.Add(mmeRimou);

                mmeJoyeuse.Subordonnes.Add(mmeCouleur);
                mmeJoyeuse.Subordonnes.Add(mmeToutleMonde);

                mrGripSous.Subordonnes.Add(mrPicsou);
                mrGripSous.Subordonnes.Add(mrGrosSous);

                mrPicsou.Subordonnes.Add(mmeFournier);
                mrPicsou.Subordonnes.Add(mmeGautier);

                // Ajouter les salariés à la liste
                List<Salarie> salaries = new List<Salarie>
                {
                    mrDupond,
                    mmeFiesta,
                    mrForge,
                    mmeFermi,
                    mrFetard,
                    mrRoyal,
                    mrRomu,
                    mmeRomi,
                    mrRoma,
                    mmePrince,
                    mmeRome,
                    mmeRimou,
                    mmeJoyeuse,
                    mmeCouleur,
                    mmeToutleMonde,
                    mrGripSous,
                    mmeFournier,
                    mmeGautier,
                    mrGrosSous
                };

                // Enregistrer les salariés dans le fichier JSON
                JsonSerialisation.SauvegarderSalaries(salaries);
            }


            //On lance notre form de départ, le menu principal
            Application.Run(new FormMenuPrincipal());
            
        }
        

    }
}
