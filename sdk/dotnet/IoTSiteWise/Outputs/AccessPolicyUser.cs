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
    public sealed class AccessPolicyUser
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-accesspolicy-user.html#cfn-iotsitewise-accesspolicy-user-id
        /// </summary>
        public readonly string? Id;

        [OutputConstructor]
        private AccessPolicyUser(string? id)
        {
            Id = id;
        }
    }
}
