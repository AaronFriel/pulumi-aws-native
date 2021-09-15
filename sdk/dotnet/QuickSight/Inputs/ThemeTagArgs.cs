// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Inputs
{

    /// <summary>
    /// &lt;p&gt;The key or keys of the key-value pairs for the resource tag or tags assigned to the
    ///             resource.&lt;/p&gt;
    /// </summary>
    public sealed class ThemeTagArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;p&gt;Tag key.&lt;/p&gt;
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// &lt;p&gt;Tag value.&lt;/p&gt;
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public ThemeTagArgs()
        {
        }
    }
}
