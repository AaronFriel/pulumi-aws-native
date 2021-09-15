// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataSync.Inputs
{

    /// <summary>
    /// A key-value pair to associate with a resource.
    /// </summary>
    public sealed class TaskTagArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The key for an AWS resource tag.
        /// </summary>
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        /// <summary>
        /// The value for an AWS resource tag.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public TaskTagArgs()
        {
        }
    }
}
