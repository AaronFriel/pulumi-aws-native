// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ImageBuilder.Outputs
{

    [OutputType]
    public sealed class ComponentAttributes
    {
        public readonly string Arn;
        public readonly bool Encrypted;
        public readonly string Type;

        [OutputConstructor]
        private ComponentAttributes(
            string Arn,

            bool Encrypted,

            string Type)
        {
            this.Arn = Arn;
            this.Encrypted = Encrypted;
            this.Type = Type;
        }
    }
}
