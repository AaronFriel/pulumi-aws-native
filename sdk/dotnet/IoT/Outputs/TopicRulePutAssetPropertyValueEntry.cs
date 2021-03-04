// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class TopicRulePutAssetPropertyValueEntry
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-assetid
        /// </summary>
        public readonly string? AssetId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-entryid
        /// </summary>
        public readonly string? EntryId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyalias
        /// </summary>
        public readonly string? PropertyAlias;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyid
        /// </summary>
        public readonly string? PropertyId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-topicrule-putassetpropertyvalueentry.html#cfn-iot-topicrule-putassetpropertyvalueentry-propertyvalues
        /// </summary>
        public readonly ImmutableArray<Outputs.TopicRuleAssetPropertyValue> PropertyValues;

        [OutputConstructor]
        private TopicRulePutAssetPropertyValueEntry(
            string? AssetId,

            string? EntryId,

            string? PropertyAlias,

            string? PropertyId,

            ImmutableArray<Outputs.TopicRuleAssetPropertyValue> PropertyValues)
        {
            this.AssetId = AssetId;
            this.EntryId = EntryId;
            this.PropertyAlias = PropertyAlias;
            this.PropertyId = PropertyId;
            this.PropertyValues = PropertyValues;
        }
    }
}
