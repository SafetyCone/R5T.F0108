using System;

using R5T.T0131;

using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface ISourceControlSystemDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// Git
        /// </summary>
        public const string Git_Constant = "Git";
        /// <summary>
        /// SVN
        /// </summary>
        public const string Subversion_Constant = "SVN";


        /// <inheritdoc cref="Git_Constant"/>
        public SourceControlSystemDirectoryName Git => Git_Constant.ToSourceControlSystemDirectoryName();

        /// <inheritdoc cref="Subversion_Constant"/>
        public SourceControlSystemDirectoryName Subversion => Subversion_Constant.ToSourceControlSystemDirectoryName();
    }
}
