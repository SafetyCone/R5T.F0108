using System;


namespace R5T.F0108
{
    public static class Instances
    {
        public static Z000.ICodeDirectoryPaths CodeDirectoryPaths => Z000.CodeDirectoryPaths.Instance;
		public static Z000.ICodeEnvironmentDirectoryNames CodeEnvironmentDirectoryNames => Z000.CodeEnvironmentDirectoryNames.Instance;
        public static Z000.ICodeEnvironmentNames CodeEnvironmentNames => Z000.CodeEnvironmentNames.Instance;
        public static IDirectoryNameOperator DirectoryNameOperator => F0108.DirectoryNameOperator.Instance;
        public static F0000.IExceptionOperator ExceptionOperator => F0000.ExceptionOperator.Instance;
        public static Z000.IGitHubRepositoryOwnerDirectoryNames GitHubRepositoryOwnerDirectoryNames => Z000.GitHubRepositoryOwnerDirectoryNames.Instance;
        public static F0044.INameOperator NameOperator => F0044.NameOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IRepositoryNameOperator RepositoryNameOperator => F0108.RepositoryNameOperator.Instance;
        public static Z000.IRemoteRepositoryServiceNames RemoteRepositoryServiceNames => Z000.RemoteRepositoryServiceNames.Instance;
        public static Z000.ISourceControlSystemDirectoryNames SourceControlSystemDirectoryNames => Z000.SourceControlSystemDirectoryNames.Instance;
        public static Z000.ISourceControlSystemNames SourceControlSystemNames => Z000.SourceControlSystemNames.Instance;
    }
}