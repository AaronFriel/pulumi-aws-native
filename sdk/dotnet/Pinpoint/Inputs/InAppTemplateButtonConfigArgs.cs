// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Pinpoint.Inputs
{

    public sealed class InAppTemplateButtonConfigArgs : Pulumi.ResourceArgs
    {
        [Input("android")]
        public Input<Inputs.InAppTemplateOverrideButtonConfigurationArgs>? Android { get; set; }

        [Input("defaultConfig")]
        public Input<Inputs.InAppTemplateDefaultButtonConfigurationArgs>? DefaultConfig { get; set; }

        [Input("iOS")]
        public Input<Inputs.InAppTemplateOverrideButtonConfigurationArgs>? IOS { get; set; }

        [Input("web")]
        public Input<Inputs.InAppTemplateOverrideButtonConfigurationArgs>? Web { get; set; }

        public InAppTemplateButtonConfigArgs()
        {
        }
    }
}
