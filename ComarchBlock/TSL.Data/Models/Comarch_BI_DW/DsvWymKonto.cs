using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymKonto
{
    public string? Gid { get; set; }

    public string? KontoAktualneOrgId { get; set; }

    public string? KontoAktualneOrgParId { get; set; }

    public int? KontoAktywny { get; set; }

    public string? KontoAnalityczne { get; set; }

    public string? KontoArchiwalny { get; set; }

    public int? KontoDataDo { get; set; }

    public int? KontoDataOd { get; set; }

    public string KontoDirtyOrgId { get; set; } = null!;

    public int KontoId { get; set; }

    public int? KontoKimball1CheckSum { get; set; }

    public int? KontoKimball2CheckSum { get; set; }

    public string? KontoKlasa { get; set; }

    public int? KontoKntId { get; set; }

    public string? KontoLisc { get; set; }

    public string? KontoNazwa { get; set; }

    public string? KontoNazwaDodatkowa { get; set; }

    public string? KontoNumer { get; set; }

    public string? KontoNumerAktualny { get; set; }

    public string? KontoNumerNastepnyOkres { get; set; }

    public string? KontoNumerNastepnyOkresOrgId { get; set; }

    public int KontoOkresId { get; set; }

    public string? KontoOpis { get; set; }

    public string? KontoOrgAtrId { get; set; }

    public string KontoOrgId { get; set; } = null!;

    public string? KontoOrgParId { get; set; }

    public string? KontoParDirtyOrgId { get; set; }

    public int? KontoParId { get; set; }

    public int? KontoPoprzednikId { get; set; }

    public int? KontoPozabilansowe { get; set; }

    public int? KontoPoziom { get; set; }

    public int? KontoPoziom0Id { get; set; }

    public string? KontoPoziom0Nazwa { get; set; }

    public string? KontoPoziom0NazwaKonta { get; set; }

    public string? KontoPoziom0SaldoDwustronnie { get; set; }

    public int? KontoPoziom1Id { get; set; }

    public string? KontoPoziom1Nazwa { get; set; }

    public string? KontoPoziom1NazwaKonta { get; set; }

    public string? KontoPoziom1SaldoDwustronnie { get; set; }

    public int? KontoPoziom2Id { get; set; }

    public string? KontoPoziom2Nazwa { get; set; }

    public string? KontoPoziom2NazwaKonta { get; set; }

    public string? KontoPoziom2SaldoDwustronnie { get; set; }

    public int? KontoPoziom3Id { get; set; }

    public string? KontoPoziom3Nazwa { get; set; }

    public string? KontoPoziom3NazwaKonta { get; set; }

    public string? KontoPoziom3SaldoDwustronnie { get; set; }

    public int? KontoPoziom4Id { get; set; }

    public string? KontoPoziom4Nazwa { get; set; }

    public string? KontoPoziom4NazwaKonta { get; set; }

    public string? KontoPoziom4SaldoDwustronnie { get; set; }

    public int? KontoPoziom5Id { get; set; }

    public string? KontoPoziom5Nazwa { get; set; }

    public string? KontoPoziom5NazwaKonta { get; set; }

    public string? KontoPoziom5SaldoDwustronnie { get; set; }

    public int? KontoPoziom6Id { get; set; }

    public string? KontoPoziom6Nazwa { get; set; }

    public string? KontoPoziom6NazwaKonta { get; set; }

    public string? KontoPoziom6SaldoDwustronnie { get; set; }

    public int? KontoPoziomAktualny { get; set; }

    public int? KontoRowId { get; set; }

    public byte[] KontoRowVersion { get; set; } = null!;

    public string? KontoRozrachunkowe { get; set; }

    public string? KontoSaldoDwustronnie { get; set; }

    public string? KontoSegment0 { get; set; }

    public string? KontoSegment1 { get; set; }

    public string? KontoSegment2 { get; set; }

    public string? KontoSegment3 { get; set; }

    public string? KontoSegment4 { get; set; }

    public string? KontoSegment5 { get; set; }

    public string? KontoSegment6 { get; set; }

    public int? KontoSubTransformationId { get; set; }

    public DateTime KontoTsinsert { get; set; }

    public DateTime KontoTsupdate { get; set; }

    public string? KontoTyp { get; set; }

    public string? KontoTypOgolny { get; set; }

    public string? KontoWaluta { get; set; }

    public int? KontoWymFirma { get; set; }

    public int? KontoWymTyp { get; set; }

    public int KontoZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int WalutaSystemowaId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
