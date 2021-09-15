// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EFS.Outputs
{

    [OutputType]
    public sealed class AccessPointPosixUser
    {
        /// <summary>
        /// The POSIX group ID used for all file system operations using this access point.
        /// </summary>
        public readonly string Gid;
        /// <summary>
        /// Secondary POSIX group IDs used for all file system operations using this access point.
        /// </summary>
        public readonly ImmutableArray<string> SecondaryGids;
        /// <summary>
        /// The POSIX user ID used for all file system operations using this access point.
        /// </summary>
        public readonly string Uid;

        [OutputConstructor]
        private AccessPointPosixUser(
            string gid,

            ImmutableArray<string> secondaryGids,

            string uid)
        {
            Gid = gid;
            SecondaryGids = secondaryGids;
            Uid = uid;
        }
    }
}
