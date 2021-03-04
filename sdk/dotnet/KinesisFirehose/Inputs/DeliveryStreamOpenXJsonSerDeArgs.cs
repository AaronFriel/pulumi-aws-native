// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisFirehose.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html
    /// </summary>
    public sealed class DeliveryStreamOpenXJsonSerDeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-caseinsensitive
        /// </summary>
        [Input("CaseInsensitive")]
        public Input<bool>? CaseInsensitive { get; set; }

        [Input("ColumnToJsonKeyMappings")]
        private InputMap<string>? _ColumnToJsonKeyMappings;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-columntojsonkeymappings
        /// </summary>
        public InputMap<string> ColumnToJsonKeyMappings
        {
            get => _ColumnToJsonKeyMappings ?? (_ColumnToJsonKeyMappings = new InputMap<string>());
            set => _ColumnToJsonKeyMappings = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-convertdotsinjsonkeystounderscores
        /// </summary>
        [Input("ConvertDotsInJsonKeysToUnderscores")]
        public Input<bool>? ConvertDotsInJsonKeysToUnderscores { get; set; }

        public DeliveryStreamOpenXJsonSerDeArgs()
        {
        }
    }
}
