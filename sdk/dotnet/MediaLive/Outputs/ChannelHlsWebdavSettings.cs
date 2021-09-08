// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html
    /// </summary>
    [OutputType]
    public sealed class ChannelHlsWebdavSettings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-connectionretryinterval
        /// </summary>
        public readonly int? ConnectionRetryInterval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-filecacheduration
        /// </summary>
        public readonly int? FilecacheDuration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-httptransfermode
        /// </summary>
        public readonly string? HttpTransferMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-numretries
        /// </summary>
        public readonly int? NumRetries;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-hlswebdavsettings.html#cfn-medialive-channel-hlswebdavsettings-restartdelay
        /// </summary>
        public readonly int? RestartDelay;

        [OutputConstructor]
        private ChannelHlsWebdavSettings(
            int? connectionRetryInterval,

            int? filecacheDuration,

            string? httpTransferMode,

            int? numRetries,

            int? restartDelay)
        {
            ConnectionRetryInterval = connectionRetryInterval;
            FilecacheDuration = filecacheDuration;
            HttpTransferMode = httpTransferMode;
            NumRetries = numRetries;
            RestartDelay = restartDelay;
        }
    }
}