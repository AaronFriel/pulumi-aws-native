// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.OpsWorks.Inputs
{

    public sealed class StackChefConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("berkshelfVersion")]
        public Input<string>? BerkshelfVersion { get; set; }

        [Input("manageBerkshelf")]
        public Input<bool>? ManageBerkshelf { get; set; }

        public StackChefConfigurationArgs()
        {
        }
    }
}
