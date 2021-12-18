// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Inputs
{

    public sealed class InstanceBlockDeviceMappingArgs : Pulumi.ResourceArgs
    {
        [Input("deviceName", required: true)]
        public Input<string> DeviceName { get; set; } = null!;

        [Input("ebs")]
        public Input<Inputs.InstanceEbsArgs>? Ebs { get; set; }

        [Input("noDevice")]
        public Input<Inputs.InstanceNoDeviceArgs>? NoDevice { get; set; }

        [Input("virtualName")]
        public Input<string>? VirtualName { get; set; }

        public InstanceBlockDeviceMappingArgs()
        {
        }
    }
}
