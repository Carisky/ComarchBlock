using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class RegistrationUserModel
{
    public int RumId { get; set; }

    public string RumLogin { get; set; } = null!;

    public int RumDataModelsDefinitionId { get; set; }

    public virtual DataModelsDefinition RumDataModelsDefinition { get; set; } = null!;
}
