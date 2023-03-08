using System;

using R5T.T0131;

using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryOwnerDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// davidcoats
        /// </summary>
        public const string DavidCoats_Constant = "davidcoats";
        /// <summary>
        /// SafetyCone
        /// </summary>
        public const string SafetyCone_Constant = "SafetyCone";


        /// <inheritdoc cref="DavidCoats_Constant"/>
        public GitHubRepositoryOwnerDirectoryName David_Coats => DavidCoats_Constant.ToGitHubRepositoryOwnerDirectoryName();

        /// <inheritdoc cref="SafetyCone_Constant"/>
        public GitHubRepositoryOwnerDirectoryName Safety_Cone => SafetyCone_Constant.ToGitHubRepositoryOwnerDirectoryName();
    }
}
