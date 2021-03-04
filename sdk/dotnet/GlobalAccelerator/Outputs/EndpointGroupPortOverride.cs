// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GlobalAccelerator.Outputs
{

    [OutputType]
    public sealed class EndpointGroupPortOverride
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-portoverride.html#cfn-globalaccelerator-endpointgroup-portoverride-endpointport
        /// </summary>
        public readonly int EndpointPort;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-globalaccelerator-endpointgroup-portoverride.html#cfn-globalaccelerator-endpointgroup-portoverride-listenerport
        /// </summary>
        public readonly int ListenerPort;

        [OutputConstructor]
        private EndpointGroupPortOverride(
            int EndpointPort,

            int ListenerPort)
        {
            this.EndpointPort = EndpointPort;
            this.ListenerPort = ListenerPort;
        }
    }
}
