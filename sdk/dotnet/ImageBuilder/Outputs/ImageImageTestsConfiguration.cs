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
    /// The image tests configuration used when creating this image.
    /// </summary>
    [OutputType]
    public sealed class ImageImageTestsConfiguration
    {
        /// <summary>
        /// ImageTestsEnabled
        /// </summary>
        public readonly bool? ImageTestsEnabled;
        /// <summary>
        /// TimeoutMinutes
        /// </summary>
        public readonly int? TimeoutMinutes;

        [OutputConstructor]
        private ImageImageTestsConfiguration(
            bool? imageTestsEnabled,

            int? timeoutMinutes)
        {
            ImageTestsEnabled = imageTestsEnabled;
            TimeoutMinutes = timeoutMinutes;
        }
    }
}
