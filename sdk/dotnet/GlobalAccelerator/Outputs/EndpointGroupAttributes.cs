// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GlobalAccelerator.Outputs
{

    [OutputType]
    public sealed class EndpointGroupAttributes
    {
        public readonly string EndpointGroupArn;

        [OutputConstructor]
        private EndpointGroupAttributes(string EndpointGroupArn)
        {
            this.EndpointGroupArn = EndpointGroupArn;
        }
    }
}
