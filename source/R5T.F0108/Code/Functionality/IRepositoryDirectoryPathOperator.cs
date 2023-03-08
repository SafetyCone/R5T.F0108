using System;

using R5T.T0132;

using R5T.F0108.T000;
using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;


namespace R5T.F0108
{
    [FunctionalityMarker]
    public partial interface IRepositoryDirectoryPathOperator : IFunctionalityMarker
    {
        public RepositoryDirectoryPath Get_RepositoryDirectoryPath(
            CodeDirectoryPath codeDirectoryPath,
            CodeEnvironmentDirectoryName codeEnvironmentDirectoryName,
            SourceControlSystemDirectoryName sourceControlSystemDirectoryName,
            RemoteRepositoryServiceDirectoryName remoteRepositoryServiceDirectoryName,
            GitHubRepositoryOwnerDirectoryName gitHubRepositoryOwnerDirectoryName,
            RepositoryDirectoryName repositoryDirectoryName)
        {
            var repositoryDirectoryPath = Instances.PathOperator.GetDirectoryPath(
                codeDirectoryPath.Value,
                codeEnvironmentDirectoryName.Value,
                sourceControlSystemDirectoryName.Value,
                remoteRepositoryServiceDirectoryName.Value,
                gitHubRepositoryOwnerDirectoryName.Value,
                repositoryDirectoryName.Value);

            var output = repositoryDirectoryPath.ToRepositoryDirectoryPath();
            return output;
        }

        public RepositoryDirectoryPath Get_RepositoryDirectoryPath(
            CodeDirectoryPath codeDirectoryPath,
            CodeEnvironmentName codeEnvironmentName,
            SourceControlSystemName sourceControlSystemName,
            RemoteRepositoryServiceName remoteRepositoryServiceName,
            GitHubRepositoryOwnerName gitHubRepositoryOwnerName,
            RepositoryName repositoryName)
        {
            var codeEnvironmentDirectoryName = Instances.DirectoryNameOperator.Get_CodeEnvironmentDirectoryName(codeEnvironmentName);
            var sourceControlSystemDirectoryName = Instances.DirectoryNameOperator.Get_SourceControlSystemDirectoryName(sourceControlSystemName);
            var remoteRepositoryServiceDirectoryName = Instances.DirectoryNameOperator.Get_RemoteRepositoryServiceDirectoryName(remoteRepositoryServiceName);
            var gitHubRepositoryOwnerDirectoryName = Instances.DirectoryNameOperator.Get_GitHubRepositoryOwnerDirectoryName(gitHubRepositoryOwnerName);
            var repositoryDirectoryName = Instances.DirectoryNameOperator.Get_RepositoryDirectoryName(repositoryName);

            var output = this.Get_RepositoryDirectoryPath(
                codeDirectoryPath,
                codeEnvironmentDirectoryName,
                sourceControlSystemDirectoryName,
                remoteRepositoryServiceDirectoryName,
                gitHubRepositoryOwnerDirectoryName,
                repositoryDirectoryName);

            return output;
        }

        public RepositoryDirectoryPath Get_RepositoryDirectoryPath(
            GitHubRepositoryOwnerName gitHubRepositoryOwnerName,
            UnadjustedRepositoryName unadjustedRepositoryName,
            bool isPrivate)
        {
            var repositoryName = Instances.RepositoryNameOperator.Get_RepositoryName(
                unadjustedRepositoryName,
                isPrivate);

            var output = this.Get_RepositoryDirectoryPath(
                Instances.CodeDirectoryPaths.Code,
                Instances.CodeEnvironmentNames.Development,
                Instances.SourceControlSystemNames.Git,
                Instances.RemoteRepositoryServiceNames.GitHub,
                gitHubRepositoryOwnerName,
                repositoryName);

            return output;
        }
    }
}
