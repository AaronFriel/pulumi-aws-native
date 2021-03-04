// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElastiCache.Outputs
{

    [OutputType]
    public sealed class SecurityGroupProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html#cfn-elasticache-securitygroup-description
        /// </summary>
        public readonly string Description;

        [OutputConstructor]
        private SecurityGroupProperties(string Description)
        {
            this.Description = Description;
        }
    }
}
