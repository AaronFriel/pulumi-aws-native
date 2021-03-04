// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    [OutputType]
    public sealed class DetectorModelDynamoDB
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeyfield
        /// </summary>
        public readonly string? HashKeyField;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeytype
        /// </summary>
        public readonly string? HashKeyType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-hashkeyvalue
        /// </summary>
        public readonly string? HashKeyValue;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-operation
        /// </summary>
        public readonly string? Operation;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-payload
        /// </summary>
        public readonly Outputs.DetectorModelPayload? Payload;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-payloadfield
        /// </summary>
        public readonly string? PayloadField;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeyfield
        /// </summary>
        public readonly string? RangeKeyField;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeytype
        /// </summary>
        public readonly string? RangeKeyType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-rangekeyvalue
        /// </summary>
        public readonly string? RangeKeyValue;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-detectormodel-dynamodb.html#cfn-iotevents-detectormodel-dynamodb-tablename
        /// </summary>
        public readonly string? TableName;

        [OutputConstructor]
        private DetectorModelDynamoDB(
            string? HashKeyField,

            string? HashKeyType,

            string? HashKeyValue,

            string? Operation,

            Outputs.DetectorModelPayload? Payload,

            string? PayloadField,

            string? RangeKeyField,

            string? RangeKeyType,

            string? RangeKeyValue,

            string? TableName)
        {
            this.HashKeyField = HashKeyField;
            this.HashKeyType = HashKeyType;
            this.HashKeyValue = HashKeyValue;
            this.Operation = Operation;
            this.Payload = Payload;
            this.PayloadField = PayloadField;
            this.RangeKeyField = RangeKeyField;
            this.RangeKeyType = RangeKeyType;
            this.RangeKeyValue = RangeKeyValue;
            this.TableName = TableName;
        }
    }
}
