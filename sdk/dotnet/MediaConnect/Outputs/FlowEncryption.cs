// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaConnect.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html
    /// </summary>
    [OutputType]
    public sealed class FlowEncryption
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-algorithm
        /// </summary>
        public readonly string Algorithm;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-constantinitializationvector
        /// </summary>
        public readonly string? ConstantInitializationVector;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-deviceid
        /// </summary>
        public readonly string? DeviceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-keytype
        /// </summary>
        public readonly string? KeyType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-region
        /// </summary>
        public readonly string? Region;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-resourceid
        /// </summary>
        public readonly string? ResourceId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-rolearn
        /// </summary>
        public readonly string RoleArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-secretarn
        /// </summary>
        public readonly string? SecretArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-mediaconnect-flow-encryption.html#cfn-mediaconnect-flow-encryption-url
        /// </summary>
        public readonly string? Url;

        [OutputConstructor]
        private FlowEncryption(
            string algorithm,

            string? constantInitializationVector,

            string? deviceId,

            string? keyType,

            string? region,

            string? resourceId,

            string roleArn,

            string? secretArn,

            string? url)
        {
            Algorithm = algorithm;
            ConstantInitializationVector = constantInitializationVector;
            DeviceId = deviceId;
            KeyType = keyType;
            Region = region;
            ResourceId = resourceId;
            RoleArn = roleArn;
            SecretArn = secretArn;
            Url = url;
        }
    }
}