// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Pinpoint.Outputs
{

    [OutputType]
    public sealed class CampaignMessage
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-action
        /// </summary>
        public readonly string? Action;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-body
        /// </summary>
        public readonly string? Body;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageiconurl
        /// </summary>
        public readonly string? ImageIconUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imagesmalliconurl
        /// </summary>
        public readonly string? ImageSmallIconUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageurl
        /// </summary>
        public readonly string? ImageUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-jsonbody
        /// </summary>
        public readonly string? JsonBody;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-mediaurl
        /// </summary>
        public readonly string? MediaUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-rawcontent
        /// </summary>
        public readonly string? RawContent;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-silentpush
        /// </summary>
        public readonly bool? SilentPush;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-timetolive
        /// </summary>
        public readonly int? TimeToLive;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-title
        /// </summary>
        public readonly string? Title;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-url
        /// </summary>
        public readonly string? Url;

        [OutputConstructor]
        private CampaignMessage(
            string? Action,

            string? Body,

            string? ImageIconUrl,

            string? ImageSmallIconUrl,

            string? ImageUrl,

            string? JsonBody,

            string? MediaUrl,

            string? RawContent,

            bool? SilentPush,

            int? TimeToLive,

            string? Title,

            string? Url)
        {
            this.Action = Action;
            this.Body = Body;
            this.ImageIconUrl = ImageIconUrl;
            this.ImageSmallIconUrl = ImageSmallIconUrl;
            this.ImageUrl = ImageUrl;
            this.JsonBody = JsonBody;
            this.MediaUrl = MediaUrl;
            this.RawContent = RawContent;
            this.SilentPush = SilentPush;
            this.TimeToLive = TimeToLive;
            this.Title = Title;
            this.Url = Url;
        }
    }
}
