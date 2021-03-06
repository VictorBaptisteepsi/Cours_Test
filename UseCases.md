SCOPE Chiffre d'Affaires

	SCOPE Serveur

		ÉTANT DONNÉ un nouveau serveur
		QUAND on récupére son chiffre d'affaires
		ALORS celui-ci est à 0

		ÉTANT DONNÉ un nouveau serveur
		QUAND il prend une commande
		ALORS son chiffre d'affaires est le montant de celle-ci

		ÉTANT DONNÉ un serveur ayant déjà pris une commande
		QUAND il prend une nouvelle commande
		ALORS son chiffre d'affaires est la somme des deux commandes

	SCOPE Restaurant
	
		ÉTANT DONNÉ un restaurant ayant X serveurs
		QUAND tous les serveurs prennent une commande d'un montant Y
		ALORS le chiffre d'affaires de la franchise est X * Y
		CAS(X = 0; X = 1; X = 2; X = 100)
		CAS(Y = 1.0)

	SCOPE Franchise
	
		ÉTANT DONNÉ une franchise ayant X restaurants de Y serveurs chacuns
		QUAND tous les serveurs prennent une commande d'un montant Z
		ALORS le chiffre d'affaires de la franchise est X * Y * Z
		CAS(X = 0; X = 1; X = 2; X = 1000)
		CAS(Y = 0; Y = 1; Y = 2; Y = 1000)
		CAS(Z = 1.0)

SCOPE DebutService

	ÉTANT DONNE un restaurant ayant 3 tables
	QUAND le service commence
	ALORS elles sont toutes affectées au Maître d'Hôtel

	ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
	QUAND le service débute
	ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel

	ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
	QUAND le service débute
	ALORS il n'est pas possible de modifier le serveur affecté à la table

	ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
	ET ayant débuté son service
	QUAND le service se termine
	ET qu'une table est affectée à un serveur
	ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel

SCOPE Epinglage

	ÉTANT DONNE un serveur ayant pris une commande
	QUAND il la déclare comme non-payée
	ALORS cette commande est marquée comme épinglée

	ÉTANT DONNE un serveur ayant épinglé une commande
	QUAND elle date d'il y a au moins 15 jours
	ALORS cette commande est marquée comme à transmettre gendarmerie

	ÉTANT DONNE une commande à transmettre gendarmerie
	QUAND on consulte la liste des commandes à transmettre du restaurant
	ALORS elle y figure

	ÉTANT DONNE une commande à transmettre gendarmerie
	QUAND elle est marquée comme transmise à la gendarmerie
	ALORS elle ne figure plus dans la liste des commandes à transmettre du restaurant

SCOPE Installation

	ÉTANT DONNE une table dans un restaurant ayant débuté son service
	QUAND un client est affecté à une table
	ALORS cette table n'est plus sur la liste des tables libres du restaurant

	ÉTANT DONNE une table occupée par un client
	QUAND la table est libérée
	ALORS cette table appraît sur la liste des tables libres du restaurant

SCOPE Menus

	ÉTANT DONNE un restaurant ayant le statut de filiale d'une franchise
	ET une franchise définissant un menu ayant un plat
	QUAND la franchise modifie le prix du plat
	ALORS le prix du plat dans le menu du restaurant est celui défini par la franchise

	ÉTANT DONNE un restaurant appartenant à une franchise et définissant un menu ayant un plat
	ET une franchise définissant un menu ayant le même plat
	QUAND la franchise modifie le prix du plat
	ALORS le prix du plat dans le menu du restaurant reste inchangé

	ÉTANT DONNE un restaurant appartenant à une franchise et définissant un menu ayant un plat
	QUAND la franchise ajoute un nouveau plat
	ALORS la carte du restaurant propose le premier plat au prix du restaurant et le second au prix de la franchise

SCOPE Commande

	ÉTANT DONNE un serveur dans un restaurant
	QUAND il prend une commande de nourriture
	ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant

	ÉTANT DONNE un serveur dans un restaurant
	QUAND il prend une commande de boissons
	ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant
