// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualNodeTcpTimeoutArgs : Pulumi.ResourceArgs
    {
        [Input("idle")]
        public Input<Inputs.VirtualNodeDurationArgs>? Idle { get; set; }

        public VirtualNodeTcpTimeoutArgs()
        {
        }
    }
}
