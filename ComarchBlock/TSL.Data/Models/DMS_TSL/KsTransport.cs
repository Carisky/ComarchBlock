using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class KsTransport
{
    public int KsnId { get; set; }

    public int KsnDocumentId { get; set; }

    public byte? KsnWarunkiTransakcjiRodzajTransportu { get; set; }

    public short? KsnWarunkiTransakcjiTransportInny { get; set; }

    public string? KsnWarunkiTransakcjiOpisInnegoTransportu { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikNip { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikKodUe { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikNrUe { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikKodKraju { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikNrId { get; set; }

    public bool? KsnWarunkiTransakcjiPrzewoznikBrakId { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikNazwa { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikAdres { get; set; }

    public string? KsnWarunkiTransakcjiPrzewoznikGln { get; set; }

    public string? KsnWarunkiTransakcjiNrZleceniaTransportu { get; set; }

    public byte? KsnWarunkiTransakcjiOpisLadunku { get; set; }

    public short? KsnWarunkiTransakcjiLadunekInny { get; set; }

    public string? KsnWarunkiTransakcjiOpisInnegoLadunku { get; set; }

    public string? KsnWarunkiTransakcjiJednostkaOpakowania { get; set; }

    public DateTime? KsnWarunkiTransakcjiDataGodzRozpTransportu { get; set; }

    public DateTime? KsnWarunkiTransakcjiDataGodzZakTransportu { get; set; }

    public virtual ICollection<KsShipmentAddress> KsShipmentAddresses { get; set; } = new List<KsShipmentAddress>();

    public virtual KsDocument KsnDocument { get; set; } = null!;
}
