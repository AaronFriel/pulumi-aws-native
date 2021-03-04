// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppStream.Outputs
{

    [OutputType]
    public sealed class FleetDomainJoinInfo
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-fleet-domainjoininfo.html#cfn-appstream-fleet-domainjoininfo-directoryname
        /// </summary>
        public readonly string? DirectoryName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-fleet-domainjoininfo.html#cfn-appstream-fleet-domainjoininfo-organizationalunitdistinguishedname
        /// </summary>
        public readonly string? OrganizationalUnitDistinguishedName;

        [OutputConstructor]
        private FleetDomainJoinInfo(
            string? DirectoryName,

            string? OrganizationalUnitDistinguishedName)
        {
            this.DirectoryName = DirectoryName;
            this.OrganizationalUnitDistinguishedName = OrganizationalUnitDistinguishedName;
        }
    }
}
