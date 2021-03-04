// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTSiteWise.Outputs
{

    [OutputType]
    public sealed class AccessPolicyProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyidentity
        /// </summary>
        public readonly Outputs.AccessPolicyAccessPolicyIdentity AccessPolicyIdentity;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicypermission
        /// </summary>
        public readonly string AccessPolicyPermission;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-accesspolicy.html#cfn-iotsitewise-accesspolicy-accesspolicyresource
        /// </summary>
        public readonly Outputs.AccessPolicyAccessPolicyResource AccessPolicyResource;

        [OutputConstructor]
        private AccessPolicyProperties(
            Outputs.AccessPolicyAccessPolicyIdentity AccessPolicyIdentity,

            string AccessPolicyPermission,

            Outputs.AccessPolicyAccessPolicyResource AccessPolicyResource)
        {
            this.AccessPolicyIdentity = AccessPolicyIdentity;
            this.AccessPolicyPermission = AccessPolicyPermission;
            this.AccessPolicyResource = AccessPolicyResource;
        }
    }
}
