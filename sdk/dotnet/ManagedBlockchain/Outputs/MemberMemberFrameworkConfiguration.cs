// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ManagedBlockchain.Outputs
{

    [OutputType]
    public sealed class MemberMemberFrameworkConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberframeworkconfiguration.html#cfn-managedblockchain-member-memberframeworkconfiguration-memberfabricconfiguration
        /// </summary>
        public readonly Outputs.MemberMemberFabricConfiguration? MemberFabricConfiguration;

        [OutputConstructor]
        private MemberMemberFrameworkConfiguration(Outputs.MemberMemberFabricConfiguration? MemberFabricConfiguration)
        {
            this.MemberFabricConfiguration = MemberFabricConfiguration;
        }
    }
}
