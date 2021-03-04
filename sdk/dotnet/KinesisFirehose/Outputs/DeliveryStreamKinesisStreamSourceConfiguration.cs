// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Outputs
{

    [OutputType]
    public sealed class DeliveryStreamKinesisStreamSourceConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-kinesisstreamarn
        /// </summary>
        public readonly string KinesisStreamARN;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-rolearn
        /// </summary>
        public readonly string RoleARN;

        [OutputConstructor]
        private DeliveryStreamKinesisStreamSourceConfiguration(
            string KinesisStreamARN,

            string RoleARN)
        {
            this.KinesisStreamARN = KinesisStreamARN;
            this.RoleARN = RoleARN;
        }
    }
}
