// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Inputs
{

    public sealed class VirtualNodeListenerTimeoutArgs : Pulumi.ResourceArgs
    {
        [Input("gRPC")]
        public Input<Inputs.VirtualNodeGrpcTimeoutArgs>? GRPC { get; set; }

        [Input("hTTP")]
        public Input<Inputs.VirtualNodeHttpTimeoutArgs>? HTTP { get; set; }

        [Input("hTTP2")]
        public Input<Inputs.VirtualNodeHttpTimeoutArgs>? HTTP2 { get; set; }

        [Input("tCP")]
        public Input<Inputs.VirtualNodeTcpTimeoutArgs>? TCP { get; set; }

        public VirtualNodeListenerTimeoutArgs()
        {
        }
    }
}
