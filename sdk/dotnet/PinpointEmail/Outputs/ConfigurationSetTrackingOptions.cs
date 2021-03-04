// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.PinpointEmail.Outputs
{

    [OutputType]
    public sealed class ConfigurationSetTrackingOptions
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-configurationset-trackingoptions.html#cfn-pinpointemail-configurationset-trackingoptions-customredirectdomain
        /// </summary>
        public readonly string? CustomRedirectDomain;

        [OutputConstructor]
        private ConfigurationSetTrackingOptions(string? CustomRedirectDomain)
        {
            this.CustomRedirectDomain = CustomRedirectDomain;
        }
    }
}
