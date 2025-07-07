using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_META;

public partial class Key
{
    public int KeyId { get; set; }

    public string KeyName { get; set; } = null!;

    public string KeyType { get; set; } = null!;

    public string KeyDefinition { get; set; } = null!;

    public DateTime KeyDate { get; set; }

    public string KeyStatus { get; set; } = null!;

    public string KeyServer { get; set; } = null!;

    public string KeyDatabase { get; set; } = null!;

    public string KeyCubeName { get; set; } = null!;

    public string KeyDimension { get; set; } = null!;

    public string KeyXmlDefinition { get; set; } = null!;
}
