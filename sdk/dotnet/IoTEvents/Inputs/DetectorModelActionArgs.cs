// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html
    /// </summary>
    public sealed class DetectorModelActionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-cleartimer
        /// </summary>
        [Input("ClearTimer")]
        public Input<Inputs.DetectorModelClearTimerArgs>? ClearTimer { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-dynamodb
        /// </summary>
        [Input("DynamoDB")]
        public Input<Inputs.DetectorModelDynamoDBArgs>? DynamoDB { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-dynamodbv2
        /// </summary>
        [Input("DynamoDBv2")]
        public Input<Inputs.DetectorModelDynamoDBv2Args>? DynamoDBv2 { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-firehose
        /// </summary>
        [Input("Firehose")]
        public Input<Inputs.DetectorModelFirehoseArgs>? Firehose { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iotevents
        /// </summary>
        [Input("IotEvents")]
        public Input<Inputs.DetectorModelIotEventsArgs>? IotEvents { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iotsitewise
        /// </summary>
        [Input("IotSiteWise")]
        public Input<Inputs.DetectorModelIotSiteWiseArgs>? IotSiteWise { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-iottopicpublish
        /// </summary>
        [Input("IotTopicPublish")]
        public Input<Inputs.DetectorModelIotTopicPublishArgs>? IotTopicPublish { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-lambda
        /// </summary>
        [Input("Lambda")]
        public Input<Inputs.DetectorModelLambdaArgs>? Lambda { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-resettimer
        /// </summary>
        [Input("ResetTimer")]
        public Input<Inputs.DetectorModelResetTimerArgs>? ResetTimer { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-settimer
        /// </summary>
        [Input("SetTimer")]
        public Input<Inputs.DetectorModelSetTimerArgs>? SetTimer { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-setvariable
        /// </summary>
        [Input("SetVariable")]
        public Input<Inputs.DetectorModelSetVariableArgs>? SetVariable { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-sns
        /// </summary>
        [Input("Sns")]
        public Input<Inputs.DetectorModelSnsArgs>? Sns { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-action.html#cfn-iotevents-detectormodel-action-sqs
        /// </summary>
        [Input("Sqs")]
        public Input<Inputs.DetectorModelSqsArgs>? Sqs { get; set; }

        public DetectorModelActionArgs()
        {
        }
    }
}
