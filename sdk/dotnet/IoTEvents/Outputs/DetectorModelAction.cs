// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    /// <summary>
    /// The actions to be performed.
    /// </summary>
    [OutputType]
    public sealed class DetectorModelAction
    {
        public readonly Outputs.DetectorModelClearTimer? ClearTimer;
        public readonly Outputs.DetectorModelDynamoDB? DynamoDB;
        public readonly Outputs.DetectorModelDynamoDBv2? DynamoDBv2;
        public readonly Outputs.DetectorModelFirehose? Firehose;
        public readonly Outputs.DetectorModelIotEvents? IotEvents;
        public readonly Outputs.DetectorModelIotSiteWise? IotSiteWise;
        public readonly Outputs.DetectorModelIotTopicPublish? IotTopicPublish;
        public readonly Outputs.DetectorModelLambda? Lambda;
        public readonly Outputs.DetectorModelResetTimer? ResetTimer;
        public readonly Outputs.DetectorModelSetTimer? SetTimer;
        public readonly Outputs.DetectorModelSetVariable? SetVariable;
        public readonly Outputs.DetectorModelSns? Sns;
        public readonly Outputs.DetectorModelSqs? Sqs;

        [OutputConstructor]
        private DetectorModelAction(
            Outputs.DetectorModelClearTimer? clearTimer,

            Outputs.DetectorModelDynamoDB? dynamoDB,

            Outputs.DetectorModelDynamoDBv2? dynamoDBv2,

            Outputs.DetectorModelFirehose? firehose,

            Outputs.DetectorModelIotEvents? iotEvents,

            Outputs.DetectorModelIotSiteWise? iotSiteWise,

            Outputs.DetectorModelIotTopicPublish? iotTopicPublish,

            Outputs.DetectorModelLambda? lambda,

            Outputs.DetectorModelResetTimer? resetTimer,

            Outputs.DetectorModelSetTimer? setTimer,

            Outputs.DetectorModelSetVariable? setVariable,

            Outputs.DetectorModelSns? sns,

            Outputs.DetectorModelSqs? sqs)
        {
            ClearTimer = clearTimer;
            DynamoDB = dynamoDB;
            DynamoDBv2 = dynamoDBv2;
            Firehose = firehose;
            IotEvents = iotEvents;
            IotSiteWise = iotSiteWise;
            IotTopicPublish = iotTopicPublish;
            Lambda = lambda;
            ResetTimer = resetTimer;
            SetTimer = setTimer;
            SetVariable = setVariable;
            Sns = sns;
            Sqs = sqs;
        }
    }
}
