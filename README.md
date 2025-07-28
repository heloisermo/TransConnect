# 🚚 Application de gestion pour entreprise de transport – Projet C# Windows Forms

## 🧠 Présentation
Ce projet est une application de gestion développée en **C# (Windows Forms)** dans le cadre d’un projet d'étude. L’objectif était de modéliser une entreprise de transport, avec différents rôles (chef d’entreprise, salariés, chauffeurs, clients) disposant chacun d’un accès personnalisé à des fonctionnalités spécifiques via une interface interactive.

L'application repose sur un **diagramme de classes évolutif** construit dès le début du projet et enrichi tout au long du développement.

---

## 🖥️ Fonctionnalités principales

### 👔 Chef d’entreprise (M. Dupond)
- Vue globale de l’entreprise et des employés
- Statistiques d’activité
- Gestion des salariés (licenciement, recrutement)

### 👷 Salariés (hors chauffeurs)
- Vue sur leurs subordonnés
- Recrutement et licenciement

### 🚛 Chauffeurs
- Accès à leur emploi du temps
- Suivi des commandes passées et en cours
- Marquage des commandes comme livrées
- Possibilité de poser un congé

### 👤 Clients
- Inscription / Connexion
- Suivi des commandes
- Fidélité évolutive (pistes de réduction à terme)
- Passation de commandes via un formulaire intelligent

### 🧠 Formulaire interactif de commande
- Affichage dynamique selon le type de véhicule choisi :
  - **Voiture** : demande le nombre de passagers
  - **Camionnette** : demande l’usage
  - **Camion** : choix du modèle avec options spécifiques

---

## 🔧 Technologies et architecture
- C# (.NET)
- Windows Forms
- Stockage local via fichiers **JSON**
- Sérialisation / Désérialisation selon le type d’utilisateur

---

## ⚙️ Améliorations proposées
- Refactorisation des classes (ex. création d’une classe `GererSalarie`)
- Envoi automatique de **factures par email** lors des commandes
- Application de **remises** selon la fidélité client
- Interface graphique encore plus fluide et responsive

---

## 🧪 Difficultés rencontrées
- Gestion de forms interactifs complexes sous Windows Forms
- Sérialisation conditionnelle en JSON (types dérivés `Salarié`, `Chauffeur`)
- Gestion de l’arborescence des rôles avec logique métier différente

---

## 🧪 Test de l’application

Vous pouvez tester l’application selon les rôles suivants :

### 👤 Client
- Inscription libre ou connexion :  
  **Email :** 
  **Mot de passe :** 

### 👔 Chef d’entreprise
- **Email :** `mr.dupond@example.com`  
- **Mot de passe :** `123`

### 🚛 Chauffeur
- **Email :** `mr.romu@example.com`  
- **Mot de passe :** `123`

### 👷 Salarié
- **Email :** `mr.fetard@example.com`  
- **Mot de passe :** `123`

💡 *Attention à bien saisir des nombres dans les champs numériques (ex : numéro de téléphone, nombre de passagers, etc.).*


