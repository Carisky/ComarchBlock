using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Boelem
{
    public int BoeBoeid { get; set; }

    public int BoeBonid { get; set; }

    public int BoeAccId { get; set; }

    public int? BoeAccPrevId { get; set; }

    public decimal BoeKwotaWn { get; set; }

    public decimal BoeKwotaMa { get; set; }

    public decimal BoeKwotaWnWal { get; set; }

    public decimal BoeKwotaMaWal { get; set; }

    public string BoeWaluta { get; set; } = null!;

    public int BoeKursNumer { get; set; }

    public decimal BoeKursL { get; set; }

    public decimal BoeKursM { get; set; }

    public short? BoeDokumentTyp { get; set; }

    public int? BoeDokumentId { get; set; }

    public int BoePlatnosci { get; set; }

    public int? BoeFplId { get; set; }

    public DateTime? BoeTermin { get; set; }

    public DateTime? BoeDataDok { get; set; }

    public DateTime BoeDataKur { get; set; }

    public string BoeDokument { get; set; } = null!;

    public int? BoeRozrachunki { get; set; }

    public short? BoeBezRozliczenia { get; set; }

    public DateTime? BoeTerminRoz { get; set; }

    public virtual Kontum BoeAcc { get; set; } = null!;

    public virtual Bonag BoeBon { get; set; } = null!;
}
