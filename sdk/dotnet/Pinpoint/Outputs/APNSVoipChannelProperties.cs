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
    public sealed class APNSVoipChannelProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-applicationid
        /// </summary>
        public readonly string ApplicationId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-bundleid
        /// </summary>
        public readonly string? BundleId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-certificate
        /// </summary>
        public readonly string? Certificate;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-defaultauthenticationmethod
        /// </summary>
        public readonly string? DefaultAuthenticationMethod;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-enabled
        /// </summary>
        public readonly bool? Enabled;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-privatekey
        /// </summary>
        public readonly string? PrivateKey;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-teamid
        /// </summary>
        public readonly string? TeamId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-tokenkey
        /// </summary>
        public readonly string? TokenKey;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-apnsvoipchannel.html#cfn-pinpoint-apnsvoipchannel-tokenkeyid
        /// </summary>
        public readonly string? TokenKeyId;

        [OutputConstructor]
        private APNSVoipChannelProperties(
            string ApplicationId,

            string? BundleId,

            string? Certificate,

            string? DefaultAuthenticationMethod,

            bool? Enabled,

            string? PrivateKey,

            string? TeamId,

            string? TokenKey,

            string? TokenKeyId)
        {
            this.ApplicationId = ApplicationId;
            this.BundleId = BundleId;
            this.Certificate = Certificate;
            this.DefaultAuthenticationMethod = DefaultAuthenticationMethod;
            this.Enabled = Enabled;
            this.PrivateKey = PrivateKey;
            this.TeamId = TeamId;
            this.TokenKey = TokenKey;
            this.TokenKeyId = TokenKeyId;
        }
    }
}
