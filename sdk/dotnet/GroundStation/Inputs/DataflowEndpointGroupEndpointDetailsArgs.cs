// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Inputs
{

    public sealed class DataflowEndpointGroupEndpointDetailsArgs : Pulumi.ResourceArgs
    {
        [Input("endpoint")]
        public Input<Inputs.DataflowEndpointGroupDataflowEndpointArgs>? Endpoint { get; set; }

        [Input("securityDetails")]
        public Input<Inputs.DataflowEndpointGroupSecurityDetailsArgs>? SecurityDetails { get; set; }

        public DataflowEndpointGroupEndpointDetailsArgs()
        {
        }
    }
}
