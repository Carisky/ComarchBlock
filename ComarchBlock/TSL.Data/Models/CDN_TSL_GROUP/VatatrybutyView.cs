using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class VatatrybutyView
{
    public long? VavVavid { get; set; }

    public int? VavDeAid { get; set; }

    public byte? VavDeAtyp { get; set; }

    public string? VavDeAkod { get; set; }

    public string? VavDeAnazwa { get; set; }

    public short? VavDeAformat { get; set; }

    public byte? VavDeAzalezny { get; set; }

    public byte? VavDeAczyKopiowacFa { get; set; }

    public byte? VavDeAczyKod { get; set; }

    public byte? VavDeAczyPrzenosic { get; set; }

    public byte? VavDeAczyDrukowac { get; set; }

    public int? VavDatId { get; set; }

    public string? VavDatWartoscTxt { get; set; }

    public int VavVaNid { get; set; }

    public short VavTyp { get; set; }

    public byte VavRodzaj { get; set; }

    public string VavRejestr { get; set; } = null!;

    public int VavRokMies { get; set; }

    public int VavLp { get; set; }

    public DateTime VavDataZap { get; set; }

    public DateTime VavDataWys { get; set; }

    public DateTime VavDataOpe { get; set; }

    public DateTime VavDataKur { get; set; }

    public int VavDeklRokMies { get; set; }

    public int VavDeklRokMiesKasa { get; set; }

    public byte VavRozliczacVat7 { get; set; }

    public byte VavRozliczacVatUe { get; set; }

    public byte VavAutoVat7Kasa { get; set; }

    public string VavIdentKsieg { get; set; } = null!;

    public string VavDokument { get; set; } = null!;

    public string VavKorektaDo { get; set; } = null!;

    public byte VavKorekta { get; set; }

    public byte VavFiskalna { get; set; }

    public byte VavKorektaVat { get; set; }

    public byte VavDetal { get; set; }

    public byte VavWewnetrzna { get; set; }

    public short? VavPodmiotTyp { get; set; }

    public int? VavPodId { get; set; }

    public string VavKntNazwa1 { get; set; } = null!;

    public string VavKntNazwa2 { get; set; } = null!;

    public string VavKntNazwa3 { get; set; } = null!;

    public string VavKntKraj { get; set; } = null!;

    public string VavKntWojewodztwo { get; set; } = null!;

    public string VavKntPowiat { get; set; } = null!;

    public string VavKntGmina { get; set; } = null!;

    public string VavKntUlica { get; set; } = null!;

    public string VavKntNrDomu { get; set; } = null!;

    public string VavKntNrLokalu { get; set; } = null!;

    public string VavKntMiasto { get; set; } = null!;

    public string VavKntKodPocztowy { get; set; } = null!;

    public string VavKntPoczta { get; set; } = null!;

    public string VavKntAdres2 { get; set; } = null!;

    public string VavKntNipKraj { get; set; } = null!;

    public string VavKntNipE { get; set; } = null!;

    public string VavKntKonto { get; set; } = null!;

    public byte VavFinalny { get; set; }

    public byte VavExport { get; set; }

    public byte VavMalyPod { get; set; }

    public byte VavRolnik { get; set; }

    public int? VavKatId { get; set; }

    public string VavKategoria { get; set; } = null!;

    public int? VavWzId { get; set; }

    public byte VavRozliczono { get; set; }

    public int? VavFplId { get; set; }

    public DateTime VavTermin { get; set; }

    public decimal VavRazemNetto { get; set; }

    public decimal VavRazemVat { get; set; }

    public decimal VavRazemBrutto { get; set; }

    public decimal VavRazemNettoDoVat { get; set; }

    public decimal VavRazemVatdoVat { get; set; }

    public decimal VavRazemBruttoDoVat { get; set; }

    public decimal VavRazemBruttoWal { get; set; }

    public string VavWaluta { get; set; } = null!;

    public int VavKursNumer { get; set; }

    public decimal VavKursL { get; set; }

    public decimal VavKursM { get; set; }

    public decimal VavZaplata { get; set; }

    public decimal VavWartoscZak { get; set; }

    public short? VavPodmiotZalTyp { get; set; }

    public int? VavPodZalId { get; set; }

    public string? VavAppRowId { get; set; }

    public int? VavAppId { get; set; }

    public int? VavTrnId { get; set; }

    public int? VavVanOrgId { get; set; }

    public decimal VavCloProc { get; set; }

    public decimal VavCloWart { get; set; }

    public decimal VavAkcyzaProc { get; set; }

    public decimal VavAkcyzaWart { get; set; }

    public decimal VavPodImpProc { get; set; }

    public decimal VavPodImpWart { get; set; }

    public int? VavKpRid { get; set; }

    public int? VavRycId { get; set; }

    public int? VavDekId { get; set; }

    public string? VavImportAppId { get; set; }

    public string? VavImportRowId { get; set; }

    public DateTime? VavTsExport { get; set; }

    public int? VavOpeZalId { get; set; }

    public int? VavStaZalId { get; set; }

    public DateTime VavTsZal { get; set; }

    public int? VavOpeModId { get; set; }

    public int? VavStaModId { get; set; }

    public DateTime VavTsMod { get; set; }

    public string? VavIdentKsiegStr { get; set; }

    public int? VavIdentKsiegNr { get; set; }
}
