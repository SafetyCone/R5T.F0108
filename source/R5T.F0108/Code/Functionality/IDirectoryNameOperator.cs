using System;

using R5T.T0132;

using R5T.F0108.T000;
using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;
using R5T.F0108.Z000;


namespace R5T.F0108
{
    [FunctionalityMarker]
    public partial interface IDirectoryNameOperator : IFunctionalityMarker,
        F0000.IDirectoryNameOperator
    {
        public CodeEnvironmentDirectoryName Get_CodeEnvironmentDirectoryName(CodeEnvironmentName codeEnvironmentName)
        {
            var output = codeEnvironmentName.Value switch
            {
                ICodeEnvironmentNames.Development_Constant => Instances.CodeEnvironmentDirectoryNames.Development,
                ICodeEnvironmentNames.Production_Constant => Instances.CodeEnvironmentDirectoryNames.Production,
                _ => throw Instances.ExceptionOperator.Get_UnhandledValueException(codeEnvironmentName)
            };

            return output;
        }

        public RemoteRepositoryServiceDirectoryName Get_RemoteRepositoryServiceDirectoryName(RemoteRepositoryServiceName remoteRepositoryServiceName)
        {
            var directoryName = this.ConvertToDirectoryName(remoteRepositoryServiceName.Value);

            var output = directoryName.ToRemoteRepositoryServiceDirectoryName();
            return output;
        }

        public RepositoryDirectoryName Get_RepositoryDirectoryName(RepositoryName repositoryName)
        {
            var directoryName = this.ConvertToDirectoryName(repositoryName.Value);

            var output = directoryName.ToRepositoryDirectoryName();
            return output;
        }

        public GitHubRepositoryOwnerDirectoryName Get_GitHubRepositoryOwnerDirectoryName(GitHubRepositoryOwnerName gitHubRepositoryOwnerName)
        {
            var output = gitHubRepositoryOwnerName.Value switch
            {
                IGitHubRepositoryOwnerNames.DavidCoats_Constant => Instances.GitHubRepositoryOwnerDirectoryNames.David_Coats,
                IGitHubRepositoryOwnerNames.SafetyCone_Constant => Instances.GitHubRepositoryOwnerDirectoryNames.Safety_Cone,
                _ => throw Instances.ExceptionOperator.Get_UnhandledValueException(gitHubRepositoryOwnerName)
            };

            return output;
        }

        public SourceControlSystemDirectoryName Get_SourceControlSystemDirectoryName(SourceControlSystemName sourceControlSystemName)
        {
            var output = sourceControlSystemName.Value switch
            {
                ISourceControlSystemNames.Git_Constant => Instances.SourceControlSystemDirectoryNames.Git,
                ISourceControlSystemNames.Subversion_Constant => Instances.SourceControlSystemDirectoryNames.Subversion,
                _ => throw Instances.ExceptionOperator.Get_UnhandledValueException(sourceControlSystemName)
            };

            return output;
        }
    }
}
