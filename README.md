# Op-Simulator

## **BERICHT AAN IEDEREEN DIE HIER NOG VERDER AAN WERKT:**
Omdat het project al gepushed was voordat de .gitignore in orde was, bleven bestanden van folders zoals `.vs/`, `bin/` en `obj/` 
binnenglippen in de remote repository.

Probeer dit op te lossen door eerst alles waar je aan bezig was ergens anders op te slaan, vervolgens zorg je dat jouw lokale repo gelijk wordt met de remote (verwijder alle gemaakte changes, geen commits maken).
NIET pushen tot dit opgelost is dus. Vervolgens check je of de .gitignore in de root van de repo staat, en dit moet de inhoud zijn:
> .vs/

> bin/

> obj/

Verder voer je volgend commando uit: `git rm -r --cached .`.

Dit is hoe ik het bij mij opgelost heb, maar het is echter mogelijk dat dit niet bij iedereen zal werken.
