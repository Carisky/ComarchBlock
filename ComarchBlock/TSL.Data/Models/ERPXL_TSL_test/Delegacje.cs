using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Delegacje
{
    public short? DlgGidtyp { get; set; }

    public int? DlgGidfirma { get; set; }

    public int DlgGidnumer { get; set; }

    public short? DlgGidlp { get; set; }

    public int? DlgId { get; set; }

    public short? DlgStan { get; set; }

    public short? DlgRodzaj { get; set; }

    public int? DlgPrcnumer { get; set; }

    public int? DlgFrswlascicielNumer { get; set; }

    public int? DlgFrscentrumNumer { get; set; }

    public short? DlgPrjtyp { get; set; }

    public int? DlgPrjnumer { get; set; }

    public int? DlgTstampWpr { get; set; }

    public int? DlgOpenumerWpr { get; set; }

    public int? DlgPrcNumerWpr { get; set; }

    public int? DlgTstampAkcept { get; set; }

    public byte? DlgZaakceptowana { get; set; }

    public int? DlgOpenumerAkcept { get; set; }

    public int? DlgPrcNumerAkcept { get; set; }

    public int? DlgTstampAnul { get; set; }

    public int? DlgOpenumerAnul { get; set; }

    public int? DlgPrcNumerAnul { get; set; }

    public int? DlgTstampRozp { get; set; }

    public int? DlgTstampZak { get; set; }

    public byte? DlgZatwierdzona { get; set; }

    public decimal? DlgKwota { get; set; }

    public decimal? DlgDoWyplaty { get; set; }

    public string? DlgWaluta { get; set; }

    public short? DlgRok { get; set; }

    public short? DlgMiesiac { get; set; }

    public string? DlgSeria { get; set; }

    public int? DlgNumer { get; set; }

    public string? DlgMiejsce { get; set; }

    public string? DlgCel { get; set; }

    public short? DlgWyjazdZmiejscaZam { get; set; }

    public int? DlgTstampRozl { get; set; }

    public int? DlgTstampMod { get; set; }

    public int? DlgOpenumerMod { get; set; }

    public int? DlgPrcNumerMod { get; set; }

    public byte? DlgPokazKomentarz { get; set; }

    public string? DlgKomentarz { get; set; }

    public int? DlgTstampAkceptWpr { get; set; }

    public int? DlgOpenumerAkceptWpr { get; set; }

    public int? DlgPrcNumerAkceptWpr { get; set; }

    public int? DlgTstampZatw { get; set; }

    public int? DlgOpenumerZatw { get; set; }

    public int? DlgPrcNumerZatw { get; set; }

    public byte? DlgZaksiegowano { get; set; }

    public byte? DlgNieKsiegowac { get; set; }

    public int? DlgDataKsiegowania { get; set; }

    public short? DlgSposobGenPlatnosci { get; set; }

    public int? DlgAktywny { get; set; }

    public byte? DlgTrybWstawiania { get; set; }

    public string? DlgDziennik { get; set; }

    public short? DlgSchtyp { get; set; }

    public int? DlgSchnumer { get; set; }

    public byte? DlgWsStosujSchemat { get; set; }

    public short? DlgWsSchtyp { get; set; }

    public int? DlgWsSchnumer { get; set; }

    public string? DlgWsDziennik { get; set; }

    public byte? DlgWsStosujDziennik { get; set; }

    public int? DlgTstampWprdoAkcept { get; set; }

    public int? DlgOpeNumerWprdoAkcept { get; set; }

    public int? DlgPrcNumerWprdoAkcept { get; set; }

    public string? DlgImie { get; set; }

    public string? DlgNazwisko { get; set; }

    public virtual ICollection<Zapisy> DlrKaznumers { get; set; } = new List<Zapisy>();
}
