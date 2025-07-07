using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKontrahent
{
    public int? Atr021Id { get; set; }

    public int? Atr022Id { get; set; }

    public int? AkronimId { get; set; }

    public int? FaktyAkw { get; set; }

    public int? FaktyDst { get; set; }

    public int? FaktyKntd { get; set; }

    public int? FaktyKntk { get; set; }

    public int? FaktyPlat { get; set; }

    public string? Gid { get; set; }

    public int? Hierarchy2Level1Id { get; set; }

    public string? Hierarchy2Level1Name { get; set; }

    public string? Hierarchy2Level1OrgId { get; set; }

    public int? Hierarchy2Level2Id { get; set; }

    public string? Hierarchy2Level2Name { get; set; }

    public string? Hierarchy2Level2OrgId { get; set; }

    public int? Hierarchy2Level3Id { get; set; }

    public string? Hierarchy2Level3Name { get; set; }

    public string? Hierarchy2Level3OrgId { get; set; }

    public int? Hierarchy2Level4Id { get; set; }

    public string? Hierarchy2Level4Name { get; set; }

    public string? Hierarchy2Level4OrgId { get; set; }

    public string? KntAdres { get; set; }

    public string? KntAkronim { get; set; }

    public string? KntAktualneOrgId { get; set; }

    public string? KntAktualneOrgParId { get; set; }

    public int? KntAktywny { get; set; }

    public int? KntAkwDataPierwszejTranSpr { get; set; }

    public int? KntAkwizytor { get; set; }

    public int? KntAkwizytorId { get; set; }

    public string? KntAkwizytorOrgId { get; set; }

    public string? KntAtrybut1Nazwa { get; set; }

    public string? KntAtrybut1Wartosc { get; set; }

    public string? KntAtrybut2Nazwa { get; set; }

    public string? KntAtrybut2Wartosc { get; set; }

    public string? KntAtrybut3Nazwa { get; set; }

    public string? KntAtrybut3Wartosc { get; set; }

    public string? KntBranza { get; set; }

    public int? KntCentralaId { get; set; }

    public string? KntCentralaOrgId { get; set; }

    public int? KntDataDo { get; set; }

    public int? KntDataOd { get; set; }

    public string KntDirtyOrgId { get; set; } = null!;

    public decimal? KntDlugGeog { get; set; }

    public string? KntDostawca { get; set; }

    public decimal? KntDstIloscRoz { get; set; }

    public decimal? KntDstMaxOp { get; set; }

    public decimal? KntDstMinOp { get; set; }

    public decimal? KntDstOdchStd { get; set; }

    public decimal? KntDstSok { get; set; }

    public decimal? KntDstSop { get; set; }

    public string? KntEmail { get; set; }

    public string? KntExpoKraj { get; set; }

    public string? KntFlgBlokTrans { get; set; }

    public string? KntFlgBlokZam { get; set; }

    public string? KntFormaPlSprz { get; set; }

    public string? KntFormaPlZakup { get; set; }

    public string? KntFppKod { get; set; }

    public int? KntGeoid { get; set; }

    public string? KntGrupaCenowa { get; set; }

    public int KntId { get; set; }

    public string? KntJednPowiazana { get; set; }

    public string? KntKartaLoj { get; set; }

    public int? KntKimball1CheckSum { get; set; }

    public int? KntKimball2CheckSum { get; set; }

    public int? KntKntDdataPierwszejTranSpr { get; set; }

    public int? KntKntdDataPierwszejTranZkp { get; set; }

    public decimal? KntKntIloscRoz { get; set; }

    public int? KntKntKdataPierwszejTranSpr { get; set; }

    public int? KntKntkDataPierwszejTranZkp { get; set; }

    public decimal? KntKntMaxOp { get; set; }

    public decimal? KntKntMinOp { get; set; }

    public decimal? KntKntOdchStd { get; set; }

    public decimal? KntKntSok { get; set; }

    public decimal? KntKntSop { get; set; }

    public string? KntKodPocztowy { get; set; }

    public string? KntKsefwyslij { get; set; }

    public string? KntKseFzrodlowy { get; set; }

    public decimal? KntLimitKredytu { get; set; }

    public string? KntLimitNieograniczony { get; set; }

    public decimal? KntLimitUzyty { get; set; }

    public string? KntMiejscowosc { get; set; }

    public int? KntMiejscowoscId { get; set; }

    public string? KntNazwa { get; set; }

    public string? KntNip { get; set; }

    public string? KntNipPrfx { get; set; }

    public int? KntObiTyp { get; set; }

    public int? KntObszarId { get; set; }

    public string? KntOdbiorca { get; set; }

    public string? KntOpis { get; set; }

    public string? KntOrgAtrId { get; set; }

    public string KntOrgId { get; set; } = null!;

    public string? KntOrgParId { get; set; }

    public string? KntParDirtyOrgId { get; set; }

    public int? KntParId { get; set; }

    public string? KntPlatnikVat { get; set; }

    public string? KntPodmiot { get; set; }

    public int? KntPoprzednikId { get; set; }

    public int? KntPracownikId { get; set; }

    public string? KntPriorytet { get; set; }

    public int? KntProducent { get; set; }

    public string? KntProgramLoj { get; set; }

    public string? KntRodzaj { get; set; }

    public string? KntRolaPartnera { get; set; }

    public string? KntRolnikRyczalt { get; set; }

    public int? KntRowId { get; set; }

    public byte[] KntRowVersion { get; set; } = null!;

    public int? KntSposobDostawyId { get; set; }

    public int? KntSubTransformationId { get; set; }

    public decimal? KntSzerGeog { get; set; }

    public string? KntTelefon { get; set; }

    public string? KntTelex { get; set; }

    public int? KntTerminPlatnosci { get; set; }

    public int? KntTerminPlatnosciZakup { get; set; }

    public DateTime KntTsinsert { get; set; }

    public DateTime KntTsupdate { get; set; }

    public string? KntUrl { get; set; }

    public string? KntWlasciciel { get; set; }

    public int? KntWymFirma { get; set; }

    public int? KntWymTyp { get; set; }

    public int KntZrodgid { get; set; }

    public string? KntZrodlo { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
