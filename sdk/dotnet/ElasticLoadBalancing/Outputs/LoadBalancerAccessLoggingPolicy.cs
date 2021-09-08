// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticLoadBalancing.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html
    /// </summary>
    [OutputType]
    public sealed class LoadBalancerAccessLoggingPolicy
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html#cfn-elb-accessloggingpolicy-emitinterval
        /// </summary>
        public readonly int? EmitInterval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html#cfn-elb-accessloggingpolicy-enabled
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html#cfn-elb-accessloggingpolicy-s3bucketname
        /// </summary>
        public readonly string S3BucketName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-elb-accessloggingpolicy.html#cfn-elb-accessloggingpolicy-s3bucketprefix
        /// </summary>
        public readonly string? S3BucketPrefix;

        [OutputConstructor]
        private LoadBalancerAccessLoggingPolicy(
            int? emitInterval,

            bool enabled,

            string s3BucketName,

            string? s3BucketPrefix)
        {
            EmitInterval = emitInterval;
            Enabled = enabled;
            S3BucketName = s3BucketName;
            S3BucketPrefix = s3BucketPrefix;
        }
    }
}