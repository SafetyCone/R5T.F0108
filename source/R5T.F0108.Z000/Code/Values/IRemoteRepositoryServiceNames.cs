using System;

using R5T.T0131;

using R5T.F0108.T000;
using R5T.F0108.T000.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface IRemoteRepositoryServiceNames : IValuesMarker
    {
        /// <summary>
        /// GitHub
        /// </summary>
        public const string GitHub_Constant = "GitHub";


        /// <inheritdoc cref="GitHub_Constant"/>
        public RemoteRepositoryServiceName GitHub => GitHub_Constant.ToRemoteRepositoryServiceName();
    }
}
