namespace CollegeCourseManager.Domain.ResultTypes;

public sealed record Success<T>(T Value);

public sealed record DomainError(string ErrorMessage, int ErrorCode = -1);

public readonly union Result<T, E>(T, E);