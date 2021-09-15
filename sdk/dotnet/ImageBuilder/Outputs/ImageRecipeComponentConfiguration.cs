// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Outputs
{

    /// <summary>
    /// Configuration details of the component.
    /// </summary>
    [OutputType]
    public sealed class ImageRecipeComponentConfiguration
    {
        /// <summary>
        /// The Amazon Resource Name (ARN) of the component.
        /// </summary>
        public readonly string? ComponentArn;
        /// <summary>
        /// A group of parameter settings that are used to configure the component for a specific recipe.
        /// </summary>
        public readonly ImmutableArray<Outputs.ImageRecipeComponentParameter> Parameters;

        [OutputConstructor]
        private ImageRecipeComponentConfiguration(
            string? componentArn,

            ImmutableArray<Outputs.ImageRecipeComponentParameter> parameters)
        {
            ComponentArn = componentArn;
            Parameters = parameters;
        }
    }
}
