// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-componentconfiguration.html
    /// </summary>
    public sealed class ImageRecipeComponentConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-imagebuilder-imagerecipe-componentconfiguration.html#cfn-imagebuilder-imagerecipe-componentconfiguration-componentarn
        /// </summary>
        [Input("ComponentArn")]
        public Input<string>? ComponentArn { get; set; }

        public ImageRecipeComponentConfigurationArgs()
        {
        }
    }
}
