using System;

using R5T.T0131;

using R5T.F0108.T000;
using R5T.F0108.T000.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface IGitHubRepositoryOwnerNames : IValuesMarker
    {
        /// <summary>
        /// David Coats
        /// </summary>
        public const string DavidCoats_Constant = "David Coats";

        /// <summary>
        /// Safety Cone
        /// </summary>
        public const string SafetyCone_Constant = "Safety Cone";


        /// <inheritdoc cref="DavidCoats_Constant"/>
        public GitHubRepositoryOwnerName David_Coats => DavidCoats_Constant.ToGitHubRepositoryOwnerName();

        /// <inheritdoc cref="SafetyCone_Constant"/>
        public GitHubRepositoryOwnerName Safety_Cone => SafetyCone_Constant.ToGitHubRepositoryOwnerName();
    }
}
