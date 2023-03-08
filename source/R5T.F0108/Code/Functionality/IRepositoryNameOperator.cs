using System;

using R5T.T0132;

using R5T.F0108.T000;
using R5T.F0108.T000.Extensions;


namespace R5T.F0108
{
    [FunctionalityMarker]
    public partial interface IRepositoryNameOperator : IFunctionalityMarker
    {
        public RepositoryName Get_RepositoryName(
            UnadjustedRepositoryName unadjustedRepositoryName,
            bool isPrivate)
        {
            var repositoryName = Instances.NameOperator.AdjustNameForPrivacy(
                unadjustedRepositoryName.Value,
                isPrivate);

            var output = repositoryName.ToRepositoryName();
            return output;
        }
    }
}
