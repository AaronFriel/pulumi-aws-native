// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ManagedBlockchain.Inputs
{

    public sealed class MemberMemberFrameworkConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("memberFabricConfiguration")]
        public Input<Inputs.MemberMemberFabricConfigurationArgs>? MemberFabricConfiguration { get; set; }

        public MemberMemberFrameworkConfigurationArgs()
        {
        }
    }
}