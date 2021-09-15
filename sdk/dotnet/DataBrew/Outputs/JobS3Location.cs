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
    /// S3 Output location
    /// </summary>
    [OutputType]
    public sealed class JobS3Location
    {
        public readonly string Bucket;
        public readonly string? Key;

        [OutputConstructor]
        private JobS3Location(
            string bucket,

            string? key)
        {
            Bucket = bucket;
            Key = key;
        }
    }
}
