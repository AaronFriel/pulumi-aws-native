// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTWireless.Outputs
{

    [OutputType]
    public sealed class FuotaTaskLoRaWAN
    {
        /// <summary>
        /// FUOTA task LoRaWAN RF region
        /// </summary>
        public readonly string RfRegion;
        /// <summary>
        /// FUOTA task LoRaWAN start time
        /// </summary>
        public readonly string? StartTime;

        [OutputConstructor]
        private FuotaTaskLoRaWAN(
            string rfRegion,

            string? startTime)
        {
            RfRegion = rfRegion;
            StartTime = startTime;
        }
    }
}
