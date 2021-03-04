// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-provisioningtemplate-tags.html
    /// </summary>
    public sealed class ProvisioningTemplateTagsArgs : Pulumi.ResourceArgs
    {
        [Input("Tags")]
        private InputList<object>? _Tags;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-provisioningtemplate-tags.html#cfn-iot-provisioningtemplate-tags-tags
        /// </summary>
        public InputList<object> Tags
        {
            get => _Tags ?? (_Tags = new InputList<object>());
            set => _Tags = value;
        }

        public ProvisioningTemplateTagsArgs()
        {
        }
    }
}
