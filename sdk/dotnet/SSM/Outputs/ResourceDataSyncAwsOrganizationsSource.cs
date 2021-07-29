// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Outputs
{

    [OutputType]
    public sealed class ResourceDataSyncAwsOrganizationsSource
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-awsorganizationssource.html#cfn-ssm-resourcedatasync-awsorganizationssource-organizationsourcetype
        /// </summary>
        public readonly string OrganizationSourceType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-resourcedatasync-awsorganizationssource.html#cfn-ssm-resourcedatasync-awsorganizationssource-organizationalunits
        /// </summary>
        public readonly ImmutableArray<string> OrganizationalUnits;

        [OutputConstructor]
        private ResourceDataSyncAwsOrganizationsSource(
            string organizationSourceType,

            ImmutableArray<string> organizationalUnits)
        {
            OrganizationSourceType = organizationSourceType;
            OrganizationalUnits = organizationalUnits;
        }
    }
}