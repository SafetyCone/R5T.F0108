using System;

using R5T.T0131;

using R5T.F0108.T001;
using R5T.F0108.T001.Extensions;


namespace R5T.F0108.Z000
{
    [ValuesMarker]
    public partial interface ICodeDirectoryPaths : IValuesMarker
    {
        public const string Code_Constant = @"C:\Code";


        public CodeDirectoryPath Code => Code_Constant.ToCodeDirectoryPath();
    }
}
