// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    /// <summary>
    /// Format options for dataset
    /// </summary>
    [OutputType]
    public sealed class DatasetFormatOptions
    {
        public readonly Outputs.DatasetCsvOptions? Csv;
        public readonly Outputs.DatasetExcelOptions? Excel;
        public readonly Outputs.DatasetJsonOptions? Json;

        [OutputConstructor]
        private DatasetFormatOptions(
            Outputs.DatasetCsvOptions? csv,

            Outputs.DatasetExcelOptions? excel,

            Outputs.DatasetJsonOptions? json)
        {
            Csv = csv;
            Excel = excel;
            Json = json;
        }
    }
}
