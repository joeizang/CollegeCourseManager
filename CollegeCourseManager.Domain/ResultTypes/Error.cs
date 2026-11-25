using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeCourseManager.Domain.ResultTypes;

public class Error(string ErrorMessage, int ErrorCode = -1, bool ErrorRaised = false){}

public class ArgumentError(string Message) : Error(Message){}