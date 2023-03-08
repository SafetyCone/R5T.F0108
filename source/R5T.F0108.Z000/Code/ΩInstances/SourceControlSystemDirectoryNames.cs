using System;


namespace R5T.F0108.Z000
{
    public class SourceControlSystemDirectoryNames : ISourceControlSystemDirectoryNames
    {
        #region Infrastructure

        public static ISourceControlSystemDirectoryNames Instance { get; } = new SourceControlSystemDirectoryNames();


        private SourceControlSystemDirectoryNames()
        {
        }

        #endregion
    }
}
