using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Wyposazenie
{
    public int WypWypId { get; set; }

    public int WypLp { get; set; }

    public int? WypDokumentId { get; set; }

    public int? WypDokumentTyp { get; set; }

    public string? WypDokumentNr { get; set; }

    public DateTime WypDataZak { get; set; }

    public string WypNumerKpr { get; set; } = null!;

    public string WypNazwa { get; set; } = null!;

    public int? WypKatId { get; set; }

    public string WypKategoria { get; set; } = null!;

    public string WypNrInwent { get; set; } = null!;

    public string WypKodKreskowy { get; set; } = null!;

    public int WypUniqueKodKreskowyBuster { get; set; }

    public decimal WypWartoscZakup { get; set; }

    public decimal? WypIlosc { get; set; }

    public string? WypJednostkaMiary { get; set; }

    public int? WypPrcId { get; set; }

    public string WypPrcNazwisko { get; set; } = null!;

    public DateTime? WypDataLikw { get; set; }

    public byte WypStan { get; set; }

    public string WypLikwidacja { get; set; } = null!;

    public string WypLikwDokument { get; set; } = null!;

    public string WypOpis { get; set; } = null!;

    public string? WypImportAppId { get; set; }

    public string? WypImportRowId { get; set; }

    public int? WypOpeZalId { get; set; }

    public int? WypStaZalId { get; set; }

    public DateTime WypTsZal { get; set; }

    public int? WypOpeModId { get; set; }

    public int? WypStaModId { get; set; }

    public DateTime WypTsMod { get; set; }

    public string WypOpeModKod { get; set; } = null!;

    public string WypOpeModNazwisko { get; set; } = null!;

    public string WypOpeZalKod { get; set; } = null!;

    public string WypOpeZalNazwisko { get; set; } = null!;

    public virtual Kategorie? WypKat { get; set; }

    public virtual PracKod? WypPrc { get; set; }

    public virtual ICollection<WyposazenieMiejscaUzytkowanium> WyposazenieMiejscaUzytkowania { get; set; } = new List<WyposazenieMiejscaUzytkowanium>();

    public virtual ICollection<WyposazenieOsobyOdpowiedzialne> WyposazenieOsobyOdpowiedzialnes { get; set; } = new List<WyposazenieOsobyOdpowiedzialne>();

    public virtual ICollection<WyposazeniePowiazanium> WyposazeniePowiazania { get; set; } = new List<WyposazeniePowiazanium>();
}
