using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class FaCyklNag
{
    public int FcnFcNid { get; set; }

    public string FcnKod { get; set; } = null!;

    public string FcnNazwa { get; set; } = null!;

    public DateTime? FcnDataOstatniej { get; set; }

    public byte FcnNieaktywny { get; set; }

    public byte FcnOkresCyklu { get; set; }

    public byte FcnDzienTygodnia { get; set; }

    public byte? FcnDzienMiesiaca { get; set; }

    public byte? FcnPowtarzajCo { get; set; }

    public DateTime? FcnPowtarzajCoData { get; set; }

    public int? FcnTypDokumentu { get; set; }

    public int? FcnDdfId { get; set; }

    public int? FcnNumerNr { get; set; }

    public string? FcnNumerString { get; set; }

    public byte FcnDoBufora { get; set; }

    public string FcnWaluta { get; set; } = null!;

    public int FcnKursNumer { get; set; }

    public decimal FcnKursL { get; set; }

    public decimal FcnKursM { get; set; }

    public DateTime FcnDataKur { get; set; }

    public int? FcnMagId { get; set; }

    public byte FcnTypNb { get; set; }

    public byte FcnDataDokTyp { get; set; }

    public DateTime FcnDataDok { get; set; }

    public byte? FcnDataDokDzienMiesiaca { get; set; }

    public byte FcnDataSprzedazyTyp { get; set; }

    public DateTime FcnDataSprzedazy { get; set; }

    public byte? FcnDataSprzedazyDzienMiesiaca { get; set; }

    public byte FcnFplTyp { get; set; }

    public int? FcnFplId { get; set; }

    public byte FcnTerminPlatTyp { get; set; }

    public short? FcnTerminPlatDzien { get; set; }

    public byte FcnKategoriaTyp { get; set; }

    public int? FcnKatId { get; set; }

    public string FcnKategoria { get; set; } = null!;

    public string FcnUwagi { get; set; } = null!;

    public DateTime? FcnDataKolejnegoGen { get; set; }

    public byte FcnPrzypomnienie { get; set; }

    public DateTime? FcnCzasPrzypomnienia { get; set; }

    public string? FcnOpisNaFakturze { get; set; }

    public byte FcnGenerujAutomatycznie { get; set; }

    public byte FcnAutomatWyslijEmailDoKnt { get; set; }

    public int? FcnAutomatEmailSzablonId { get; set; }

    public byte? FcnAutomatWydrukStandardowy { get; set; }

    public int? FcnAutomatWydrukId { get; set; }

    public byte FcnBlokujDuplikatyKnt { get; set; }

    public byte FcnPrzenosNaFaAtrybutyKartyKnt { get; set; }

    public int? FcnOpeZalId { get; set; }

    public int? FcnStaZalId { get; set; }

    public DateTime FcnTsZal { get; set; }

    public int? FcnOpeModId { get; set; }

    public int? FcnStaModId { get; set; }

    public DateTime FcnTsMod { get; set; }

    public string FcnOpeModKod { get; set; } = null!;

    public string FcnOpeModNazwisko { get; set; } = null!;

    public string FcnOpeZalKod { get; set; } = null!;

    public string FcnOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<FaCyklElem> FaCyklElems { get; set; } = new List<FaCyklElem>();

    public virtual ICollection<FaCyklKnt> FaCyklKnts { get; set; } = new List<FaCyklKnt>();
}
