using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Operacje
{
    public short? KaoGidtyp { get; set; }

    public int? KaoGidfirma { get; set; }

    public int KaoGidnumer { get; set; }

    public short KaoGidlp { get; set; }

    public string? KaoKod { get; set; }

    public string? KaoNazwa { get; set; }

    public byte? KaoRp { get; set; }

    public string? KaoKontoPrzec { get; set; }

    public int? KaoTyp { get; set; }

    public string? KaoCiagNumeracji { get; set; }

    public byte? KaoRodzajKursu { get; set; }

    public short? KaoNumerKursu { get; set; }

    public byte? KaoWplywaNaSrednia { get; set; }

    public short? KaoSchtyp { get; set; }

    public int? KaoSchfirma { get; set; }

    public int? KaoSchnumer { get; set; }

    public short? KaoSchlp { get; set; }

    public byte? KaoRodzajKategorii { get; set; }

    public byte? KaoEdycjaKategorii { get; set; }

    public short? KaoDataControllingowa { get; set; }

    public byte? KaoDataKsiegowania { get; set; }

    public byte? KaoZalozKonto { get; set; }

    public byte? KaoWyrazenie { get; set; }

    public int? KaoSymbolKonta { get; set; }

    public byte? KaoZaliczka { get; set; }

    public byte? KaoAnulowanie { get; set; }

    public byte? KaoNieRozliczaj { get; set; }

    public byte? KaoOddzial { get; set; }

    public byte? KaoArchiwalne { get; set; }

    public byte? KaoWynagrodzenie { get; set; }

    public byte? KaoZerujaca { get; set; }

    public byte? KaoLokata { get; set; }

    public byte? KaoTypDaty { get; set; }

    public byte? KaoDniPrzedData { get; set; }

    public byte? KaoWycWgKursuUstalonego { get; set; }

    public int? KaoCzasModyfikacji { get; set; }

    public short? KaoTypPodmiotu { get; set; }

    public byte? KaoSplitPayment { get; set; }

    public string? KaoTresc { get; set; }

    public byte? KaoBony { get; set; }

    public virtual ICollection<RejOp> RejOps { get; set; } = new List<RejOp>();

    public virtual ICollection<Zapisy> Zapisies { get; set; } = new List<Zapisy>();
}
