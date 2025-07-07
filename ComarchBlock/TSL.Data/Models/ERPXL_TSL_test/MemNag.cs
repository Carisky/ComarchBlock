using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class MemNag
{
    public short? MenGidtyp { get; set; }

    public int? MenGidfirma { get; set; }

    public int MenGidnumer { get; set; }

    public short? MenGidlp { get; set; }

    public short? MenMdntyp { get; set; }

    public int? MenMdnfirma { get; set; }

    public int? MenMdnnumer { get; set; }

    public short? MenMdnlp { get; set; }

    public short? MenKnttyp { get; set; }

    public int? MenKntfirma { get; set; }

    public int? MenKntnumer { get; set; }

    public short? MenKntlp { get; set; }

    public string? MenSeria { get; set; }

    public int? MenNumer { get; set; }

    public int? MenRokMiesiac { get; set; }

    public int? MenOkrPoczatek { get; set; }

    public string? MenOkrSymbol { get; set; }

    public string? MenNumerDokumentu { get; set; }

    public short? MenStan { get; set; }

    public int? MenDataWprow { get; set; }

    public int? MenDataDok { get; set; }

    public int? MenDataOper { get; set; }

    public decimal? MenKwotaPrz { get; set; }

    public decimal? MenKwotaRoz { get; set; }

    public string? MenTresc { get; set; }

    public byte? MenZaksiegowano { get; set; }

    public byte? MenNieKsiegowac { get; set; }

    public int? MenDataKsiegowania { get; set; }

    public string? MenDziennik { get; set; }

    public int? MenAktywny { get; set; }

    public string? MenUwagi { get; set; }

    public string? MenWaluta { get; set; }

    public short? MenNrKursu { get; set; }

    public decimal? MenKursM { get; set; }

    public decimal? MenKursL { get; set; }

    public string? MenUrl { get; set; }

    public int? MenDokId { get; set; }

    public short? MenKndtyp { get; set; }

    public int? MenKndfirma { get; set; }

    public int? MenKndnumer { get; set; }

    public short? MenKndlp { get; set; }

    public string? MenCechaOpis { get; set; }

    public short? MenOpeWtyp { get; set; }

    public int? MenOpeWfirma { get; set; }

    public int? MenOpeWnumer { get; set; }

    public short? MenOpeWlp { get; set; }

    public short? MenOpeZtyp { get; set; }

    public int? MenOpeZfirma { get; set; }

    public int? MenOpeZnumer { get; set; }

    public short? MenOpeZlp { get; set; }

    public int? MenOpeTnumer { get; set; }

    public short? MenKnptyp { get; set; }

    public int? MenKnpnumer { get; set; }

    public short? MenWsSchtyp { get; set; }

    public int? MenWsSchnumer { get; set; }

    public byte? MenWsStosujSchemat { get; set; }

    public string? MenWsDziennik { get; set; }

    public byte? MenWsStosujDziennik { get; set; }

    public short? MenSchtyp { get; set; }

    public int? MenSchnumer { get; set; }

    public byte? MenKorekta { get; set; }

    public short? MenOrgtyp { get; set; }

    public int? MenOrgnumer { get; set; }

    public short? MenOpeTypZm { get; set; }

    public int? MenOpeNumerZm { get; set; }

    public int? MenTstampZm { get; set; }

    public short? MenOpeTypZfr { get; set; }

    public int? MenOpeNumerZfr { get; set; }

    public int? MenTstampZfr { get; set; }

    public byte? MenZatwMerytorycznie { get; set; }

    public byte? MenZatwFormalnoRach { get; set; }

    public string? MenGuid { get; set; }

    public int? MenOperatorPos { get; set; }

    public virtual ICollection<MemElem> MemElems { get; set; } = new List<MemElem>();
}
