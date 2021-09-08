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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html
    /// </summary>
    [OutputType]
    public sealed class ChannelM3u8Settings
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audioframesperpes
        /// </summary>
        public readonly int? AudioFramesPerPes;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-audiopids
        /// </summary>
        public readonly string? AudioPids;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-ecmpid
        /// </summary>
        public readonly string? EcmPid;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-nielsenid3behavior
        /// </summary>
        public readonly string? NielsenId3Behavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-patinterval
        /// </summary>
        public readonly int? PatInterval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrcontrol
        /// </summary>
        public readonly string? PcrControl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrperiod
        /// </summary>
        public readonly int? PcrPeriod;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pcrpid
        /// </summary>
        public readonly string? PcrPid;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtinterval
        /// </summary>
        public readonly int? PmtInterval;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-pmtpid
        /// </summary>
        public readonly string? PmtPid;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-programnum
        /// </summary>
        public readonly int? ProgramNum;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35behavior
        /// </summary>
        public readonly string? Scte35Behavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-scte35pid
        /// </summary>
        public readonly string? Scte35Pid;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatabehavior
        /// </summary>
        public readonly string? TimedMetadataBehavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-timedmetadatapid
        /// </summary>
        public readonly string? TimedMetadataPid;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-transportstreamid
        /// </summary>
        public readonly int? TransportStreamId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-m3u8settings.html#cfn-medialive-channel-m3u8settings-videopid
        /// </summary>
        public readonly string? VideoPid;

        [OutputConstructor]
        private ChannelM3u8Settings(
            int? audioFramesPerPes,

            string? audioPids,

            string? ecmPid,

            string? nielsenId3Behavior,

            int? patInterval,

            string? pcrControl,

            int? pcrPeriod,

            string? pcrPid,

            int? pmtInterval,

            string? pmtPid,

            int? programNum,

            string? scte35Behavior,

            string? scte35Pid,

            string? timedMetadataBehavior,

            string? timedMetadataPid,

            int? transportStreamId,

            string? videoPid)
        {
            AudioFramesPerPes = audioFramesPerPes;
            AudioPids = audioPids;
            EcmPid = ecmPid;
            NielsenId3Behavior = nielsenId3Behavior;
            PatInterval = patInterval;
            PcrControl = pcrControl;
            PcrPeriod = pcrPeriod;
            PcrPid = pcrPid;
            PmtInterval = pmtInterval;
            PmtPid = pmtPid;
            ProgramNum = programNum;
            Scte35Behavior = scte35Behavior;
            Scte35Pid = scte35Pid;
            TimedMetadataBehavior = timedMetadataBehavior;
            TimedMetadataPid = timedMetadataPid;
            TransportStreamId = transportStreamId;
            VideoPid = videoPid;
        }
    }
}