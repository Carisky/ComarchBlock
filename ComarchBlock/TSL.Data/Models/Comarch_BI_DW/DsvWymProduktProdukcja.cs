using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvWymProduktProdukcja
{
    public int? FaktyProd { get; set; }

    public string? Gid { get; set; }

    public int? Hierarchy3Level1Id { get; set; }

    public string? Hierarchy3Level1Name { get; set; }

    public string? Hierarchy3Level1OrgId { get; set; }

    public int? Hierarchy3Level2Id { get; set; }

    public string? Hierarchy3Level2Name { get; set; }

    public string? Hierarchy3Level2OrgId { get; set; }

    public int? Hierarchy3Level3Id { get; set; }

    public string? Hierarchy3Level3Name { get; set; }

    public string? Hierarchy3Level3OrgId { get; set; }

    public int? Hierarchy3Level4Id { get; set; }

    public string? Hierarchy3Level4Name { get; set; }

    public string? Hierarchy3Level4OrgId { get; set; }

    public int? Hierarchy3Level5Id { get; set; }

    public string? Hierarchy3Level5Name { get; set; }

    public string? Hierarchy3Level5OrgId { get; set; }

    public string? ProdAktualneOrgId { get; set; }

    public string? ProdAktualneOrgParId { get; set; }

    public string? ProdAktywny { get; set; }

    public byte? ProdAnalizaAbcxyz { get; set; }

    public string? ProdAtrybut1Nazwa { get; set; }

    public string? ProdAtrybut1Wartosc { get; set; }

    public string? ProdAtrybut2Nazwa { get; set; }

    public string? ProdAtrybut2Wartosc { get; set; }

    public string? ProdAtrybut3Nazwa { get; set; }

    public string? ProdAtrybut3Wartosc { get; set; }

    public string? ProdCertyfikat { get; set; }

    public int? ProdCzasDostawy { get; set; }

    public int? ProdDataDo { get; set; }

    public int? ProdDataOd { get; set; }

    public int? ProdDataPierwszejTranSpr { get; set; }

    public int? ProdDataPierwszejTranZkp { get; set; }

    public string ProdDirtyOrgId { get; set; } = null!;

    public int ProdDostepnoscId { get; set; }

    public string? ProdEan { get; set; }

    public string? ProdGtu { get; set; }

    public int ProdId { get; set; }

    public string? ProdJmpodstawowa { get; set; }

    public int? ProdKategoriaRynkowaId { get; set; }

    public string? ProdKaucja { get; set; }

    public int? ProdKimball1CheckSum { get; set; }

    public int? ProdKimball2CheckSum { get; set; }

    public string? ProdKod { get; set; }

    public string? ProdKodPcn { get; set; }

    public string? ProdKrajPoch { get; set; }

    public string? ProdMarka { get; set; }

    public decimal? ProdMarzaMinimalna { get; set; }

    public string? ProdMpp { get; set; }

    public string? ProdNazwa { get; set; }

    public string? ProdNazwaDodatkowa { get; set; }

    public int? ProdObiTyp { get; set; }

    public decimal? ProdObjetosc { get; set; }

    public int ProdObrazId { get; set; }

    public string? ProdOpis { get; set; }

    public decimal? ProdOplataCukrowaKofeina { get; set; }

    public decimal? ProdOplataCukrowaStala { get; set; }

    public decimal? ProdOplataCukrowaZmienna { get; set; }

    public string? ProdOrgAtrId { get; set; }

    public string ProdOrgId { get; set; } = null!;

    public string? ProdOrgParId { get; set; }

    public string? ProdParDirtyOrgId { get; set; }

    public int? ProdParId { get; set; }

    public string? ProdPkwiu { get; set; }

    public int? ProdPoprzednikId { get; set; }

    public int? ProdPracownikId { get; set; }

    public int? ProdProducentId { get; set; }

    public string? ProdProgramLojalnosciowy { get; set; }

    public string? ProdProgramLojalnosciowyNagroda { get; set; }

    public string? ProdRodzaj { get; set; }

    public string? ProdRodzajBonow { get; set; }

    public int? ProdRowId { get; set; }

    public byte[] ProdRowVersion { get; set; } = null!;

    public decimal? ProdStawkaVat { get; set; }

    public int? ProdStrukturaFirmyId { get; set; }

    public int? ProdSubTransformationId { get; set; }

    public string? ProdSymbol { get; set; }

    public DateTime ProdTsinsert { get; set; }

    public DateTime ProdTsupdate { get; set; }

    public string? ProdTyp { get; set; }

    public string? ProdUrl { get; set; }

    public decimal? ProdWaga { get; set; }

    public decimal? ProdWartoscPunktowa { get; set; }

    public int? ProdWymFirma { get; set; }

    public int? ProdWymTyp { get; set; }

    public int ProdZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }
}
