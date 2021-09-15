// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    /// <summary>
    /// Parameters to define a mitigation action that moves devices associated with a certificate to one or more specified thing groups, typically for quarantine.
    /// </summary>
    [OutputType]
    public sealed class MitigationActionAddThingsToThingGroupParams
    {
        /// <summary>
        /// Specifies if this mitigation action can move the things that triggered the mitigation action out of one or more dynamic thing groups.
        /// </summary>
        public readonly bool? OverrideDynamicGroups;
        /// <summary>
        /// The list of groups to which you want to add the things that triggered the mitigation action.
        /// </summary>
        public readonly ImmutableArray<string> ThingGroupNames;

        [OutputConstructor]
        private MitigationActionAddThingsToThingGroupParams(
            bool? overrideDynamicGroups,

            ImmutableArray<string> thingGroupNames)
        {
            OverrideDynamicGroups = overrideDynamicGroups;
            ThingGroupNames = thingGroupNames;
        }
    }
}
