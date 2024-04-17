## Système de Gestion des Notes Étudiantes

Ce projet est une application console en C# conçue pour gérer les notes des étudiants dans un environnement éducatif. Elle offre une interface pour ajouter des étudiants et des cours, entrer et gérer les notes, ainsi qu'afficher les relevés de notes des étudiants.

### Fonctionnalités

- **Ajouter des étudiants**: Permet de créer des profils pour les étudiants avec des informations de base.
- **Ajouter des cours**: Permet d'enregistrer des informations détaillées sur les cours offerts.
- **Entrer des notes**: Permet d'attribuer des notes aux étudiants pour les différents cours.
- **Imprimer des relevés de notes**: Génère un relevé de notes pour chaque étudiant listant les cours et les notes obtenues.

### Processus de Développement

Le développement de cette application a suivi les étapes ci-dessous :

1. **Modélisation des Données**
   - Création de classes `Student`, `Course`, et `Grade` pour modéliser les données nécessaires.

2. **Logique d'Application**
   - Mise en place des méthodes pour l'ajout et la gestion des étudiants et des cours.
   - Implémentation d'un système de dictionnaire pour enregistrer et accéder aux notes des étudiants.

3. **Gestion des Erreurs**
   - Correction des erreurs de duplication lors de l'ajout de notes pour les étudiants.
   - Création d'une méthode `AddGrade` pour gérer correctement l'ajout de nouvelles notes.

4. **Tests et Validation**
   - Utilisation de données pré-remplies pour tester toutes les fonctionnalités.
   - Confirmation de la fiabilité des commandes du menu et de la cohérence des données.

### Installation

Aucune installation spécifique n'est nécessaire au-delà du [SDK .NET](https://dotnet.microsoft.com/download). Clonez le dépôt et ouvrez-le dans votre IDE préféré supportant C# (comme Visual Studio).

### Usage

Exécutez le fichier `Program.cs` pour lancer l'application. Suivez les instructions affichées pour naviguer dans le menu et accéder aux différentes fonctionnalités.
