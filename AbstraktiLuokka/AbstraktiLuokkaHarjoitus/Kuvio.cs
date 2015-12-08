namespace AbstraktiLuokkaHarjoitus
{
    // Abstraktia luokkan käyttö liittyy usein periytymiseen ja 
    // polyformismin hyödyntämiseen. Luokka voidaan merkitä abstraktiksi
    // esimerkiksi silloin kun tahdotaan tarjota samantyyppisiä toimintoja
    // periytyville luokille mutta niiden toteutukset ovat erilaisia.
    // Toteutus siis riippuu periytyvän luokan käytöstä. 
    //
    // Abstrakteilla luokilla
    // voidaan tarjota myös jonkinlainen pohja (template) periytyville luokille,
    // joilla on samankaltaisia toimintoja.

    // Abstraktin luokan ominaisuuksia:
    //
    // - luokan luominen on estetty (ei voi luoda new -sanalla)
    // - luokka voi sisältää abstrakteja metodeja
    // - periytyvän luokan on annettava toteutus abstrakteille metodeille
    // - abstract -sanalla ilmaistaan, että metodilla ei ole toteutusta

    public abstract class Kuvio
    {
        // Abstraktin metodin ominaisuuksia:
        // 
        // - abstrakti metodi voi sijaita vain abstraktissa luokassa
        // - metodilla ei ole lohkoa, koska sillä ei ole toteutusta
        // - periytyvän luokan on toteutettava metodi override -komennon avulla
        // - metodeissa ei voi käyttää static tai virtual -komentoja
        public abstract double LaskeAla();
        
        public string KuvionNimi()
        {
            return "Kuvio";
        }
    }
}
