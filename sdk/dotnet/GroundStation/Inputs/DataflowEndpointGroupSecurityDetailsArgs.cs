// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GroundStation.Inputs
{

    public sealed class DataflowEndpointGroupSecurityDetailsArgs : Pulumi.ResourceArgs
    {
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        [Input("securityGroupIds")]
        private InputList<string>? _securityGroupIds;
        public InputList<string> SecurityGroupIds
        {
            get => _securityGroupIds ?? (_securityGroupIds = new InputList<string>());
            set => _securityGroupIds = value;
        }

        [Input("subnetIds")]
        private InputList<string>? _subnetIds;
        public InputList<string> SubnetIds
        {
            get => _subnetIds ?? (_subnetIds = new InputList<string>());
            set => _subnetIds = value;
        }

        public DataflowEndpointGroupSecurityDetailsArgs()
        {
        }
    }
}
