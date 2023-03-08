using System;

using R5T.T0131;

using R5T.F0108.T000;
using R5T.F0108.T000.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface ISourceControlSystemNames : IValuesMarker
    {
        /// <summary>
        /// Git
        /// </summary>
        public const string Git_Constant = "Git";
        /// <summary>
        /// Subversion
        /// </summary>
        public const string Subversion_Constant = "Subversion";


        /// <inheritdoc cref="Git_Constant"/>
        public SourceControlSystemName Git => Git_Constant.ToSourceControlSystemName();

        /// <inheritdoc cref="Subversion_Constant"/>
        public SourceControlSystemName Subversion => Subversion_Constant.ToSourceControlSystemName();
    }
}
