using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Piknag
{
    public short? PinGidtyp { get; set; }

    public int? PinGidfirma { get; set; }

    public int PinGidnumer { get; set; }

    public short? PinGidlp { get; set; }

    public string? PinIdentyfikator { get; set; }

    public string? PinNazwaFirmy { get; set; }

    public string? PinOpis { get; set; }

    public int? PinTstamp { get; set; }

    public int? PinDokId { get; set; }

    public short? PinRok { get; set; }

    public short? PinMiesiac { get; set; }

    public int? PinNumer { get; set; }

    public int? PinData { get; set; }

    public int? PinDataWyst { get; set; }

    public byte? PinZaksiegowano { get; set; }

    public byte? PinNieKsiegowac { get; set; }

    public int? PinDataKsiegowania { get; set; }

    public string? PinDziennik { get; set; }

    public short? PinSchtyp { get; set; }

    public int? PinSchfirma { get; set; }

    public int? PinSchnumer { get; set; }

    public short? PinSchlp { get; set; }

    public short? PinPdntyp { get; set; }

    public int? PinPdnfirma { get; set; }

    public int? PinPdnnumer { get; set; }

    public int? PinPdnlp { get; set; }

    public string? PinCechaOpis { get; set; }

    public int? PinAktywny { get; set; }

    public int? PinOptima { get; set; }

    public byte? PinWyplatySumarycznie { get; set; }

    public byte? PinRodzajOpisu { get; set; }

    public byte? PinKategoria { get; set; }

    public short? PinWsSchtyp { get; set; }

    public int? PinWsSchnumer { get; set; }

    public byte? PinWsStosujSchemat { get; set; }

    public string? PinWsDziennik { get; set; }

    public byte? PinWsStosujDziennik { get; set; }

    public int? PinKorektado { get; set; }

    public short? PinOddelegowani { get; set; }

    public string? PinWaluta { get; set; }

    public decimal? PinKursL { get; set; }

    public decimal? PinKursM { get; set; }

    public virtual ICollection<Pikelem> Pikelems { get; set; } = new List<Pikelem>();
}
