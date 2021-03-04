// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelAttributes
    {
        public readonly string Arn;
        public readonly ImmutableArray<string> Inputs;

        [OutputConstructor]
        private ChannelAttributes(
            string Arn,

            ImmutableArray<string> Inputs)
        {
            this.Arn = Arn;
            this.Inputs = Inputs;
        }
    }
}
