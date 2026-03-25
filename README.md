# 🎓 SenSoutenance - Système de Gestion des Soutenances

Application de bureau Windows Forms pour la gestion complète des soutenances académiques, développée en C# avec Entity Framework et MySQL.

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8-blue)
![C#](https://img.shields.io/badge/C%23-10.0-purple)
![MySQL](https://img.shields.io/badge/MySQL-8.0-orange)
![Entity Framework](https://img.shields.io/badge/Entity%20Framework-6.5.1-green)

## 📋 Table des matières

- [Aperçu](#-aperçu)
- [Fonctionnalités](#-fonctionnalités)
- [Technologies utilisées](#-technologies-utilisées)
- [Prérequis](#-prérequis)
- [Installation](#-installation)
- [Configuration](#-configuration)
- [Structure du projet](#-structure-du-projet)
- [Captures d'écran](#-captures-décran)
- [Utilisation](#-utilisation)
- [Contributeurs](#-contributeurs)
- [Licence](#-licence)

## 🎯 Aperçu

**SenSoutenance** est une application de gestion académique conçue pour faciliter l'organisation et le suivi des soutenances de mémoires. Elle offre une interface moderne et intuitive pour gérer les étudiants, les professeurs, les départements, les sessions académiques et les soutenances.

### Objectifs du projet

- ✅ Centraliser la gestion des soutenances académiques
- ✅ Faciliter le suivi des mémoires et des candidats
- ✅ Automatiser la planification des sessions de soutenance
- ✅ Fournir une interface utilisateur moderne et professionnelle
- ✅ Assurer la sécurité des données avec authentification

## ✨ Fonctionnalités

### 🔐 Gestion des utilisateurs
- Authentification sécurisée avec cryptage des mots de passe
- Gestion des comptes administrateurs
- Contrôle d'accès basé sur les rôles

### 👥 Gestion des entités
- **Candidats** : Gestion complète des étudiants candidats
- **Professeurs** : Base de données des encadreurs et jurys
- **Départements** : Organisation par département académique
- **Chefs de département** : Attribution des responsables

### 📚 Gestion académique
- **Années académiques** : Suivi des périodes scolaires
- **Sessions** : Organisation des sessions de soutenance
- **Mémoires** : Enregistrement des sujets et documents
- **Soutenances** : Planification et résultats des soutenances

### 🎨 Interface moderne
- Design professionnel avec palette de couleurs vives
- DataGridView stylisés avec lignes alternées
- Boutons colorés et intuitifs (Ajouter, Modifier, Supprimer)
- Police Segoe UI pour une meilleure lisibilité
- Formulaires MDI pour une navigation fluide

## 🛠️ Technologies utilisées

### Framework et langages
- **C# 10.0** - Langage de programmation principal
- **.NET Framework 4.8** - Framework d'application
- **Windows Forms** - Interface graphique utilisateur

### Base de données
- **MySQL 9.5.0** - Système de gestion de base de données
- **Entity Framework 6.5.1** - ORM (Object-Relational Mapping)
- **MySQL.Data.EntityFramework** - Provider EF pour MySQL

### Packages NuGet
```xml
- EntityFramework (6.5.1)
- MySql.Data (9.5.0)
- MySql.Data.EntityFramework (9.5.0)
- BouncyCastle.Cryptography (2.6.2)
- System.Configuration.ConfigurationManager (8.0.0)
```

## 📦 Prérequis

Avant d'installer l'application, assurez-vous d'avoir :

- ✅ **Windows 10/11** ou supérieur
- ✅ **.NET Framework 4.8** ou supérieur
- ✅ **Visual Studio 2022** (pour le développement)
- ✅ **MySQL Server 8.0** ou supérieur
- ✅ **MySQL Workbench** (optionnel, pour la gestion de la base de données)

## 🚀 Installation

### 1. Cloner le dépôt

```bash
git clone https://github.com/Madieyeee/SenSoutenanceApp.git
cd SenSoutenanceApp
```

### 2. Restaurer les packages NuGet

Ouvrez le projet dans Visual Studio et restaurez automatiquement les packages :

```bash
# Ou via la ligne de commande
nuget restore SenSoutenance.slnx
```

### 3. Configurer la base de données

Créez une base de données MySQL :

```sql
CREATE DATABASE SenSoutenanceDB;
```

### 4. Configurer la chaîne de connexion

Modifiez le fichier `App.config` avec vos paramètres MySQL :

```xml
<connectionStrings>
  <add name="BdSenSoutenanceContext" 
       connectionString="server=localhost;port=3306;database=SenSoutenanceDB;uid=root;password=votre_mot_de_passe" 
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

### 5. Appliquer les migrations

Ouvrez la Console du Gestionnaire de package dans Visual Studio :

```powershell
Update-Database
```

### 6. Compiler et exécuter

Appuyez sur **F5** ou cliquez sur **Démarrer** dans Visual Studio.

## ⚙️ Configuration

### Chaîne de connexion

La chaîne de connexion se trouve dans `App.config` :

```xml
<connectionStrings>
  <add name="BdSenSoutenanceContext" 
       connectionString="server=localhost;port=3306;database=SenSoutenanceDB;uid=root;password=yourpassword" 
       providerName="MySql.Data.MySqlClient" />
</connectionStrings>
```

### Paramètres Entity Framework

```xml
<entityFramework>
  <defaultConnectionFactory type="MySql.Data.EntityFramework.MySqlConnectionFactory, MySql.Data.EntityFramework" />
  <providers>
    <provider invariantName="MySql.Data.MySqlClient" 
              type="MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.EntityFramework" />
  </providers>
</entityFramework>
```

## 📁 Structure du projet

```
SenSoutenance/
├── APPSenSoutenance/
│   ├── Models/                    # Modèles de données (Entities)
│   │   ├── Admin.cs
│   │   ├── Utilisateur.cs
│   │   ├── Candidat.cs
│   │   ├── Professeur.cs
│   │   ├── Departement.cs
│   │   ├── ChefDepartement.cs
│   │   ├── AnneeAcademique.cs
│   │   ├── Session.cs
│   │   ├── Memoire.cs
│   │   ├── Soutenance.cs
│   │   └── BdSenSoutenanceContext.cs
│   │
│   ├── Views/                     # Interfaces utilisateur
│   │   ├── Account/
│   │   │   └── frmUtilisateur.cs
│   │   └── Parametre/
│   │       ├── frmAnneeAcademique.cs
│   │       ├── frmSession.cs
│   │       ├── frmDepartement.cs
│   │       ├── frmChefDepartement.cs
│   │       ├── frmProfesseur.cs
│   │       ├── frmMemoire.cs
│   │       └── frmSoutenance.cs
│   │
│   ├── Shared/                    # Utilitaires partagés
│   │   ├── Crypted.cs            # Cryptage des mots de passe
│   │   └── FillerList.cs         # Remplissage des listes
│   │
│   ├── Migrations/                # Migrations Entity Framework
│   │   └── Configuration.cs
│   │
│   ├── Form1.cs                   # Formulaire de connexion
│   ├── frmMDI.cs                  # Formulaire principal MDI
│   ├── Program.cs                 # Point d'entrée
│   ├── App.config                 # Configuration
│   └── packages.config            # Packages NuGet
│
├── .gitignore                     # Fichiers à ignorer par Git
├── README.md                      # Ce fichier
└── SenSoutenance.slnx            # Solution Visual Studio
```

## 🖼️ Captures d'écran

### Formulaire de connexion
Interface moderne avec authentification sécurisée.

### Tableau de bord principal
Menu MDI avec accès à tous les modules de gestion.

### Gestion des soutenances
DataGridView professionnel avec en-têtes colorés et lignes alternées.

### Gestion des mémoires
Formulaire complet pour l'enregistrement des mémoires avec upload de documents.

## 📖 Utilisation

### Première connexion

1. Lancez l'application
2. Utilisez l'un des comptes par défaut créés automatiquement :

#### 👤 Comptes par défaut

**Administrateur**
- **Email** : `admin@sensoutenance.sn`
- **Mot de passe** : `admin123`
- **Accès** : Complet (gestion des utilisateurs, paramètres, soutenances)

**Candidat**
- **Email** : `candidat@sensoutenance.sn`
- **Mot de passe** : `candidat123`
- **Matricule** : `2021-001`
- **Accès** : Limité (consultation des soutenances)

> ⚠️ **Important** : Changez ces mots de passe après la première connexion pour des raisons de sécurité.

3. Accédez au tableau de bord principal

### Gestion des soutenances

1. **Paramétrage initial** :
   - Créer les années académiques
   - Définir les sessions
   - Ajouter les départements
   - Enregistrer les professeurs

2. **Enregistrement des mémoires** :
   - Sélectionner l'année académique et la session
   - Saisir le sujet du mémoire
   - Joindre le document PDF

3. **Planification des soutenances** :
   - Choisir le mémoire
   - Définir la date et le lieu
   - Enregistrer les résultats et mentions

### Raccourcis clavier

- **Alt + A** : Ajouter un nouvel élément
- **Alt + M** : Modifier l'élément sélectionné
- **Alt + S** : Supprimer l'élément sélectionné

## 👨‍💻 Contributeurs

- **Madieye Anne** - Développeur principal - [@Madieyeee](https://github.com/Madieyeee)

## 📄 Licence

Ce projet est développé dans un cadre académique. Tous droits réservés.

## 🤝 Contribution

Les contributions sont les bienvenues ! Pour contribuer :

1. Forkez le projet
2. Créez une branche pour votre fonctionnalité (`git checkout -b feature/AmazingFeature`)
3. Committez vos changements (`git commit -m 'Add some AmazingFeature'`)
4. Poussez vers la branche (`git push origin feature/AmazingFeature`)
5. Ouvrez une Pull Request

## 📞 Contact

Pour toute question ou suggestion :

- GitHub : [@Madieyeee](https://github.com/Madieyeee)
- Email : madieyepro@gmail.com

## 🙏 Remerciements

- Professeur de C# pour les conseils et l'encadrement
- Communauté Entity Framework pour la documentation
- MySQL pour le système de base de données robuste

---

⭐ **Si ce projet vous a été utile, n'hésitez pas à lui donner une étoile !** ⭐

Développé pour la gestion académique
