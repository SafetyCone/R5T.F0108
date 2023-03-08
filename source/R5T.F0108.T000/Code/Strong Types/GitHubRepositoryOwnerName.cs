using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.F0108.T000
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class GitHubRepositoryOwnerName : TypedString, IStrongTypeMarker
    {
        public GitHubRepositoryOwnerName(string value)
            : base(value)
        {
        }
    }
}
