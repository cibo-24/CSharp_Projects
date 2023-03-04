using System.Collections.Generic;

class Program
{
    class Universite
    {
        List<Sinif> siniflar;
        List<Departman> departmanlar;
        List<Ofis> ofisler;
    }

    class Departman
    {
        List<Ofis> ofisler;
    }

    class Ofis
    {
        Calisan calisan;
    }

    class Calisan
    {
        string ad;
        string soyad;
        string unvan;
    }
    public class Sinif
    {

    }
}