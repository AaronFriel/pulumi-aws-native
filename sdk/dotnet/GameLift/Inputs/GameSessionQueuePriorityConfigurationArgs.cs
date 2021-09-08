// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.GameLift.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html
    /// </summary>
    public sealed class GameSessionQueuePriorityConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("locationOrder")]
        private InputList<string>? _locationOrder;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-locationorder
        /// </summary>
        public InputList<string> LocationOrder
        {
            get => _locationOrder ?? (_locationOrder = new InputList<string>());
            set => _locationOrder = value;
        }

        [Input("priorityOrder")]
        private InputList<string>? _priorityOrder;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-gamelift-gamesessionqueue-priorityconfiguration.html#cfn-gamelift-gamesessionqueue-priorityconfiguration-priorityorder
        /// </summary>
        public InputList<string> PriorityOrder
        {
            get => _priorityOrder ?? (_priorityOrder = new InputList<string>());
            set => _priorityOrder = value;
        }

        public GameSessionQueuePriorityConfigurationArgs()
        {
        }
    }
}