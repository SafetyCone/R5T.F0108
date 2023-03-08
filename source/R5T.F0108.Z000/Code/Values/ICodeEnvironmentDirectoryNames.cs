using System;

using R5T.T0131;

using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface ICodeEnvironmentDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// DEV
        /// </summary>
        public const string Development_Constant = "DEV";

        /// <summary>
        /// PROD
        /// </summary>
        public const string Production_Constant = "PROD";


        /// <inheritdoc cref="Development_Constant"/>
        public CodeEnvironmentDirectoryName Development => Development_Constant.ToCodeEnvironmentDirectoryName();

        /// <inheritdoc cref="Production_Constant"/>
        public CodeEnvironmentDirectoryName Production => Production_Constant.ToCodeEnvironmentDirectoryName();
    }
}
