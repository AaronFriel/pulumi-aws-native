// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSO.Outputs
{

    /// <summary>
    /// The metadata that you apply to the permission set to help you categorize and organize them.
    /// </summary>
    [OutputType]
    public sealed class PermissionSetTag
    {
        public readonly string Key;
        public readonly string Value;

        [OutputConstructor]
        private PermissionSetTag(
            string key,

            string value)
        {
            Key = key;
            Value = value;
        }
    }
}
