# Taxameter.Net
## En opgave i Strategy Pattern

### Opgave 1
Krone Taxa skal have udviklet et nyt stykke software til at beregne prisen på en taxa tur, og har bedt dig om hjælp. De har allerede et gammelt system til at vise data'en og interagere med systemet - altså skal de bare have hjælp til en lille del af systemet.

Deres prismodel er rimelig simpel: 8,50 kr/km + 6,25 kr/min + 39 kr

Implementér (dvs. færdiggør og udfyld de tomme metoder) klassen Taxameter, herunder Krone Taxas prismodel (BeregnPris).

Programmet kan køres fra Taxameter.KroneTaxa

### Opgave 2
KroneTaxa vil også gerne bruge systemet til deres store vogne. Her er prisen: 12 kr/km + 6,67 kr/min + 69 kr.

Ret klassen Taxameter så det kan bruges både til Krone Taxas store og små vogne, og tilføj det nødvendige i Taxameter, Taxameter.KroneTaxa og Taxameter.KroneTaxaStorVogn. Du kan køre programmet for deres store vogne fra Taxameter.KroneTaxaStorVogn.
(Hint: Strategy Pattern.)


### Opgave 3
KroneTaxas konkurrent CityBilen vil gerne købe dit system. De bruger samme brugergrænseflade, så det er lige til at sætte i deres biler. Dog er deres priser en smule anderledes: 4,50 kr pr. påbegyndt km + 7 kr pr. minut, og der er en minimumspris på 75 kr.

Ret Taxameter (hvis nødvendigt) så det også kan bruges til CityBilen og sæt CityBilens program op i Taxameter.CityBilen. 


### Opgave 4
KroneTaxas vil gerne være mere konkurrencedygtige på korte ture med normal vogn, og vil gerne ændre deres km pris til:
5 kr for den første km, derefter 9 kr/km. Dvs det koster 5 + 4,5 kr = 9,5 kr i kilometerpenge at køre 1,5 km.

Lav de nødvendige ændringer (som minimum bør Taxameter.KroneTaxa ændres, og alt efter hvordan resten af koden er skrevet skal det måske også ændres).


### Bonus opgave 1 (overkommelig)
Udvid Taxameter klassen med et firmanavn og en tekstbeskrivelse af prismodellen. Ret TaxameterTUI til så den også viser disse.
(Hint: start med at skrive kommentarer til alt koden i TaxameterTUI så du først forstå denne)


### Bonus opgave 2 (svær)
Elin Rejser har fået adgang til alle prismodellerne, og deres prismodel er altid den billigste af de andre modeller.

Implementer en pris strategi for Elin Rejser i Taxameter.ElinRejser

(Hint: man kan lave en strategi der indeholder flere strategier, beregner prisen for hver af dem og returnere den billigste pris)
(Hint: prøv at kigge på Composite Pattern og se om du kan bruge det til noget)