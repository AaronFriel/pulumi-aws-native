// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda.Outputs
{

    [OutputType]
    public sealed class FunctionImageConfig
    {
        /// <summary>
        /// Command.
        /// </summary>
        public readonly ImmutableArray<string> Command;
        /// <summary>
        /// EntryPoint.
        /// </summary>
        public readonly ImmutableArray<string> EntryPoint;
        /// <summary>
        /// WorkingDirectory.
        /// </summary>
        public readonly string? WorkingDirectory;

        [OutputConstructor]
        private FunctionImageConfig(
            ImmutableArray<string> command,

            ImmutableArray<string> entryPoint,

            string? workingDirectory)
        {
            Command = command;
            EntryPoint = entryPoint;
            WorkingDirectory = workingDirectory;
        }
    }
}
