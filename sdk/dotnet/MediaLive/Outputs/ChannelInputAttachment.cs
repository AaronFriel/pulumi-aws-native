// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelInputAttachment
    {
        public readonly Outputs.ChannelAutomaticInputFailoverSettings? AutomaticInputFailoverSettings;
        public readonly string? InputAttachmentName;
        public readonly string? InputId;
        public readonly Outputs.ChannelInputSettings? InputSettings;

        [OutputConstructor]
        private ChannelInputAttachment(
            Outputs.ChannelAutomaticInputFailoverSettings? automaticInputFailoverSettings,

            string? inputAttachmentName,

            string? inputId,

            Outputs.ChannelInputSettings? inputSettings)
        {
            AutomaticInputFailoverSettings = automaticInputFailoverSettings;
            InputAttachmentName = inputAttachmentName;
            InputId = inputId;
            InputSettings = inputSettings;
        }
    }
}
