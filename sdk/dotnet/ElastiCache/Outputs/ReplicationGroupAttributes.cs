// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache.Outputs
{

    [OutputType]
    public sealed class ReplicationGroupAttributes
    {
        public readonly string ConfigurationEndPointAddress;
        public readonly string ConfigurationEndPointPort;
        public readonly string PrimaryEndPointAddress;
        public readonly string PrimaryEndPointPort;
        public readonly string ReadEndPointAddresses;
        public readonly ImmutableArray<string> ReadEndPointAddressesList;
        public readonly string ReadEndPointPorts;
        public readonly ImmutableArray<string> ReadEndPointPortsList;
        public readonly string ReaderEndPointAddress;
        public readonly string ReaderEndPointPort;

        [OutputConstructor]
        private ReplicationGroupAttributes(
            string ConfigurationEndPointAddress,

            string ConfigurationEndPointPort,

            string PrimaryEndPointAddress,

            string PrimaryEndPointPort,

            string ReadEndPointAddresses,

            ImmutableArray<string> ReadEndPointAddressesList,

            string ReadEndPointPorts,

            ImmutableArray<string> ReadEndPointPortsList,

            string ReaderEndPointAddress,

            string ReaderEndPointPort)
        {
            this.ConfigurationEndPointAddress = ConfigurationEndPointAddress;
            this.ConfigurationEndPointPort = ConfigurationEndPointPort;
            this.PrimaryEndPointAddress = PrimaryEndPointAddress;
            this.PrimaryEndPointPort = PrimaryEndPointPort;
            this.ReadEndPointAddresses = ReadEndPointAddresses;
            this.ReadEndPointAddressesList = ReadEndPointAddressesList;
            this.ReadEndPointPorts = ReadEndPointPorts;
            this.ReadEndPointPortsList = ReadEndPointPortsList;
            this.ReaderEndPointAddress = ReaderEndPointAddress;
            this.ReaderEndPointPort = ReaderEndPointPort;
        }
    }
}
