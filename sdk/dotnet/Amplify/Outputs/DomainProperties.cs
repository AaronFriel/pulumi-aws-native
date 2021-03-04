// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Amplify.Outputs
{

    [OutputType]
    public sealed class DomainProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-appid
        /// </summary>
        public readonly string AppId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-autosubdomaincreationpatterns
        /// </summary>
        public readonly ImmutableArray<string> AutoSubDomainCreationPatterns;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-autosubdomainiamrole
        /// </summary>
        public readonly string? AutoSubDomainIAMRole;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-domainname
        /// </summary>
        public readonly string DomainName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-enableautosubdomain
        /// </summary>
        public readonly bool? EnableAutoSubDomain;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-subdomainsettings
        /// </summary>
        public readonly ImmutableArray<Outputs.DomainSubDomainSetting> SubDomainSettings;

        [OutputConstructor]
        private DomainProperties(
            string AppId,

            ImmutableArray<string> AutoSubDomainCreationPatterns,

            string? AutoSubDomainIAMRole,

            string DomainName,

            bool? EnableAutoSubDomain,

            ImmutableArray<Outputs.DomainSubDomainSetting> SubDomainSettings)
        {
            this.AppId = AppId;
            this.AutoSubDomainCreationPatterns = AutoSubDomainCreationPatterns;
            this.AutoSubDomainIAMRole = AutoSubDomainIAMRole;
            this.DomainName = DomainName;
            this.EnableAutoSubDomain = EnableAutoSubDomain;
            this.SubDomainSettings = SubDomainSettings;
        }
    }
}
