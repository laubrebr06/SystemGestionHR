# SystemGestionHR
Test Technique pour le Poste de Tech Lead .NET/C#/Angular

API Web de Gestion des Congés des Employés

Il s'agit d'un projet simple d'API Web en .NET Core permettant aux employés de gérer leur solde de congés et de soumettre des demandes de congé. Le projet est développé avec Entity Framework et PostgreSQL.

Fonctionnalités
-	Soumettre une demande de congé 
-	Approuver ou rejeter une demande de congé

Getting Started.
To get started with this project, follow these steps:

Prérequis

•	.NET Core 5.0
•	PostgreSQL 13.4

Installation 

1.	Clonez le dépôt sur votre machine locale :
   
git clone https://github.com/laubrebr06/SystemGestionHR.git

3.	Accédez au répertoire du projet
   
cd SystemGestionHR

5.	Restaurez les dépendances du projet
   
dotnet restore

7.	Mettez à jour le schéma de la base de données
   
dotnet ef database update

9.	Exécutez l'application
    
dotnet run

Utilisation
Les points de terminaison (endpoints) de l'API peuvent être testés avec un outil comme Postman. Les endpoints suivants sont disponibles :

 ![image](https://github.com/user-attachments/assets/f8d9b202-f77b-4ce9-b584-2ce83ba805c0)

Contribuer
Les contributions sont les bienvenues ! Si vous souhaitez contribuer à ce projet, suivez ces étapes:
1.	Fork the repository Forkez le dépôt..
2.	Créez une nouvelle branche de fonctionnalité.
3.	Apportez vos modifications.
4.	Créez une pull request.
   
Licence
Ce projet est sous licence MIT – consultez le fichier LICENSE pour plus de détails.


