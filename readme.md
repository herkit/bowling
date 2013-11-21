#Bowling score simulator.

Implementer en enkel score simulator for bowling, det er ingen input til programmet, output kan 

presenteres i konsollvinduet. 

Programmet må gjøre beregninger basert på følgende regler:

- Hvert “spill” Bowling inkluderer ti runder for bowleren.
- I hver runde så er det maksimum to forsøk på å slå ned de ti kjeglene. 
- Hvis man ikke får slått ned alle kjeglene på to forsøk så er totalscoren for den runden antallet kjegler som er slått ned. 
- Hvis alle kjeglene er blir slått overende på to forsøk så heter dette “spare” og scoren for den runden er ti + antallet kjegler slått ned i neste kast, (i den neste runden).
- Hvis alle kjeglene blir slått overende på første forsøk så er dette en “strike”, runden er ferdig og scoren for den runden er ti + antallet kjegler som blir slått overende de neste to kastene.
- Hvis spilleren får en “spare” eller en “strike” i siste, (dvs tiende), runde så får spilleren kaste henholdsvis en eller to bonus kuler som del av samme runde. Hvis alle kjeglene blir slått overende som ett resultat av dette så gjentas ikke prosessen. Bonus kastene brukes kun til å beregne score for den siste runde.
- Spillets totalscore er sammenlagt score for alle rundene.
- Etter hver runde så skal antallet kjegler som er slått overende + score for runden skrives ut på konsollvinduet.
- Etter at spillet er ferdig så skrives totalscoren ut på konsollvinuet.