namespace EnsureCore.Extensions
{
    public static class EnsureExtensions
    {
        public static T NotNull<T>(this IEnsureClause clause, T? input, string parameterName, string message = null)
        {
            if (input is null)
            {
                if (string.IsNullOrEmpty(message))
                {
                    throw new ArgumentNullException(parameterName);
                }

                throw new ArgumentNullException(parameterName, message);
            }

            return input;
        }
    }
}
