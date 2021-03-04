// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IVS.Outputs
{

    [OutputType]
    public sealed class ChannelAttributes
    {
        public readonly string Arn;
        public readonly string IngestEndpoint;
        public readonly string PlaybackUrl;

        [OutputConstructor]
        private ChannelAttributes(
            string Arn,

            string IngestEndpoint,

            string PlaybackUrl)
        {
            this.Arn = Arn;
            this.IngestEndpoint = IngestEndpoint;
            this.PlaybackUrl = PlaybackUrl;
        }
    }
}
