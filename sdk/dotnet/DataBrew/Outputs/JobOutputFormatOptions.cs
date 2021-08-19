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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputformatoptions.html
    /// </summary>
    [OutputType]
    public sealed class JobOutputFormatOptions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-databrew-job-outputformatoptions.html#cfn-databrew-job-outputformatoptions-csv
        /// </summary>
        public readonly Outputs.JobCsvOutputOptions? Csv;

        [OutputConstructor]
        private JobOutputFormatOptions(Outputs.JobCsvOutputOptions? csv)
        {
            Csv = csv;
        }
    }
}