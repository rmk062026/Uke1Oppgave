# HTTP Status Searcher

## Beskrivelse

Programmet lar brukeren søke opp HTTP-statuskoder. Programmet viser den valgte HTTP-statuskoden og en beskrivelse av hva den betyr.
Akkurat nå er det disse kodene som er lagt til: 400, 401, 403, 404, 408 og 500.

## Hvordan fungerer programmet

- Brukeren skriver inn HTTP-statuskode.
- Programmet bruker TryParse() for å kontrollere at input er et gyldig tall.
- Hvis input er gyldig, går programmet videre til en switch.
- switch velger riktig tittel og beskrivelse basert på koden bruker legger inn.
- Hvis brukeren skriver inn et gyldig tall som ikke finnes i programmet, håndteres dette av default, som viser en feilmelding.
- Informasjonen lagres i variabler før det skrives ut til konsollen.
- Hvis brukeren skriver noe annet enn tall så vil det komme en feilmelding gjennom else-delen av en if/else.

## Testet verdier

| Input | Forventet                 | Resultat |
| ----- | ------------------------- | -------- |
| 400   | 400 Bad Request           | OK       |
| 401   | 401 Unauthorized          | OK       |
| 403   | 403 Forbidden             | OK       |
| 404   | 404 Not Found             | OK       |
| 408   | 408 Request Timeout       | OK       |
| 500   | 500 Internal Server Error | OK       |
| 999   | Code not found            | OK       |
| ABC   | Type just numbers...      | OK       |
