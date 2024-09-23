Pour effectuer ce projet, nous avons commencé par dessiner un diagramme des 
classes qui étaient imposées par la consigne. Ce diagramme a bien sûr évolué tout au 
long de notre cheminement, pour finalement ressembler à ceci :
Nous avons pris le choix de faire une application Windows Form, permettant 
d’avoir une application non seulement interactive, qui selon la personne connectée, 
offre des services différents.
- M. Dupond, chef d’entreprise, en se connectant, a une vision sur l’ensemble de 
l’entreprise, ses subordonnés, les statistiques, et peut également licencier, ou recruter, 
depuis son profil, n’importe lequel de ses subordonnés.
- Les salariés de M. Dupond, mais pas les chauffeurs, peuvent également voir leurs 
subordonnés, les licencier, ou en recruter.
- Les chauffeurs ont eux, accès à toutes leurs commandes, passées ou en cours, leur 
emploi du temps, ils peuvent marquer une commande comme « livrée », ce qui 
apparaîtra bien évidemment sur le profil du client concerné par cette commande. Enfin, 
il peut en un clic, poser un congé pour une date donnée.
- Les clients peuvent s’inscrire ou se connecter, et leur profil regroupe leur fidélité, leurs 
commandes avec leurs détails, et ils peuvent passer des commandes depuis un autre 
form.
Le form qui permet de passer des commandes est un form interactif, qui affiche des
fonctionnalités différentes en fonction du véhicule choisi : choisir une voiture va 
demander le nombre de passagers, choisir une camionnette va demander un usage, et 
choisir un camion va proposer plusieurs choix de camions, eux même affichant des 
fonctionnalités différentes selon le camion choisi.
Les améliorations que nous proposons sont les suivantes :
Tout d’abord nous avons proposé une application complète, rendant l’interface 
utilisateur ainsi que l’interface salariée/administrateur plus agréable et fonctionnelle. 
Nous avons créé des forms différents selon la personne connectée, et nous proposons 
des fonctionnalités adaptées.
De plus, un chauffeur peut poser un congé depuis son profil, et avoir une vision sur son 
agenda.
Un client a un statut de fidélité, qui évolue selon son nombre de commandes, qui 
pourraient par la suite impacter le prix de ses commandes, en y appliquant une remise.
Les difficultés rencontrées sont les suivantes :
Tout d’abord nous avons d’emblée décidé de faire une application, ce qui a été la source 
de nombreux problèmes, notamment lorsque nous devions faire des forms interactifs. 
Ce n’est pas tant la complexité de la chose qui posait problème, mais surtout le temps.
De plus, nous avons sauvegarder nos fichiers sur notre ordinateur sous le format json. 
Cela nous a handicapé notamment lorsque nous enregistrions des salariés. En effet, ils 
peuvent être de type Salarié, ou Chauffeur ce qui fait qu’ils sont sérialisés et 
désérialisés avec des constructeurs différents. Il a donc fallu gérer les différences de 
types.
Les améliorations possibles pour ce projet pourraient être d’essayer de créer plus de 
classes afin d’en décharger certaines : par exemple, pourquoi pas ajouter une classe 
« GererSalarie », qui s’occupe de licencier, recruter, charger les salariés.
On pourrait également envoyer une facture sur l’email des clients lorsqu’ils passent une 
commande.
Indication pour tester notre solution :
Vous pouvez avoir accès aux différentes implémentations en fonction du rôle de la 
personne connectée
Tout d’abord vous pouvez vous inscrire en tant que client, attention à bien mettre des 
numéros dans les champs qui attendent des numéros, ou bien vous connecter sur mon 
profil : heloise.romeo@gmail.com mdp : 1
Vous pouvez vous connecter en tant que chef d’entreprise : mr.dupond@example.com
mdp : 123
En tant que chauffeur : mr.romu@example.com mdp :123 (ou n’importe quel chauffeur
de l’entreprise avec le même formatage pour le mail et même mdp)
En tant qu’un salarié : mr.fetard@example.com mdp :123
