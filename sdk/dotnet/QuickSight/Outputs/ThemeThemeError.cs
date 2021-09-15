// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;Theme error.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class ThemeThemeError
    {
        /// <summary>
        /// &lt;p&gt;The error message.&lt;/p&gt;
        /// </summary>
        public readonly string? Message;
        public readonly string? Type;

        [OutputConstructor]
        private ThemeThemeError(
            string? message,

            string? type)
        {
            Message = message;
            Type = type;
        }
    }
}
