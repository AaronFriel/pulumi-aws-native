// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTWireless.Outputs
{

    [OutputType]
    public sealed class WirelessDeviceOtaaV11
    {
        public readonly string AppKey;
        public readonly string JoinEui;
        public readonly string NwkKey;

        [OutputConstructor]
        private WirelessDeviceOtaaV11(
            string appKey,

            string joinEui,

            string nwkKey)
        {
            AppKey = appKey;
            JoinEui = joinEui;
            NwkKey = nwkKey;
        }
    }
}
