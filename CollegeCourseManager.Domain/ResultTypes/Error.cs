using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ResultTypes;

public sealed record Error<E>(E ErrorPayload);

