namespace Ensure
{
    /// <summary>
    /// Ensure
    /// </summary>
    public class Ensure : IEnsureClause
    {
        public static IEnsureClause Is => new Ensure();

        private Ensure()
        { 
        }
    }
}