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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html
    /// </summary>
    [OutputType]
    public sealed class ChannelGlobalConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-initialaudiogain
        /// </summary>
        public readonly int? InitialAudioGain;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputendaction
        /// </summary>
        public readonly string? InputEndAction;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-inputlossbehavior
        /// </summary>
        public readonly Outputs.ChannelInputLossBehavior? InputLossBehavior;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputlockingmode
        /// </summary>
        public readonly string? OutputLockingMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-outputtimingsource
        /// </summary>
        public readonly string? OutputTimingSource;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-medialive-channel-globalconfiguration.html#cfn-medialive-channel-globalconfiguration-supportlowframerateinputs
        /// </summary>
        public readonly string? SupportLowFramerateInputs;

        [OutputConstructor]
        private ChannelGlobalConfiguration(
            int? initialAudioGain,

            string? inputEndAction,

            Outputs.ChannelInputLossBehavior? inputLossBehavior,

            string? outputLockingMode,

            string? outputTimingSource,

            string? supportLowFramerateInputs)
        {
            InitialAudioGain = initialAudioGain;
            InputEndAction = inputEndAction;
            InputLossBehavior = inputLossBehavior;
            OutputLockingMode = outputLockingMode;
            OutputTimingSource = outputTimingSource;
            SupportLowFramerateInputs = supportLowFramerateInputs;
        }
    }
}