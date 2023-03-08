using System;


namespace R5T.F0108.Z000
{
    public class CodeEnvironmentNames : ICodeEnvironmentNames
    {
        #region Infrastructure

        public static ICodeEnvironmentNames Instance { get; } = new CodeEnvironmentNames();


        private CodeEnvironmentNames()
        {
        }

        #endregion
    }
}
