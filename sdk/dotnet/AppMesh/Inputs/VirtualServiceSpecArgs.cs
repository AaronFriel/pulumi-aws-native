// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualServiceSpecArgs : Pulumi.ResourceArgs
    {
        [Input("provider")]
        public Input<Inputs.VirtualServiceProviderArgs>? Provider { get; set; }

        public VirtualServiceSpecArgs()
        {
        }
    }
}