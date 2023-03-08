using System;

using R5T.T0132;


namespace R5T.F0108.T000
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public CodeEnvironmentName ToCodeEnvironmentName(string value)
        {
            var output = new CodeEnvironmentName(value);
            return output;
        }

        public GitHubRepositoryOwnerName ToGitHubRepositoryOwnerName(string value)
        {
            var output = new GitHubRepositoryOwnerName(value);
            return output;
        }

        public RemoteRepositoryServiceName ToRemoteRepositoryServiceName(string value)
        {
            var output = new RemoteRepositoryServiceName(value);
            return output;
        }

        public RepositoryName ToRepositoryName(string value)
        {
            var output = new RepositoryName(value);
            return output;
        }

        public SourceControlSystemName ToSourceControlSystemName(string value)
        {
            var output = new SourceControlSystemName(value);
            return output;
        }

        public UnadjustedRepositoryName ToUnadjustedRepositoryName(string value)
        {
            var output = new UnadjustedRepositoryName(value);
            return output;
        }
    }
}
