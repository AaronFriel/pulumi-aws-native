// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    [OutputType]
    public sealed class DatasetExcelOptions
    {
        public readonly bool? HeaderRow;
        public readonly ImmutableArray<int> SheetIndexes;
        public readonly ImmutableArray<string> SheetNames;

        [OutputConstructor]
        private DatasetExcelOptions(
            bool? headerRow,

            ImmutableArray<int> sheetIndexes,

            ImmutableArray<string> sheetNames)
        {
            HeaderRow = headerRow;
            SheetIndexes = sheetIndexes;
            SheetNames = sheetNames;
        }
    }
}
