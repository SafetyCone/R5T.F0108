using System;


namespace R5T.F0108.Z000
{
    public class GitHubRepositoryOwnerNames : IGitHubRepositoryOwnerNames
    {
        #region Infrastructure

        public static IGitHubRepositoryOwnerNames Instance { get; } = new GitHubRepositoryOwnerNames();


        private GitHubRepositoryOwnerNames()
        {
        }

        #endregion
    }
}
