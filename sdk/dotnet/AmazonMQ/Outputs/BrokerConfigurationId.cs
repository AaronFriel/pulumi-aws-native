// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AmazonMQ.Outputs
{

    [OutputType]
    public sealed class BrokerConfigurationId
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-configurationid.html#cfn-amazonmq-broker-configurationid-id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amazonmq-broker-configurationid.html#cfn-amazonmq-broker-configurationid-revision
        /// </summary>
        public readonly int Revision;

        [OutputConstructor]
        private BrokerConfigurationId(
            string Id,

            int Revision)
        {
            this.Id = Id;
            this.Revision = Revision;
        }
    }
}
