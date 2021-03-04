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
    public sealed class PushTemplateProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-adm
        /// </summary>
        public readonly Outputs.PushTemplateAndroidPushNotificationTemplate? ADM;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-apns
        /// </summary>
        public readonly Outputs.PushTemplateAPNSPushNotificationTemplate? APNS;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-baidu
        /// </summary>
        public readonly Outputs.PushTemplateAndroidPushNotificationTemplate? Baidu;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-default
        /// </summary>
        public readonly Outputs.PushTemplateDefaultPushNotificationTemplate? Default;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-defaultsubstitutions
        /// </summary>
        public readonly string? DefaultSubstitutions;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-gcm
        /// </summary>
        public readonly Outputs.PushTemplateAndroidPushNotificationTemplate? GCM;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-tags
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Tags;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-templatedescription
        /// </summary>
        public readonly string? TemplateDescription;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-pushtemplate.html#cfn-pinpoint-pushtemplate-templatename
        /// </summary>
        public readonly string TemplateName;

        [OutputConstructor]
        private PushTemplateProperties(
            Outputs.PushTemplateAndroidPushNotificationTemplate? ADM,

            Outputs.PushTemplateAPNSPushNotificationTemplate? APNS,

            Outputs.PushTemplateAndroidPushNotificationTemplate? Baidu,

            Outputs.PushTemplateDefaultPushNotificationTemplate? Default,

            string? DefaultSubstitutions,

            Outputs.PushTemplateAndroidPushNotificationTemplate? GCM,

            Union<System.Text.Json.JsonElement, string>? Tags,

            string? TemplateDescription,

            string TemplateName)
        {
            this.ADM = ADM;
            this.APNS = APNS;
            this.Baidu = Baidu;
            this.Default = Default;
            this.DefaultSubstitutions = DefaultSubstitutions;
            this.GCM = GCM;
            this.Tags = Tags;
            this.TemplateDescription = TemplateDescription;
            this.TemplateName = TemplateName;
        }
    }
}
