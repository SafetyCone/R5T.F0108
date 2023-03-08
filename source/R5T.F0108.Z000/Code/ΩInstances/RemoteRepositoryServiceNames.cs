using System;


namespace R5T.F0108.Z000
{
    public class RemoteRepositoryServiceNames : IRemoteRepositoryServiceNames
    {
        #region Infrastructure

        public static IRemoteRepositoryServiceNames Instance { get; } = new RemoteRepositoryServiceNames();


        private RemoteRepositoryServiceNames()
        {
        }

        #endregion
    }
}
