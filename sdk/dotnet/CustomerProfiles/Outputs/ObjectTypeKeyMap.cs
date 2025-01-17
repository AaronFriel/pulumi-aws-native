// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CustomerProfiles.Outputs
{

    [OutputType]
    public sealed class ObjectTypeKeyMap
    {
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.ObjectTypeKey> ObjectTypeKeyList;

        [OutputConstructor]
        private ObjectTypeKeyMap(
            string? name,

            ImmutableArray<Outputs.ObjectTypeKey> objectTypeKeyList)
        {
            Name = name;
            ObjectTypeKeyList = objectTypeKeyList;
        }
    }
}
