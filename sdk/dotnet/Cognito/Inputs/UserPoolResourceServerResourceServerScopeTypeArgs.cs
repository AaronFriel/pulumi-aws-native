// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Cognito.Inputs
{

    public sealed class UserPoolResourceServerResourceServerScopeTypeArgs : Pulumi.ResourceArgs
    {
        [Input("scopeDescription", required: true)]
        public Input<string> ScopeDescription { get; set; } = null!;

        [Input("scopeName", required: true)]
        public Input<string> ScopeName { get; set; } = null!;

        public UserPoolResourceServerResourceServerScopeTypeArgs()
        {
        }
    }
}
