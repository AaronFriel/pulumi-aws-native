// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeCommit.Outputs
{

    [OutputType]
    public sealed class RepositoryAttributes
    {
        public readonly string Arn;
        public readonly string CloneUrlHttp;
        public readonly string CloneUrlSsh;
        public readonly string Name;

        [OutputConstructor]
        private RepositoryAttributes(
            string Arn,

            string CloneUrlHttp,

            string CloneUrlSsh,

            string Name)
        {
            this.Arn = Arn;
            this.CloneUrlHttp = CloneUrlHttp;
            this.CloneUrlSsh = CloneUrlSsh;
            this.Name = Name;
        }
    }
}
