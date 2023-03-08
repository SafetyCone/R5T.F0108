using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.F0108.T000
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class RepositoryName : TypedString, IStrongTypeMarker
    {
        public RepositoryName(string value)
            : base(value)
        {
        }
    }
}
