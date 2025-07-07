using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class AtrybutyKlasy
{
    public int AtKId { get; set; }

    public byte? AtKWms { get; set; }

    public short AtKTyp { get; set; }

    public string AtKNazwa { get; set; } = null!;

    public string? AtKOpis { get; set; }

    public string? AtKFormat { get; set; }

    public byte? AtKZlisty { get; set; }

    public byte? AtKZamknieta { get; set; }

    public byte? AtKWymagany { get; set; }

    public byte? AtKControlling { get; set; }

    public byte? AtKAutomat { get; set; }

    public byte? AtKNieaktywny { get; set; }

    public string? AtKSql { get; set; }

    public byte? AtKHistoria { get; set; }

    public string? AtKDomyslna { get; set; }

    public string? AtKDomyslnaApi { get; set; }

    public short? AtKDomTyp { get; set; }

    public int? AtKDomFirma { get; set; }

    public int? AtKDomNumer { get; set; }

    public short? AtKDomLp { get; set; }

    public short? AtKDomApityp { get; set; }

    public int? AtKDomApiFirma { get; set; }

    public int? AtKDomApinumer { get; set; }

    public short? AtKDomApilp { get; set; }

    public string? AtKDomyslnaSql { get; set; }

    public string? AtKDomyslnaApisql { get; set; }

    public byte? AtKTypDom { get; set; }

    public byte? AtKTypDomApi { get; set; }

    public int? AtKCharSet { get; set; }

    public int? AtKOptimaId { get; set; }

    public byte? AtKOkresowe { get; set; }

    public byte? AtKWielowart { get; set; }

    public byte? AtKReadOnly { get; set; }

    public byte? AtKIZam { get; set; }

    public byte? AtKESklep { get; set; }

    public int? AtKCzasModyfikacji { get; set; }

    public byte? AtKMobmprawa { get; set; }

    public byte? AtKMobsprawa { get; set; }

    public byte? AtKMobzprawa { get; set; }

    public byte? AtKPracprawa { get; set; }

    public int? AtKOddZrdId { get; set; }

    public byte? AtKIMall { get; set; }

    public byte? AtKSynchronizowany { get; set; }

    public int? AtKDataDodania { get; set; }

    public byte? AtKMes { get; set; }

    public byte? AtKKseF { get; set; }

    public virtual ICollection<AtrKompletyLinki> AtrKompletyLinkis { get; set; } = new List<AtrKompletyLinki>();

    public virtual ICollection<Atrybuty> Atrybuties { get; set; } = new List<Atrybuty>();

    public virtual ICollection<AtrybutyWartosci> AtrybutyWartoscis { get; set; } = new List<AtrybutyWartosci>();

    public virtual ICollection<CrmraportyKolumny> CrmraportyKolumnies { get; set; } = new List<CrmraportyKolumny>();
}
