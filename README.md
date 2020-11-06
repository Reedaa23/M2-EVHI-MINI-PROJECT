# M2-EVHI-MINITP

Ce repo contient l'implémentation d'un mini-projet individuel consitant à développer un jeu sur Unity.

## Description du projet

Le jeu doit posséder 5 niveaux :
<ul>
    <li>Niveau 1 : Entrer dans une salle, pousser un bouton. Le bouton ouvre une porte. Entrer niveau 2.</li>
    <li>Niveau 2 : Un ennemi est en mouvement devant la seconde porte. Il faut lui lancer des missiles pour le détruire. Puis pousser le bouton. Entrer niveau 3.</li>
    <li>Niveau 3 : Un ennemi poursuit l'utilisateur. Le bouton de sortie est dans un isoloir avec une porte ouverte. Il faut pousser le bouton. La porte se ferme. Entrer le niveau 4.</li>
    <li>Niveau 4 : L'environnement possède des trous. Si l'utilisateur tombe, il perd de la vie. Arriver jusqu'au bouton. Pousser le bouton. Entrer le niveau 5.</li>
    <li>Niveau 5 : L'utilisateur arrive devant des portes battantes. Il entre. Il n'y a pas de lumière mais un ajusteur de lumière rayonne. Il faut allumer la lumière. Quand la lumière est pleine, un ennemi avec une barre de vie se déplace. Il faut donc le toucher plusieurs fois. Si on le tue, on a gagné.</li>
</ul>

De plus, il faut :
<ul>
    <li>Un personnage (première ou troisième personne).</li>
    <li>L'utilisateur a une barre de vie.</li>
    <li>Des tokens de vie qui modifient la couleur de l'utilisateur lorsque ce dernier en prend.</li>
    <li>Des tokens d'invincibilité qui rendent l'utilisateur invulnérable aux ennemis pendant 10 secondes.</li>
    <li>On doit pouvoir quitter le jeu à tout instant.</li>
    <li>On doit utiliser le clavier et la souris pour se déplacer, ainsi que pour tirer.</li>
    <li>Les ennemis doivent changer de couleur quand on les touche. L'utilisateur aussi quand il prend un token.</li>
    <li>Les portes changent de couleur quand on les active.</li>
    <li>Si l'utilisateur perd, il peut choisir s'il veut rejouer ou non.</li>
    <li>Si l'utilisateur gagne, il est félicité puis le jeu se quitte.</li>
    <li>On doit pouvoir build le jeu pour pouvoir lancer un exécutable.</li>
</ul>

## Informations supplémentaires sur cette implémentation du jeu
<ul>
    <li>Les ennemis, n'ont pas d'armes. Ils attaquent donc uniquement au corps à corps. L'utilisateur quant à lui ne peut attaquer qu'en tirant avec une arme (quand celle-ci est disponible).</li>
    <li>Les munitions sont illimitées, et les armes ne nécessitent pas de rechargement.</li>
    <li>Il n'y a pas de réticule, il faut donc viser par rapport à la caméra.</li>
    <li>Lors</li>
    <li>Niveau 4 : L'environnement possède des trous. Si l'utilisateur tombe, il perd de la vie. Arriver jusqu'au bouton. Pousser le bouton. Entrer le niveau 5.</li>
    <li>Niveau 5 : L'utilisateur arrive devant des portes battantes. Il entre. Il n'y a pas de lumière mais un ajusteur de lumière rayonne. Il faut allumer la lumière. Quand la lumière est pleine, un ennemi avec une barre de vie se déplace. Il faut donc le toucher plusieurs fois. Si on le tue, on a gagné.</li>
</ul>

### Commandes
<ul>
    <li>Se déplacer : appuyer sur Z/Q/S/D ou les flèches directionnelles.</li>
    <li>Courir : maintenir la touche SHIFT.
    <li>Sauter : appuyer sur la touche ESPACE.</li>
    <li>Orienter la caméra : orienter la souris.
    <li>Interagir/Tirer : appuyer sur le clic gauche de la souris.</li>
    <li>Menu : appuyer sur la touche ECHAP.</li>
</ul>

Note : le jeu est volontairement simple à finir. Bon jeu !