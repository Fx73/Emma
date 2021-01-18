<h1>Emma</h1>

<h2>Présentation</h2>
 Emma est une petite application utilitaire, pensée pour être la plus légère possible.
 
 Son application principale est un service de messagerie instantané, intégrée aux pop-ups windows. Une partie serveur, down pour l'instant, permet de relayer les messages.
 
 D'autres fonctionnalités sont disponibles :
 - Emma peut vous envoyer des compliments ou autres messages préenregistrés de temps en temps, pour vous mettre en forme. 
 - Emma peut se réveiller au démarrage, et peut programmer l'arret de l'ordinateur
 - Emma peut jouer :
    - Morpion (local/reseau)
    - Pendu
    - Excel Escape
    
 
<h2>Projet</h2>

L'objectif du projet etait surtout de décourvir le .Net, et de répondre à un besoin principal, à savoir envoyer un message aisement d'un poste à un autre, avec une application plus légère qu'une messagerie standard.

L'ensemble à été réalisé en Vb.Net sous Visual Studio, qui permet de créer l'interface presque sans toucher au XML.
Le serveur est en python, et se trouve dans les sources.

<h2>Compilation</h2>

<i>Il s'agit d'une application .Net, donc compilable et executable sous Windows.</i>
Telecharger le projet et le décompresser

Ouvrir l'invite de commande et se placer dans le repertoire de projet (où doit se trouver "Emma.sln")

Executer : C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild "Emma.sln" /p:Configuration=Release
    
Depot Azure Original :
https://dev.azure.com/CochonCorp/Emma
