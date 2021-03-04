// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Outputs
{

    [OutputType]
    public sealed class BucketLifecycleConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html#cfn-s3-bucket-lifecycleconfig-rules
        /// </summary>
        public readonly ImmutableArray<Outputs.BucketRule> Rules;

        [OutputConstructor]
        private BucketLifecycleConfiguration(ImmutableArray<Outputs.BucketRule> Rules)
        {
            this.Rules = Rules;
        }
    }
}
