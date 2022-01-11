// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lightsail.Inputs
{

    /// <summary>
    /// Location of a resource.
    /// </summary>
    public sealed class InstanceLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Availability Zone in which to create your instance. Use the following format: us-east-2a (case sensitive). Be sure to add the include Availability Zones parameter to your request.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// The Region Name in which to create your instance.
        /// </summary>
        [Input("regionName")]
        public Input<string>? RegionName { get; set; }

        public InstanceLocationArgs()
        {
        }
    }
}
