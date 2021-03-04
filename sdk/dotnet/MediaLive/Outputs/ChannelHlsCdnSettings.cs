// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    [OutputType]
    public sealed class ChannelHlsCdnSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsakamaisettings
        /// </summary>
        public readonly Outputs.ChannelHlsAkamaiSettings? HlsAkamaiSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsbasicputsettings
        /// </summary>
        public readonly Outputs.ChannelHlsBasicPutSettings? HlsBasicPutSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlsmediastoresettings
        /// </summary>
        public readonly Outputs.ChannelHlsMediaStoreSettings? HlsMediaStoreSettings;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlscdnsettings.html#cfn-medialive-channel-hlscdnsettings-hlswebdavsettings
        /// </summary>
        public readonly Outputs.ChannelHlsWebdavSettings? HlsWebdavSettings;

        [OutputConstructor]
        private ChannelHlsCdnSettings(
            Outputs.ChannelHlsAkamaiSettings? HlsAkamaiSettings,

            Outputs.ChannelHlsBasicPutSettings? HlsBasicPutSettings,

            Outputs.ChannelHlsMediaStoreSettings? HlsMediaStoreSettings,

            Outputs.ChannelHlsWebdavSettings? HlsWebdavSettings)
        {
            this.HlsAkamaiSettings = HlsAkamaiSettings;
            this.HlsBasicPutSettings = HlsBasicPutSettings;
            this.HlsMediaStoreSettings = HlsMediaStoreSettings;
            this.HlsWebdavSettings = HlsWebdavSettings;
        }
    }
}
