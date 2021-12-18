// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    [OutputType]
    public sealed class DomainResourceSpec
    {
        /// <summary>
        /// The instance type that the image version runs on.
        /// </summary>
        public readonly Pulumi.AwsNative.SageMaker.DomainResourceSpecInstanceType? InstanceType;
        /// <summary>
        /// The ARN of the SageMaker image that the image version belongs to.
        /// </summary>
        public readonly string? SageMakerImageArn;
        /// <summary>
        /// The ARN of the image version created on the instance.
        /// </summary>
        public readonly string? SageMakerImageVersionArn;

        [OutputConstructor]
        private DomainResourceSpec(
            Pulumi.AwsNative.SageMaker.DomainResourceSpecInstanceType? instanceType,

            string? sageMakerImageArn,

            string? sageMakerImageVersionArn)
        {
            InstanceType = instanceType;
            SageMakerImageArn = sageMakerImageArn;
            SageMakerImageVersionArn = sageMakerImageVersionArn;
        }
    }
}
