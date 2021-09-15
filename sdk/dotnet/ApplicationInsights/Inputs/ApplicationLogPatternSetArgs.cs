// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApplicationInsights.Inputs
{

    /// <summary>
    /// The log pattern set.
    /// </summary>
    public sealed class ApplicationLogPatternSetArgs : Pulumi.ResourceArgs
    {
        [Input("logPatterns", required: true)]
        private InputList<Inputs.ApplicationLogPatternArgs>? _logPatterns;

        /// <summary>
        /// The log patterns of a set.
        /// </summary>
        public InputList<Inputs.ApplicationLogPatternArgs> LogPatterns
        {
            get => _logPatterns ?? (_logPatterns = new InputList<Inputs.ApplicationLogPatternArgs>());
            set => _logPatterns = value;
        }

        /// <summary>
        /// The name of the log pattern set.
        /// </summary>
        [Input("patternSetName", required: true)]
        public Input<string> PatternSetName { get; set; } = null!;

        public ApplicationLogPatternSetArgs()
        {
        }
    }
}
