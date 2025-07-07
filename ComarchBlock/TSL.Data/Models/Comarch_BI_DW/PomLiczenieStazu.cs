using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class PomLiczenieStazu
{
    public long StId { get; set; }

    public int StKntstazid { get; set; }

    public int StKndstazid { get; set; }

    public int StAkwstazid { get; set; }

    public int StProdstazid { get; set; }

    public int StMkntstaz { get; set; }

    public int StMkndstaz { get; set; }

    public int StMakwstaz { get; set; }

    public int StMprodstaz { get; set; }
}
