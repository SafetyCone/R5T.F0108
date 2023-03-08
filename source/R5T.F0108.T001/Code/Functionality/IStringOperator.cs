using System;

using R5T.T0132;


namespace R5T.F0108.T001
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public CodeDirectoryPath ToCodeDirectoryPath(string value)
        {
            var output = new CodeDirectoryPath(value);
            return output;
        }

        public CodeEnvironmentDirectoryName ToCodeEnvironmentDirectoryName(string value)
        {
            var output = new CodeEnvironmentDirectoryName(value);
            return output;
        }

        public GitHubRepositoryOwnerDirectoryName ToGitHubRepositoryOwnerDirectoryName(string value)
        {
            var output = new GitHubRepositoryOwnerDirectoryName(value);
            return output;
        }

        public RemoteRepositoryServiceDirectoryName ToRemoteRepositoryServiceDirectoryName(string value)
        {
            var output = new RemoteRepositoryServiceDirectoryName(value);
            return output;
        }

        public RepositoryDirectoryName ToRepositoryDirectoryName(string value)
        {
            var output = new RepositoryDirectoryName(value);
            return output;
        }

        public SourceControlSystemDirectoryName ToSourceControlSystemDirectoryName(string value)
        {
            var output = new SourceControlSystemDirectoryName(value);
            return output;
        }

        public RepositoryDirectoryPath ToRepositoryDirectoryPath(string value)
        {
            var output = new RepositoryDirectoryPath(value);
            return output;
        }
    }
}
