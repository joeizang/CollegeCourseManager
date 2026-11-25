using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ValueObjects;
public sealed record ProgrammeTenure(int MinimumDuration, int MaximumDuration);