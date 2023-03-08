using System;


namespace R5T.F0108.Z000
{
    public class CodeDirectoryPaths : ICodeDirectoryPaths
    {
        #region Infrastructure

        public static ICodeDirectoryPaths Instance { get; } = new CodeDirectoryPaths();


        private CodeDirectoryPaths()
        {
        }

        #endregion
    }
}
