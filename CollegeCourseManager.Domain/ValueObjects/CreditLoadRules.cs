using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ValueObjects;
public sealed record CreditLoadRules
{
    [Range(0, 10)]
    public float MinimumCreditUnit { get; init; }

    [Range(0, 10)]
    public float MaximumCreditUnit { get; init; }

    [Range(0, 10000)]
    public float TotalCreditUnitsForGraduation { get; init; }
}
