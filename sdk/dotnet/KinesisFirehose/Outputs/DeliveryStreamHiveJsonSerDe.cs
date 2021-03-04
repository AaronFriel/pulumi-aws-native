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
    public sealed class DeliveryStreamHiveJsonSerDe
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-hivejsonserde.html#cfn-kinesisfirehose-deliverystream-hivejsonserde-timestampformats
        /// </summary>
        public readonly ImmutableArray<string> TimestampFormats;

        [OutputConstructor]
        private DeliveryStreamHiveJsonSerDe(ImmutableArray<string> TimestampFormats)
        {
            this.TimestampFormats = TimestampFormats;
        }
    }
}
