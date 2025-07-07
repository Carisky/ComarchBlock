using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class KatrybutyKlasy
{
    public int KakKakid { get; set; }

    public int KakKagid { get; set; }

    public string KakNazwa { get; set; } = null!;

    public byte KakTyp { get; set; }

    public string KakOpis { get; set; } = null!;

    public string KakFormat { get; set; } = null!;

    public string KakDomyslna { get; set; } = null!;

    public string KakSql { get; set; } = null!;

    public byte KakNieaktywny { get; set; }

    public byte KakSuma { get; set; }

    public byte KakMiesieczny { get; set; }

    public byte KakHistoria { get; set; }

    public byte KakSystemowy { get; set; }

    public virtual KatrybutyGrupy KakKag { get; set; } = null!;

    public virtual ICollection<Katrybuty> Katrybuties { get; set; } = new List<Katrybuty>();

    public virtual ICollection<KatrybutyKlasyElem> KatrybutyKlasyElems { get; set; } = new List<KatrybutyKlasyElem>();

    public virtual ICollection<KatrybutyKlasyZakaz> KatrybutyKlasyZakazs { get; set; } = new List<KatrybutyKlasyZakaz>();

    public virtual ICollection<KatrybutyKolumny> KatrybutyKolumnies { get; set; } = new List<KatrybutyKolumny>();

    public virtual ICollection<WidokiKolumny> WidokiKolumnies { get; set; } = new List<WidokiKolumny>();
}
