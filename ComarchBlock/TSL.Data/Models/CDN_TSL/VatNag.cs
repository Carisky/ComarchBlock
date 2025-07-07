using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class VatNag
{
    public int VaNVaNid { get; set; }

    public short VaNTyp { get; set; }

    public byte VaNRodzaj { get; set; }

    public string VaNRejestr { get; set; } = null!;

    public int VaNRokMies { get; set; }

    public int VaNLp { get; set; }

    public DateTime VaNDataObowiazkuPodatkowego { get; set; }

    public DateTime VaNDataPrawaOdliczenia { get; set; }

    public DateTime VaNDataZap { get; set; }

    public DateTime VaNDataWys { get; set; }

    public DateTime VaNDataOpe { get; set; }

    public DateTime VaNDataKur { get; set; }

    public byte VaNKursDoKsiegowania { get; set; }

    public DateTime VaNDataKurDoVat { get; set; }

    public int VaNDeklRokMies { get; set; }

    public int VaNDeklRokMiesKasa { get; set; }

    public byte VaNRozliczacVat7 { get; set; }

    public byte VaNRozliczacVatUe { get; set; }

    public byte VaNRozliczacVat27 { get; set; }

    public byte VaNAutoVat7Kasa { get; set; }

    public byte VaNMetodaKasowa { get; set; }

    public byte VaNJpkFa { get; set; }

    public string VaNIdentKsieg { get; set; } = null!;

    public string? VaNIdentKsiegNumeracja { get; set; }

    public int? VaNIdentKsiegDdfId { get; set; }

    public string VaNDokument { get; set; } = null!;

    public string? VaNDokumentyNadrzedne { get; set; }

    public string VaNKorektaDo { get; set; } = null!;

    public byte VaNKorekta { get; set; }

    public byte VaNFiskalna { get; set; }

    public byte VaNKorektaVat { get; set; }

    public byte VaNDetal { get; set; }

    public byte VaNWewnetrzna { get; set; }

    public short? VaNPodmiotTyp { get; set; }

    public int? VaNPodId { get; set; }

    public string VaNKntNazwa1 { get; set; } = null!;

    public string VaNKntNazwa2 { get; set; } = null!;

    public string VaNKntNazwa3 { get; set; } = null!;

    public string VaNKntKraj { get; set; } = null!;

    public string VaNKntWojewodztwo { get; set; } = null!;

    public string VaNKntPowiat { get; set; } = null!;

    public string VaNKntGmina { get; set; } = null!;

    public string VaNKntUlica { get; set; } = null!;

    public string VaNKntNrDomu { get; set; } = null!;

    public string VaNKntNrLokalu { get; set; } = null!;

    public string VaNKntMiasto { get; set; } = null!;

    public string VaNKntKodPocztowy { get; set; } = null!;

    public string VaNKntPoczta { get; set; } = null!;

    public string VaNKntAdres2 { get; set; } = null!;

    public string VaNKntNipKraj { get; set; } = null!;

    public string VaNKntNipE { get; set; } = null!;

    public string VaNPesel { get; set; } = null!;

    public string VaNKntKonto { get; set; } = null!;

    public byte VaNFinalny { get; set; }

    public byte VaNExport { get; set; }

    public byte VaNPodatekVat { get; set; }

    public byte VaNMalyPod { get; set; }

    public byte VaNRolnik { get; set; }

    public short? VaNPlatnikTyp { get; set; }

    public int? VaNPlatnikId { get; set; }

    public int? VaNPlatnikRachunekLp { get; set; }

    public string VaNPlatnikKraj { get; set; } = null!;

    public string VaNPlatnikWojewodztwo { get; set; } = null!;

    public string VaNPlatnikPowiat { get; set; } = null!;

    public string VaNPlatnikGmina { get; set; } = null!;

    public string VaNPlatnikUlica { get; set; } = null!;

    public string VaNPlatnikNrDomu { get; set; } = null!;

    public string VaNPlatnikNrLokalu { get; set; } = null!;

    public string VaNPlatnikMiasto { get; set; } = null!;

    public string VaNPlatnikKodPocztowy { get; set; } = null!;

    public string VaNPlatnikPoczta { get; set; } = null!;

    public string VaNPlatnikAdres2 { get; set; } = null!;

    public string VaNPlatnikNazwa1 { get; set; } = null!;

    public string VaNPlatnikNazwa2 { get; set; } = null!;

    public string VaNPlatnikNazwa3 { get; set; } = null!;

    public string VanPlatnikRachunekNr { get; set; } = null!;

    public int? VaNKatId { get; set; }

    public string VaNKategoria { get; set; } = null!;

    public int? VaNWzId { get; set; }

    public byte VaNRozliczono { get; set; }

    public byte VaNZaplacono { get; set; }

    public int? VaNFplId { get; set; }

    public DateTime VaNTermin { get; set; }

    public decimal VaNRazemNetto { get; set; }

    public decimal VaNRazemNettoDoVat { get; set; }

    public decimal VaNRazemVat { get; set; }

    public decimal VaNRazemVatdoVat { get; set; }

    public decimal VaNRazemBrutto { get; set; }

    public decimal VaNRazemBruttoDoVat { get; set; }

    public decimal VaNRazemBruttoWal { get; set; }

    public decimal VaNKwotaNkup { get; set; }

    public decimal VaNVatnkup { get; set; }

    public string VaNWaluta { get; set; } = null!;

    public string VaNWalutaDoVat { get; set; } = null!;

    public int VaNKursNumer { get; set; }

    public int VaNKursNumerDoVat { get; set; }

    public decimal VaNKursL { get; set; }

    public decimal VaNKursLdoVat { get; set; }

    public decimal VaNKursM { get; set; }

    public decimal VaNKursMdoVat { get; set; }

    public decimal VaNZaplata { get; set; }

    public decimal VaNWartoscZak { get; set; }

    public decimal VaNAkcyzaWegiel { get; set; }

    public int VaNAkcyzaWegielKolumnaKpr { get; set; }

    public byte VaNTrybNettoVat { get; set; }

    public short? VaNPodmiotZalTyp { get; set; }

    public int? VaNPodZalId { get; set; }

    public string? VaNAppRowId { get; set; }

    public int? VaNAppId { get; set; }

    public int? VaNTrnId { get; set; }

    public int? VaNVanOrgId { get; set; }

    public decimal VaNCloProc { get; set; }

    public decimal VaNCloWart { get; set; }

    public decimal VaNAkcyzaProc { get; set; }

    public decimal VaNAkcyzaWart { get; set; }

    public decimal VaNPodImpProc { get; set; }

    public decimal VaNPodImpWart { get; set; }

    public int? VaNKpRid { get; set; }

    public int? VaNRycId { get; set; }

    public int? VaNDekId { get; set; }

    public int? VaNPreDekId { get; set; }

    public string? VaNImportAppId { get; set; }

    public string? VaNImportRowId { get; set; }

    public DateTime? VaNTsExport { get; set; }

    public int? VaNOpeZalId { get; set; }

    public int? VaNStaZalId { get; set; }

    public DateTime VaNTsZal { get; set; }

    public int? VaNOpeModId { get; set; }

    public int? VaNStaModId { get; set; }

    public DateTime VaNTsMod { get; set; }

    public string VaNOpeModKod { get; set; } = null!;

    public string VaNOpeModNazwisko { get; set; } = null!;

    public string VaNOpeZalKod { get; set; } = null!;

    public string VaNOpeZalNazwisko { get; set; } = null!;

    public short? VaNSrw { get; set; }

    public int? VaNZakId { get; set; }

    public int? VaNZbVaNid { get; set; }

    public int? VaNDnpId { get; set; }

    public byte VaNSplitPay { get; set; }

    public byte VaNOcr { get; set; }

    public byte? VaNZbiorcza { get; set; }

    public int VaNRozliczacOss { get; set; }

    public int VaNRokOss { get; set; }

    public int VaNKwartalOss { get; set; }

    public DateTime VaNDataKurOss { get; set; }

    public string VaNWalutaOss { get; set; } = null!;

    public decimal VaNRazemBruttoOss { get; set; }

    public decimal VaNRazemNettoOss { get; set; }

    public decimal VaNRazemVatoss { get; set; }

    public decimal VaNKursMoss { get; set; }

    public decimal VaNKursLoss { get; set; }

    public decimal VaNKursNumerOss { get; set; }

    public string VaNKodKrajuOss { get; set; } = null!;

    public string VaNNrKseF { get; set; } = null!;

    public string VaNOpis { get; set; } = null!;

    public DateTime? VaNKseFdataPrzyjecia { get; set; }

    public string? VaNIdentKsiegStr { get; set; }

    public int? VaNIdentKsiegNr { get; set; }

    public decimal? VaNNettoWal { get; set; }

    public decimal? VaNVatwal { get; set; }

    public int? VaNPitKasowy { get; set; }

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual PodmiotyView? PodmiotyView { get; set; }

    public virtual FormyPlatnosci? VaNFpl { get; set; }

    public virtual Kategorie? VaNKat { get; set; }

    public virtual ICollection<VatTab7> VatTab7s { get; set; } = new List<VatTab7>();

    public virtual ICollection<VatTab> VatTabs { get; set; } = new List<VatTab>();
}
