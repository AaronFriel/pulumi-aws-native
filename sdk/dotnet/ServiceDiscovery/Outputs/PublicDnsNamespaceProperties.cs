// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ServiceDiscovery.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-properties.html
    /// </summary>
    [OutputType]
    public sealed class PublicDnsNamespaceProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-servicediscovery-publicdnsnamespace-properties.html#cfn-servicediscovery-publicdnsnamespace-properties-dnsproperties
        /// </summary>
        public readonly Outputs.PublicDnsNamespacePublicDnsPropertiesMutable? DnsProperties;

        [OutputConstructor]
        private PublicDnsNamespaceProperties(Outputs.PublicDnsNamespacePublicDnsPropertiesMutable? dnsProperties)
        {
            DnsProperties = dnsProperties;
        }
    }
}