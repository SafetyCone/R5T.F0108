using System;


namespace R5T.F0108.Z000
{
    public class GitHubRepositoryOwnerDirectoryNames : IGitHubRepositoryOwnerDirectoryNames
    {
        #region Infrastructure

        public static IGitHubRepositoryOwnerDirectoryNames Instance { get; } = new GitHubRepositoryOwnerDirectoryNames();


        private GitHubRepositoryOwnerDirectoryNames()
        {
        }

        #endregion
    }
}
