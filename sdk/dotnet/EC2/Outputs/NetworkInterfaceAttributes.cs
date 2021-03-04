// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class NetworkInterfaceAttributes
    {
        public readonly string PrimaryPrivateIpAddress;
        public readonly ImmutableArray<string> SecondaryPrivateIpAddresses;

        [OutputConstructor]
        private NetworkInterfaceAttributes(
            string PrimaryPrivateIpAddress,

            ImmutableArray<string> SecondaryPrivateIpAddresses)
        {
            this.PrimaryPrivateIpAddress = PrimaryPrivateIpAddress;
            this.SecondaryPrivateIpAddresses = SecondaryPrivateIpAddresses;
        }
    }
}
