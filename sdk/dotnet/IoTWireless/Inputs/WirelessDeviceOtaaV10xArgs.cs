// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTWireless.Inputs
{

    public sealed class WirelessDeviceOtaaV10xArgs : Pulumi.ResourceArgs
    {
        [Input("appEui", required: true)]
        public Input<string> AppEui { get; set; } = null!;

        [Input("appKey", required: true)]
        public Input<string> AppKey { get; set; } = null!;

        public WirelessDeviceOtaaV10xArgs()
        {
        }
    }
}
