// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    public sealed class ChannelMotionGraphicsSettingsArgs : Pulumi.ResourceArgs
    {
        [Input("htmlMotionGraphicsSettings")]
        public Input<Inputs.ChannelHtmlMotionGraphicsSettingsArgs>? HtmlMotionGraphicsSettings { get; set; }

        public ChannelMotionGraphicsSettingsArgs()
        {
        }
    }
}
