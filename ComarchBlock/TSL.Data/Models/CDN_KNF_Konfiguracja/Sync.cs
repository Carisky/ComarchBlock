using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Sync
{
    public int SncSncId { get; set; }

    public int? SncBazId { get; set; }

    public byte SncEsklep { get; set; }

    public DateTime? SncEsklepExpSlowOd { get; set; }

    public DateTime? SncEsklepExpSlowDo { get; set; }

    public int? SncEsklepExpSlowCo { get; set; }

    public DateTime? SncEsklepIpeod { get; set; }

    public DateTime? SncEsklepIpedo { get; set; }

    public int? SncEsklepIpeco { get; set; }

    public int? SncEsklepExpKnt { get; set; }

    public int? SncEsklepOpeId { get; set; }

    public string? SncEsklepOpeHaslo { get; set; }

    public int SncEsklepRealizacjaRo { get; set; }

    public DateTime SncEsklepRealizacjaRodata { get; set; }

    public int SncEsklepWydrukId { get; set; }

    public int SncEsklepWydrukTyp { get; set; }

    public int SncEsklepGenerowanieZnp { get; set; }

    public byte SncXl { get; set; }

    public DateTime? SncXlod { get; set; }

    public DateTime? SncXldo { get; set; }

    public int? SncXlco { get; set; }

    public int? SncXlopeId { get; set; }

    public string? SncXlopeHaslo { get; set; }

    public byte SncDetal { get; set; }

    public DateTime? SncDetalOd { get; set; }

    public DateTime? SncDetalDo { get; set; }

    public int? SncDetalCo { get; set; }

    public int? SncDetalOpeId { get; set; }

    public string? SncDetalOpeHaslo { get; set; }

    public byte SncEpracownikDaneKadrowe { get; set; }

    public DateTime? SncEpracownikDaneKadroweOd { get; set; }

    public DateTime? SncEpracownikDaneKadroweDo { get; set; }

    public int? SncEpracownikDaneKadroweCo { get; set; }

    public byte SncEpracownikDaneBinarne { get; set; }

    public DateTime? SncEpracownikDaneBinarneOd { get; set; }

    public DateTime? SncEpracownikDaneBinarneDo { get; set; }

    public int? SncEpracownikDaneBinarneCo { get; set; }

    public byte SncApfino { get; set; }

    public DateTime? SncApfinoOd { get; set; }

    public DateTime? SncApfinoDo { get; set; }

    public int? SncApfinoCo { get; set; }

    public byte SncApfinoKnt { get; set; }

    public byte SncApfinoFakt { get; set; }

    public byte SncApfinoPlat { get; set; }

    public int? SncApfinoOpeId { get; set; }

    public string? SncApfinoOpeHaslo { get; set; }

    public DateTime? SncApfinoStart { get; set; }

    public int? SncOpeZalId { get; set; }

    public DateTime SncTsZal { get; set; }

    public string SncOpeZalKod { get; set; } = null!;

    public string SncOpeZalNazwisko { get; set; } = null!;

    public int? SncOpeModId { get; set; }

    public DateTime SncTsMod { get; set; }

    public string SncOpeModKod { get; set; } = null!;

    public string SncOpeModNazwisko { get; set; } = null!;

    public int? SncStaZalId { get; set; }

    public int? SncStaModId { get; set; }

    public virtual Operatorzy? SncApfinoOpe { get; set; }

    public virtual Bazy? SncBaz { get; set; }

    public virtual Operatorzy? SncDetalOpe { get; set; }

    public virtual Operatorzy? SncEsklepOpe { get; set; }

    public virtual Operatorzy? SncXlope { get; set; }
}
