## BaigiamasisDarbas_Kotryna
1. Test Scenario: Prekės elgesys krepšelyje:
    1. TC: Prekės įdėjimas į krepšelį per prekės puslapį:
        - Atidaromas psl.: https://www.ikea.lt/lt/products/miegamasis/ciuziniai-ir-ju-priedai/ciuziniai
        1. Priimami slapukai
        2. Spaudžiama ant pirmos prekės 
        3. Paimamas prekės kodas
        4. Spaudžiamas mygtukas „įdėti į pirkinių krepšelį“
        5. Atsidariusį langą uždarome spausdami „Tęsti apsipirkimą“
        6. Spaudžiamas krepšelio mygtukas
        - Tikrinama ar krepšelyje įdėtos prekės kodas atitinka pasirinktos prekės kodą.
    2. TC: Prekės ištrynimas iš krepšelio:
        - Atidaromas psl.: https://www.ikea.lt/lt/rooms/miegamasis/ciuziniai-ir-ju-priedai/ciuziniai
        1. Pavažiuojame žemyn kad matytųsi mygtukas „Greita peržiūra“
        2. Po pirma preke paspaudžiamas mygtukas „Greita peržiūra“
        3. Dešinėje atsiradusiame lange spausti „Įdėti į pirkinių krepšelį“
        4. Atsidariusiame lange spausti „Peržiūrėti pirkinių krepšelį“ mygtuką
        5. Po preke spausti mygtuką „Pašalinti“
        - Tikrinti ar puslapyje atsirado žinutė: Jūsų pirkinių krepšelis tuščias. Jūs neturite prekių pirkinių krepšelyje.
2. Test Scenario: Prekių filtravimas pagal kainą:
    1. TC: Maksimalios kainos mažinimas (Slider rankenėlės dešinėje stūmimas į kairę pusę):
        - Atidaromas psl.: https://www.ikea.lt/lt/rooms/vonia/vonios-vandens-maisytuvai
        1. Filtravimo juostoje renkamasi kategorija „Kaina“
        2. Slideryje dešinę rankenėlę stumiame į kairę pusę kol virš rankenėlės atsiranda skaičius 36
        3. Paspaudžiame Kaina filtravimo meniu kad meniu pasirinkimas būtų uždarytas
        4. Pavažiuojame žemyn kad matytųsi kainos produktų
        - Lyginamos pateiktų produktų kainas ar jos nėra didesnės nei 36eur
3. Test Scenario: Prisijungimo prie paskyros tikrinimas:
    1. Neteisingo el.pašto į el.pašto adreso laukelį įvedimo:
        - Atidaromas psl.: https://www.ikea.lt/lt/client
        1. El.pašto adresas laukelyje įvedamas neteisingas el.paštas: „kkk“
        2. Suvedamas slaptažodis
        3. Spaudžiamas mygtukas „Prisijungti“
        4. Palaukiame kol spalva pilnai užsikraus
        - Tikrinamas ar el.pašto laukelio kraštas tapo raudonas ir po laukeliu atsirado raudonas laukelis su užrašu: „Invalid email“
4. Test Scenario: Verslo klientų užklausos formos tikrinimas
    1. TC: Netinkamų simbolių įvedimas „Atstovo vardo“ laukelyje:
        - Atidaromas psl.: https://www.ikea.lt/lt/business/inquiry
        1. „Atstovo vardo“ laukelyje įvedami skaičiai: 456
        2. „Atstovo pavardė“ laukelyje įvedama: Pavarde
        3. „Įmonės pavadinimas“ laukelyje įvedama: Imone
        4. „El. pašto adresas“ laukelyje įvedame: imone@imone.com
        5. „Telefonas“ laukelyje įvedama: 1234567
        6. „Užklausa“ laukelyje įvedama: request
        7. Pažymimas langelis „Perskaičiau ir sutinku su privatumo politika ir verslo klientų pirkimo taisyklėmis ir įkainiais“ varnele
        8. Spaudžiamas „Pateikti“ mygtukas
        - Tikrinama ar po „Atstovo vardas“ laukeliu atsirado raudonas laukelis su užrašu: „Lauke negali būti įvesti simboliai '4', '5', '6'“ 
