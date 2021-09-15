// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Athena.Outputs
{

    /// <summary>
    /// The Athena engine version for running queries.
    /// </summary>
    [OutputType]
    public sealed class WorkGroupEngineVersion
    {
        public readonly string? EffectiveEngineVersion;
        public readonly string? SelectedEngineVersion;

        [OutputConstructor]
        private WorkGroupEngineVersion(
            string? effectiveEngineVersion,

            string? selectedEngineVersion)
        {
            EffectiveEngineVersion = effectiveEngineVersion;
            SelectedEngineVersion = selectedEngineVersion;
        }
    }
}
