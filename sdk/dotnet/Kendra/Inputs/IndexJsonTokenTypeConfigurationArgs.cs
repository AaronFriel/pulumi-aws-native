// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Inputs
{

    public sealed class IndexJsonTokenTypeConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("groupAttributeField", required: true)]
        public Input<string> GroupAttributeField { get; set; } = null!;

        [Input("userNameAttributeField", required: true)]
        public Input<string> UserNameAttributeField { get; set; } = null!;

        public IndexJsonTokenTypeConfigurationArgs()
        {
        }
    }
}
