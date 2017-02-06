# INF-731   Programmation Orientée Objet   Hiver 2017

##  Pierre Prud'homme - Laboratoire 4

### Objectif du laboratoire :

* Création d’une classe comportant des constantes, des méthodes publiques et des propriétés
* Création de méthodes private et de méthodes public

### Description

Votre laboratoire consiste à implanter une classe qui représente une lampe à trois niveaux d’intensité d’éclairage. La lampe a deux attributs pour conserver son état :
* un attribut booléen estBranchée qui indique si la lampe est branchée sur une prise électrique
* un attribut entier intensité qui indique l’intensité d’éclairage de la lampe. Un entier à 0 signifie que la lampe est éteinte. Les entiers de 1 à 3 représentent respectivement les intensités faible, moyenne et forte.

Du point de vue de l’utilisateur, la classe présente les méthodes et les propriétés suivantes :

1.  Une propriété Etat de second ordre de type string qui ne présente que l’accesseur (volet get). Cette propriété permet à la lampe de demander son état afin de pouvoir l’afficher dans le programme client après une opération. Voir l’exemple plus loin.
2.  Une méthode Brancher() qui, lorsqu’elle est appelée sur un objet de classe Lampe, permet de ‘brancher’ la lampe à une prise électrique. Il va de soi que dans le cadre de cet exercice, ce branchement est virtuel.
3.  Une méthode Debrancher() qui, lorsqu’elle est appelée sur un objet de classe Lampe, permet de ‘débrancher’ la lampe de la prise électrique. Il va de soi que dans le cadre de cet exercice, ce débranchement est virtuel.
4.  Une méthode Toucher() qui, lorsqu’elle est appelée sur un objet de classe Lampe, augmente l’intensité de l’éclairage. Il faut se rappeler toutefois que ce type de lampe est cyclique, c’est-à-dire qu’après l’intensité la plus forte, le prochain toucher fera en sorte d’éteindre la lampe.
