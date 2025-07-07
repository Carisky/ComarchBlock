using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SekDokumenty
{
    public int SddId { get; set; }

    public short? SddTyp { get; set; }

    public short? SddOddRok { get; set; }

    public byte? SddOddMiesiac { get; set; }

    public string? SddOddSeria { get; set; }

    public int? SddOddNumer { get; set; }

    public int? SddWflId { get; set; }

    public short? SddKntTyp { get; set; }

    public int? SddKntNumer { get; set; }

    public int? SddKontaktNumer { get; set; }

    public short? SddNadawcaTyp { get; set; }

    public int? SddNadawcaNumer { get; set; }

    public int? SddNadawcaOsoba { get; set; }

    public int? SddNadawcaAdrNumer { get; set; }

    public short? SddNadawcaAdrTyp { get; set; }

    public string? SddNumerObcy { get; set; }

    public string? SddOpis { get; set; }

    public string? SddOpisDokumentu { get; set; }

    public int? SddFrsId { get; set; }

    public int? SddSdtId { get; set; }

    public int? SddDokData { get; set; }

    public int? SddDokDataWplywu { get; set; }

    public int? SddSlwId { get; set; }

    public int? SddPrzesylkiData { get; set; }

    public string? SddPrzesylkiNumer { get; set; }

    public int? SddZwrotTermin { get; set; }

    public byte? SddOczekiwanyTermin { get; set; }

    public short? SddUtwTyp { get; set; }

    public int? SddUtwNumer { get; set; }

    public int? SddUtwData { get; set; }

    public int? SddAktywny { get; set; }

    public int? SddCzasModyfikacji { get; set; }

    public decimal? SddMasa { get; set; }

    public decimal? SddOplata { get; set; }

    public decimal? SddWartosc { get; set; }

    public byte? SddPriorytet { get; set; }

    public virtual ICollection<SekStatusyDok> SekStatusyDoks { get; set; } = new List<SekStatusyDok>();
}
