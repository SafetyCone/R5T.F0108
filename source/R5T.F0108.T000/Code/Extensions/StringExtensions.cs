using System;


namespace R5T.F0108.T000.Extensions
{
    public static class StringExtensions
    {
        public static CodeEnvironmentName ToCodeEnvironmentName(this string value)
        {
            return StringOperator.Instance.ToCodeEnvironmentName(value);
        }

        public static GitHubRepositoryOwnerName ToGitHubRepositoryOwnerName(this string value)
        {
            return StringOperator.Instance.ToGitHubRepositoryOwnerName(value);
        }

        public static RemoteRepositoryServiceName ToRemoteRepositoryServiceName(this string value)
        {
            return StringOperator.Instance.ToRemoteRepositoryServiceName(value);
        }

        public static RepositoryName ToRepositoryName(this string value)
        {
            return StringOperator.Instance.ToRepositoryName(value);
        }

        public static SourceControlSystemName ToSourceControlSystemName(this string value)
        {
            return StringOperator.Instance.ToSourceControlSystemName(value);
        }

        public static UnadjustedRepositoryName ToUnadjustedRepositoryName(this string value)
        {
            return StringOperator.Instance.ToUnadjustedRepositoryName(value);
        }
    }
}
