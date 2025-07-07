using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktKompletacjaDekompletacja
{
    public int ZkdCzdprgid { get; set; }

    public int ZkdCzdrelGid { get; set; }

    public int ZkdCzdpgid { get; set; }

    public int ZkdAlokacjaGid { get; set; }

    public int ZkdBudzetGid { get; set; }

    public int ZkdCzdrgid { get; set; }

    public int ZkdDokNumerGidpw { get; set; }

    public int ZkdDokNumerGidrw { get; set; }

    public int ZkdDokNumerGid { get; set; }

    public int ZkdCzdrzgid { get; set; }

    public int ZkdCzdwgid { get; set; }

    public int ZkdDokNumerZk { get; set; }

    public int ZkdProdGid { get; set; }

    public int ZkdMagRelGid { get; set; }

    public int ZkdRecgid { get; set; }

    public int ZkdMagPwgid { get; set; }

    public int ZkdSklGid { get; set; }

    public int ZkdMagSklGid { get; set; }

    public int ZkdMagGid { get; set; }

    public int ZkdKntGid { get; set; }

    public int ZkdMagProdGid { get; set; }

    public int ZkdMagRwgid { get; set; }

    public int ZkdId { get; set; }

    public int ZkdCzdgid { get; set; }

    public int ZkdZrodgid { get; set; }

    public string ZkdOrgId { get; set; } = null!;

    public string ZkdDirtyOrgId { get; set; } = null!;

    public string? ZkdOpis { get; set; }

    public DateTime ZkdTsinsert { get; set; }

    public DateTime ZkdTsupdate { get; set; }

    public int ZkdUpdateSubTransformationId { get; set; }

    public int? ZkdUpdateTransformationId { get; set; }

    public int ZkdInsertSubTransformationId { get; set; }

    public int? ZkdInsertTransformationId { get; set; }

    public decimal? ZkdMdokumentWartosc { get; set; }

    public decimal? ZkdMrealizacjaIlosc { get; set; }

    public decimal? ZkdMrealizacjaKoszt { get; set; }

    public decimal? ZkdMrealizacjaKosztDokPw { get; set; }

    public decimal? ZkdMrealizacjaKosztDokRw { get; set; }

    public decimal? ZkdMrealizacjaKosztPw { get; set; }

    public decimal? ZkdMrealizacjaKosztRw { get; set; }

    public decimal? ZkdMrealizacjaPwilosc { get; set; }

    public decimal? ZkdMrealizacjaRwilosc { get; set; }

    public decimal? ZkdMrecNagKosztEwidencyjny { get; set; }

    public decimal? ZkdMrecProdIlosc { get; set; }

    public decimal? ZkdMrecSklIlosc { get; set; }

    public decimal? ZkdMrecSklKosztEwidencyjny { get; set; }

    public decimal? ZkdMzcEsklIlosc { get; set; }

    public decimal? ZkdMzlcNagKosztEwidencyjny { get; set; }

    public decimal? ZkdMzlcNagKosztRzeczywisty { get; set; }

    public string? ZkdMzlcProdIlosc { get; set; }

    public decimal? ZkdMzlcSklIlosc { get; set; }

    public decimal? ZkdMzlcSklKosztEwidencyjny { get; set; }

    public decimal? ZkdMzlcSklKosztRzeczywisty { get; set; }

    public int? ZkdTyp { get; set; }

    public string? ZkdTypPozycji { get; set; }
}
