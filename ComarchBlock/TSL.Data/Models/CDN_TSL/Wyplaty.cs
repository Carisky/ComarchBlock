using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Wyplaty
{
    public int WplWplId { get; set; }

    public int WplPraId { get; set; }

    public int WplLplId { get; set; }

    public int WplDzlId { get; set; }

    public int WplDdfId { get; set; }

    public int WplTryb { get; set; }

    public int? WplParentId { get; set; }

    public string WplNumerString { get; set; } = null!;

    public int WplNumerNr { get; set; }

    public string? WplNumerPelny { get; set; }

    public DateTime WplDataDok { get; set; }

    public decimal WplWartosc { get; set; }

    public byte WplMiesiac { get; set; }

    public int WplRok { get; set; }

    public DateTime WplDataOd { get; set; }

    public DateTime WplDataDo { get; set; }

    public string WplNazwa { get; set; } = null!;

    public byte WplZamknieta { get; set; }

    public int? WplKatId { get; set; }

    public string WplKategoriaOpis { get; set; } = null!;

    public byte WplKorektaPlatnosci { get; set; }

    public int WplKorektaPola { get; set; }

    public decimal WplBrutto { get; set; }

    public byte WplKorekta { get; set; }

    public byte WplArchiwalna { get; set; }

    public short WplUmowaDodZas { get; set; }

    public decimal WplKursLnal { get; set; }

    public decimal WplKursMnal { get; set; }

    public decimal WplOddelegowanyDieta { get; set; }

    public decimal WplKursLnalDieta { get; set; }

    public decimal WplKursMnalDieta { get; set; }

    public byte WplObnizSklPpk { get; set; }

    public int WplKorektaPola2 { get; set; }

    public decimal WplPodstawaPodat1 { get; set; }

    public decimal WplPodstawaPodat2 { get; set; }

    public decimal WplProcentPodat1 { get; set; }

    public decimal WplProcentPodat2 { get; set; }

    public short WplFormaOpodatZdrow { get; set; }

    public decimal WplDochodUbMiesZdrow { get; set; }

    public decimal WplPrzychodBiezRokZdrow { get; set; }

    public decimal WplPrzychodUbRokZdrow { get; set; }

    public short WplKompensata { get; set; }

    public decimal WplWlascDochodSkala { get; set; }

    public decimal WplWlascDochodLiniowy { get; set; }

    public decimal WplWlascPrzychodBiezRyczalt { get; set; }

    public decimal WplWlascPrzychodUbRyczalt { get; set; }

    public decimal WplWlascDochodKarta { get; set; }

    public decimal WplWlascDochodBrak { get; set; }

    public byte WplOddelegowanyKierowca { get; set; }

    public decimal WplWlascKwotaPoprzRokSkala { get; set; }

    public decimal WplWlascKwotaPoprzRokLiniowy { get; set; }

    public decimal WplWlascKwotaPoprzRokRyczalt { get; set; }

    public decimal WplWlascPodstZdrowRokSkala { get; set; }

    public decimal WplWlascPodstZdrowRokLiniowy { get; set; }

    public decimal WplWlascPodstZdrowRokRyczalt { get; set; }

    public decimal WplWlascSumaSklZdrowSkala { get; set; }

    public decimal WplWlascSumaSklZdrowLiniowy { get; set; }

    public decimal WplWlascSumaSklZdrowRyczalt { get; set; }

    public decimal WplWlascSklZdrowRokSkala { get; set; }

    public decimal WplWlascSklZdrowRokLiniowy { get; set; }

    public decimal WplWlascSklZdrowRokRyczalt { get; set; }

    public decimal WplWlascDoplataSkala { get; set; }

    public decimal WplWlascDoplataLiniowy { get; set; }

    public decimal WplWlascDoplataRyczalt { get; set; }

    public decimal WplWlascZwrotSkala { get; set; }

    public decimal WplWlascZwrotLiniowy { get; set; }

    public decimal WplWlascZwrotRyczalt { get; set; }

    public int WplWlascZmianaFormyOpodat1 { get; set; }

    public int WplWlascZmianaFormyOpodat7 { get; set; }

    public decimal WplWlascDoplata { get; set; }

    public decimal WplWlascZwrot { get; set; }

    public int WplWlascPodlZdrowMiesSkala { get; set; }

    public int WplWlascPodlZdrowMiesLiniowy { get; set; }

    public int WplWlascPodlZdrowMiesRyczalt { get; set; }

    public decimal WplWlascMinPodstZdrowSkala { get; set; }

    public decimal WplWlascMinPodstZdrowLiniowy { get; set; }

    public decimal WplWlascMinPodstZdrowRyczalt { get; set; }

    public int? WplPierwotna { get; set; }

    public int WplStornId { get; set; }

    public int? WplOpeZalId { get; set; }

    public int? WplStaZalId { get; set; }

    public DateTime? WplTsZal { get; set; }

    public int? WplOpeModId { get; set; }

    public int? WplStaModId { get; set; }

    public DateTime? WplTsMod { get; set; }

    public string WplOpeModKod { get; set; } = null!;

    public string WplOpeModNazwisko { get; set; } = null!;

    public string WplOpeZalKod { get; set; } = null!;

    public string WplOpeZalNazwisko { get; set; } = null!;

    public DateTime? WplTsImport { get; set; }

    public string? WplImportRowId { get; set; }

    public byte WplZwolZus { get; set; }

    public virtual ICollection<Wyplaty> InverseWplParent { get; set; } = new List<Wyplaty>();

    public virtual DokDefinicje WplDdf { get; set; } = null!;

    public virtual Dzialy WplDzl { get; set; } = null!;

    public virtual Kategorie? WplKat { get; set; }

    public virtual ListyPlac WplLpl { get; set; } = null!;

    public virtual Wyplaty? WplParent { get; set; }

    public virtual PracKod WplPra { get; set; } = null!;

    public virtual ICollection<WypElementy> WypElementies { get; set; } = new List<WypElementy>();
}
