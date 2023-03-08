using System;


namespace R5T.F0108.T001.Extensions
{
    public static class StringExtensions
    {
        public static CodeDirectoryPath ToCodeDirectoryPath(this string value)
        {
            return StringOperator.Instance.ToCodeDirectoryPath(value);
        }

        public static CodeEnvironmentDirectoryName ToCodeEnvironmentDirectoryName(this string value)
        {
            return StringOperator.Instance.ToCodeEnvironmentDirectoryName(value);
        }

        public static GitHubRepositoryOwnerDirectoryName ToGitHubRepositoryOwnerDirectoryName(this string value)
        {
            return StringOperator.Instance.ToGitHubRepositoryOwnerDirectoryName(value);
        }

        public static RemoteRepositoryServiceDirectoryName ToRemoteRepositoryServiceDirectoryName(this string value)
        {
            return StringOperator.Instance.ToRemoteRepositoryServiceDirectoryName(value);
        }

        public static RepositoryDirectoryName ToRepositoryDirectoryName(this string value)
        {
            return StringOperator.Instance.ToRepositoryDirectoryName(value);
        }

        public static RepositoryDirectoryPath ToRepositoryDirectoryPath(this string value)
        {
            return StringOperator.Instance.ToRepositoryDirectoryPath(value);
        }

        public static SourceControlSystemDirectoryName ToSourceControlSystemDirectoryName(this string value)
        {
            return StringOperator.Instance.ToSourceControlSystemDirectoryName(value);
        }
    }
}
