using System;


namespace R5T.F0108.Z000
{
    public class CodeEnvironmentDirectoryNames : ICodeEnvironmentDirectoryNames
    {
        #region Infrastructure

        public static ICodeEnvironmentDirectoryNames Instance { get; } = new CodeEnvironmentDirectoryNames();


        private CodeEnvironmentDirectoryNames()
        {
        }

        #endregion
    }
}
