// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ServiceDiscovery.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html
    /// </summary>
    public sealed class ServiceDnsRecordArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html#cfn-servicediscovery-service-dnsrecord-ttl
        /// </summary>
        [Input("TTL", required: true)]
        public Input<double> TTL { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-service-dnsrecord.html#cfn-servicediscovery-service-dnsrecord-type
        /// </summary>
        [Input("Type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ServiceDnsRecordArgs()
        {
        }
    }
}
