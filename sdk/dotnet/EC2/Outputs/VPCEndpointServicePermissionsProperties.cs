// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EC2.Outputs
{

    [OutputType]
    public sealed class VPCEndpointServicePermissionsProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservicepermissions.html#cfn-ec2-vpcendpointservicepermissions-allowedprincipals
        /// </summary>
        public readonly ImmutableArray<string> AllowedPrincipals;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservicepermissions.html#cfn-ec2-vpcendpointservicepermissions-serviceid
        /// </summary>
        public readonly string ServiceId;

        [OutputConstructor]
        private VPCEndpointServicePermissionsProperties(
            ImmutableArray<string> AllowedPrincipals,

            string ServiceId)
        {
            this.AllowedPrincipals = AllowedPrincipals;
            this.ServiceId = ServiceId;
        }
    }
}
