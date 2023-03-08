using System;


namespace R5T.F0108.Z000
{
    public class SourceControlSystemNames : ISourceControlSystemNames
    {
        #region Infrastructure

        public static ISourceControlSystemNames Instance { get; } = new SourceControlSystemNames();


        private SourceControlSystemNames()
        {
        }

        #endregion
    }
}
