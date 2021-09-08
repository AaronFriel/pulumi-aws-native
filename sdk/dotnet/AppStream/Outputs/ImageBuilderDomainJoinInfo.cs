// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppStream.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html
    /// </summary>
    [OutputType]
    public sealed class ImageBuilderDomainJoinInfo
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-directoryname
        /// </summary>
        public readonly string? DirectoryName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-imagebuilder-domainjoininfo.html#cfn-appstream-imagebuilder-domainjoininfo-organizationalunitdistinguishedname
        /// </summary>
        public readonly string? OrganizationalUnitDistinguishedName;

        [OutputConstructor]
        private ImageBuilderDomainJoinInfo(
            string? directoryName,

            string? organizationalUnitDistinguishedName)
        {
            DirectoryName = directoryName;
            OrganizationalUnitDistinguishedName = organizationalUnitDistinguishedName;
        }
    }
}