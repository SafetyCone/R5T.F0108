using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.F0108.T001
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class RepositoryDirectoryPath : TypedString, IStrongTypeMarker
    {
        public RepositoryDirectoryPath(string value)
            : base(value)
        {
        }
    }
}
