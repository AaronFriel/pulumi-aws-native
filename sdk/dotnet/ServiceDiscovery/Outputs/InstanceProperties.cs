// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ServiceDiscovery.Outputs
{

    [OutputType]
    public sealed class InstanceProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceattributes
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string> InstanceAttributes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-instanceid
        /// </summary>
        public readonly string? InstanceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-servicediscovery-instance.html#cfn-servicediscovery-instance-serviceid
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private InstanceProperties(
            Union<System.Text.Json.JsonElement, string> InstanceAttributes,

            string? InstanceId,

            string ServiceId)
        {
            this.InstanceAttributes = InstanceAttributes;
            this.InstanceId = InstanceId;
            this.ServiceId = ServiceId;
        }
    }
}
