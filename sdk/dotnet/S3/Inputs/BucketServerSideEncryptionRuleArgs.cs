// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.S3.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html
    /// </summary>
    public sealed class BucketServerSideEncryptionRuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-bucketkeyenabled
        /// </summary>
        [Input("BucketKeyEnabled")]
        public Input<bool>? BucketKeyEnabled { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-serversideencryptionrule.html#cfn-s3-bucket-serversideencryptionrule-serversideencryptionbydefault
        /// </summary>
        [Input("ServerSideEncryptionByDefault")]
        public Input<Inputs.BucketServerSideEncryptionByDefaultArgs>? ServerSideEncryptionByDefault { get; set; }

        public BucketServerSideEncryptionRuleArgs()
        {
        }
    }
}
