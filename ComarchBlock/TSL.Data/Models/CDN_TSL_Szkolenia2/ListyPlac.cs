using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ListyPlac
{
    public int LplLplId { get; set; }

    public int LplDzlId { get; set; }

    public int LplDdfId { get; set; }

    public int LplTryb { get; set; }

    public int? LplParentId { get; set; }

    public string LplNumerString { get; set; } = null!;

    public int LplNumerNr { get; set; }

    public string? LplNumerPelny { get; set; }

    public DateTime LplDataOd { get; set; }

    public DateTime LplDataDo { get; set; }

    public short LplMiesiac { get; set; }

    public int LplRok { get; set; }

    public DateTime LplDataDok { get; set; }

    public string LplNazwa { get; set; } = null!;

    public DateTime? LplDataDanych { get; set; }

    public DateTime? LplZamknieta { get; set; }

    public int LplKategoria { get; set; }

    public int LplMiesiecyWstecz { get; set; }

    public byte LplZaksiegowana { get; set; }

    public int? LplDekId { get; set; }

    public int? LplKprid { get; set; }

    public int? LplPreDekId { get; set; }

    public string LplSymbol { get; set; } = null!;

    public byte LplOddelegowani { get; set; }

    public DateTime? LplDataKur { get; set; }

    public int LplKursNumer { get; set; }

    public decimal LplKursL { get; set; }

    public decimal LplKursM { get; set; }

    public string LplWaluta { get; set; } = null!;

    public byte LplTymczasowi { get; set; }

    public string LplOddelegowaniKraj { get; set; } = null!;

    public string LplWalutaDieta { get; set; } = null!;

    public DateTime? LplDataKurDieta { get; set; }

    public int LplKursNumerDieta { get; set; }

    public decimal LplKursLdieta { get; set; }

    public decimal LplKursMdieta { get; set; }

    public int? LplZakId { get; set; }

    public byte LplOddelegowaniUmowa { get; set; }

    public string? LplImportAppId { get; set; }

    public string? LplImportRowId { get; set; }

    public DateTime? LplTsExport { get; set; }

    public int? LplOpeZalId { get; set; }

    public int? LplStaZalId { get; set; }

    public DateTime LplTsZal { get; set; }

    public int? LplOpeModId { get; set; }

    public int? LplStaModId { get; set; }

    public DateTime LplTsMod { get; set; }

    public DateTime? LplTsImport { get; set; }

    public string LplOpeModKod { get; set; } = null!;

    public string LplOpeModNazwisko { get; set; } = null!;

    public string LplOpeZalKod { get; set; } = null!;

    public string LplOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<ListyPlac> InverseLplParent { get; set; } = new List<ListyPlac>();

    public virtual DokDefinicje LplDdf { get; set; } = null!;

    public virtual Dzialy LplDzl { get; set; } = null!;

    public virtual ListyPlac? LplParent { get; set; }

    public virtual Zaklady? LplZak { get; set; }

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();
}
