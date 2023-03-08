using System;

using R5T.T0150;
using R5T.T0151;


namespace R5T.F0108.T000
{
    /// <summary>
    /// 
    /// </summary>
    [StrongTypeMarker]
    public class CodeEnvironmentName : TypedString, IStrongTypeMarker
    {
        public CodeEnvironmentName(string value)
            : base(value)
        {
        }
    }
}
