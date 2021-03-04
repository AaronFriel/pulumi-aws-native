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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html
    /// </summary>
    public sealed class StorageLensBucketsAndRegionsArgs : Pulumi.ResourceArgs
    {
        [Input("Buckets")]
        private InputList<string>? _Buckets;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-buckets
        /// </summary>
        public InputList<string> Buckets
        {
            get => _Buckets ?? (_Buckets = new InputList<string>());
            set => _Buckets = value;
        }

        [Input("Regions")]
        private InputList<string>? _Regions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-storagelens-bucketsandregions.html#cfn-s3-storagelens-bucketsandregions-regions
        /// </summary>
        public InputList<string> Regions
        {
            get => _Regions ?? (_Regions = new InputList<string>());
            set => _Regions = value;
        }

        public StorageLensBucketsAndRegionsArgs()
        {
        }
    }
}
