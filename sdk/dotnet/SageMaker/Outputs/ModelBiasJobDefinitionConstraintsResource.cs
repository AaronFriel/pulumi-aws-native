// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// The baseline constraints resource for a monitoring job.
    /// </summary>
    [OutputType]
    public sealed class ModelBiasJobDefinitionConstraintsResource
    {
        /// <summary>
        /// The Amazon S3 URI for baseline constraint file in Amazon S3 that the current monitoring job should validated against.
        /// </summary>
        public readonly string? S3Uri;

        [OutputConstructor]
        private ModelBiasJobDefinitionConstraintsResource(string? s3Uri)
        {
            S3Uri = s3Uri;
        }
    }
}
