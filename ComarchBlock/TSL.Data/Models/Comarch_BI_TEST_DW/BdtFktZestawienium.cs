using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktZestawienium
{
    public long ZksId { get; set; }

    public int ZksAlokacjaId { get; set; }

    public string ZksZstOrgId { get; set; } = null!;

    public string? ZksZstnazwa { get; set; }

    public int? ZksWymTyp { get; set; }

    public string? ZksWymObjGidLp { get; set; }

    public int? ZksTypKwoty { get; set; }

    public decimal? ZksPrzelicznikWaluty { get; set; }

    public int? ZksPaczka { get; set; }

    public string? ZksOrgWymId { get; set; }

    public string? ZksOrgAtrId { get; set; }

    public int? ZksKierunek { get; set; }

    public decimal? ZksMkwotaOrg { get; set; }

    public decimal? ZksMkwota { get; set; }

    public int ZksZstid { get; set; }

    public int ZksZrodgid { get; set; }

    public int ZksWalutaId { get; set; }

    public int ZksStrFrmId { get; set; }

    public int ZksProjektId { get; set; }

    public int ZksPlatId { get; set; }

    public int ZksPerspektywaId { get; set; }

    public int ZksLokId { get; set; }

    public int ZksKontoId { get; set; }

    public int ZksKntId { get; set; }

    public int ZksKndId { get; set; }

    public int ZksKatFinId { get; set; }

    public int ZksFirmaId { get; set; }

    public int ZksDziennikId { get; set; }

    public int ZksCzmid { get; set; }

    public int ZksCzdid { get; set; }

    public int ZksBuforId { get; set; }

    public int ZksBudzetId { get; set; }

    public int ZksUpdateTransformationId { get; set; }

    public int? ZksUpdateSubTransformationId { get; set; }

    public DateTime ZksTsupdate { get; set; }

    public DateTime ZksTsinsert { get; set; }

    public string ZksOrgId { get; set; } = null!;

    public string? ZksOpis { get; set; }

    public int? ZksInsertSubTransformationId { get; set; }

    public string ZksDirtyOrgId { get; set; } = null!;

    public int? WsadInsertId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02116Id { get; set; }

    public int? Wym02119Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }
}
