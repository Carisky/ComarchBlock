using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Umowy
{
    public int UmwUmwId { get; set; }

    public int UmwPraId { get; set; }

    public int? UmwDzlId { get; set; }

    public int UmwDdfId { get; set; }

    public int UmwTwpId { get; set; }

    public int UmwTumId { get; set; }

    public int UmwTyuId { get; set; }

    public int? UmwListaPlacSymbol { get; set; }

    public string UmwNumerString { get; set; } = null!;

    public int UmwNumerNr { get; set; }

    public string? UmwNumerPelny { get; set; }

    public DateTime UmwDataDok { get; set; }

    public DateTime UmwDataOd { get; set; }

    public DateTime UmwDataDo { get; set; }

    public DateTime? UmwDataZawarcia { get; set; }

    public string UmwTytul { get; set; } = null!;

    public decimal UmwWartosc { get; set; }

    public string UmwRodzaj { get; set; } = null!;

    public decimal UmwSplacono { get; set; }

    public string UmwWaluta { get; set; } = null!;

    public byte UmwWgBrutto { get; set; }

    public byte UmwJestZus { get; set; }

    public decimal UmwBrutto { get; set; }

    public decimal UmwFis { get; set; }

    public decimal UmwZus { get; set; }

    public byte UmwPomnZus { get; set; }

    public decimal UmwStawkaPodatku { get; set; }

    public decimal UmwKosztyKwota { get; set; }

    public decimal UmwKosztyProc { get; set; }

    public string? UmwKodZawodu { get; set; }

    public DateTime? UmwZusOd { get; set; }

    public byte UmwJestEmerytal { get; set; }

    public byte UmwJestRentowe { get; set; }

    public byte UmwJestChorobowe { get; set; }

    public byte UmwJestWypad { get; set; }

    public DateTime? UmwEmerOd { get; set; }

    public DateTime? UmwEmerDo { get; set; }

    public DateTime? UmwRentOd { get; set; }

    public DateTime? UmwRentDo { get; set; }

    public DateTime? UmwChorOd { get; set; }

    public DateTime? UmwChorDo { get; set; }

    public DateTime? UmwWypadDo { get; set; }

    public int UmwEmerKod { get; set; }

    public int UmwRentKod { get; set; }

    public int UmwChorKod { get; set; }

    public int UmwWypadKod { get; set; }

    public DateTime? UmwZdrowOd { get; set; }

    public DateTime? UmwZdrowDobrOd { get; set; }

    public DateTime? UmwZdrowDo { get; set; }

    public decimal UmwZdrowKwotaPierwSkl { get; set; }

    public int UmwZdrowKod { get; set; }

    public int UmwTytKontZus { get; set; }

    public DateTime? UmwZusKontoOd { get; set; }

    public byte UmwJestDobrEmerytal { get; set; }

    public byte UmwJestDobrRentowe { get; set; }

    public byte UmwJestDobrChorobowe { get; set; }

    public byte UmwJestDobrZdrow { get; set; }

    public int? UmwPrzekroczRok { get; set; }

    public byte? UmwPrzekroczMiesiac { get; set; }

    public decimal? UmwPrzekroczKwota { get; set; }

    public string? UmwPrzekroczInformacja { get; set; }

    public byte? UmwPrzekroczenie { get; set; }

    public byte UmwOgraniczSklZdrow { get; set; }

    public decimal? UmwKwotaNastWyp { get; set; }

    public byte UmwSplacona { get; set; }

    public string UmwSymbol { get; set; } = null!;

    public string UmwOpis { get; set; } = null!;

    public byte UmwNaliczajFundusze { get; set; }

    public byte UmwWliczChorZakonczona { get; set; }

    public byte UmwUwzglMin { get; set; }

    public byte UmwCzasPracy { get; set; }

    public decimal UmwStawkaGodz { get; set; }

    public short UmwUlgaMnoznikL { get; set; }

    public short UmwUlgaMnoznikM { get; set; }

    public byte UmwNiepobierajZaliczkiPodatku { get; set; }

    public byte UmwOddelegowany { get; set; }

    public decimal UmwOddelegowanyDieta { get; set; }

    public string UmwOddelegowanyWaluta { get; set; } = null!;

    public byte UmwOddelegowanyFis { get; set; }

    public string UmwOddelegowanyKraj { get; set; } = null!;

    public string UmwOddelegowanyWalutaDieta { get; set; } = null!;

    public byte UmwOddelegowanyPropOdl { get; set; }

    public int? UmwOpeZalId { get; set; }

    public int? UmwStaZalId { get; set; }

    public DateTime UmwTsZal { get; set; }

    public int? UmwOpeModId { get; set; }

    public int? UmwStaModId { get; set; }

    public DateTime UmwTsMod { get; set; }

    public string UmwOpeModKod { get; set; } = null!;

    public string UmwOpeModNazwisko { get; set; } = null!;

    public string UmwOpeZalKod { get; set; } = null!;

    public string UmwOpeZalNazwisko { get; set; } = null!;

    public string? UmwImportRowId { get; set; }

    public virtual ICollection<DodatkiUmowy> DodatkiUmowies { get; set; } = new List<DodatkiUmowy>();

    public virtual ICollection<UmowyZestCzasu> UmowyZestCzasus { get; set; } = new List<UmowyZestCzasu>();

    public virtual DokDefinicje UmwDdf { get; set; } = null!;

    public virtual Dzialy? UmwDzl { get; set; }

    public virtual PracKod UmwPra { get; set; } = null!;

    public virtual TytUbezp UmwTyu { get; set; } = null!;
}
