// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTSiteWise.Outputs
{

    /// <summary>
    /// Contains a gateway's platform information.
    /// </summary>
    [OutputType]
    public sealed class GatewayPlatform
    {
        /// <summary>
        /// A gateway that runs on AWS IoT Greengrass.
        /// </summary>
        public readonly Outputs.GatewayGreengrass Greengrass;

        [OutputConstructor]
        private GatewayPlatform(Outputs.GatewayGreengrass greengrass)
        {
            Greengrass = greengrass;
        }
    }
}
