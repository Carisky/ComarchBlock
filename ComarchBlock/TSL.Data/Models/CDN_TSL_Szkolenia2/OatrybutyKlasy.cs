using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class OatrybutyKlasy
{
    public int AtkAtkId { get; set; }

    public string AtkNazwa { get; set; } = null!;

    public byte AtkTyp { get; set; }

    public string AtkOpis { get; set; } = null!;

    public string AtkFormat { get; set; } = null!;

    public byte AtkZlisty { get; set; }

    public byte AtkZamknieta { get; set; }

    public byte AtkWymagany { get; set; }

    public byte AtkControlling { get; set; }

    public byte AtkAutomat { get; set; }

    public byte AtkNieaktywny { get; set; }

    public byte AtkHistoria { get; set; }

    public string AtkSql { get; set; } = null!;

    public string AtkDomyslna { get; set; } = null!;

    public string AtkDomyslnaApi { get; set; } = null!;

    public string AtkDomyslnaSql { get; set; } = null!;

    public string AtkDomyslnaApisql { get; set; } = null!;

    public byte AtkTypDom { get; set; }

    public byte AtkTypDomApi { get; set; }

    public int AtkCharSet { get; set; }

    public string AtkMaska { get; set; } = null!;

    public byte AtkSynchronizowanyXl { get; set; }

    public byte AtkSynchronizowanyAltum { get; set; }

    public string? AtkImportRowId { get; set; }

    public virtual ICollection<Oatrybuty> Oatrybuties { get; set; } = new List<Oatrybuty>();

    public virtual ICollection<OatrybutyGrupyLinki> OatrybutyGrupyLinkis { get; set; } = new List<OatrybutyGrupyLinki>();

    public virtual ICollection<OatrybutyKlasyElem> OatrybutyKlasyElems { get; set; } = new List<OatrybutyKlasyElem>();
}
