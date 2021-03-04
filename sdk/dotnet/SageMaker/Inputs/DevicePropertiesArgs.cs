// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html
    /// </summary>
    public sealed class DevicePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html#cfn-sagemaker-device-device
        /// </summary>
        [Input("Device")]
        public InputUnion<System.Text.Json.JsonElement, string>? Device { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-device.html#cfn-sagemaker-device-tags
        /// </summary>
        [Input("Tags")]
        public Input<Pulumi.AwsNative.Inputs.TagArgs>? Tags { get; set; }

        public DevicePropertiesArgs()
        {
        }
    }
}
