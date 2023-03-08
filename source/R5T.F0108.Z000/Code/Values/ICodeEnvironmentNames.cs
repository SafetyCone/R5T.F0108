using System;

using R5T.T0131;

using R5T.F0108.T000;
using R5T.F0108.T000.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface ICodeEnvironmentNames : IValuesMarker
    {
        /// <summary>
        /// Development
        /// </summary>
        public const string Development_Constant = "Development";
        /// <summary>
        /// Production
        /// </summary>
        public const string Production_Constant = "Production";


        /// <inheritdoc cref="Development_Constant"/>
        public CodeEnvironmentName Development => Development_Constant.ToCodeEnvironmentName();

        /// <inheritdoc cref="Production_Constant"/>
        public CodeEnvironmentName Production => Production_Constant.ToCodeEnvironmentName();
    }
}
