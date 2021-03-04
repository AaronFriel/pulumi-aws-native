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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-command
        /// </summary>
        public readonly ImmutableArray<string> Command;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-entrypoint
        /// </summary>
        public readonly ImmutableArray<string> EntryPoint;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-imageconfig.html#cfn-lambda-function-imageconfig-workingdirectory
        /// </summary>
        public readonly string? WorkingDirectory;

        [OutputConstructor]
        private FunctionImageConfig(
            ImmutableArray<string> Command,

            ImmutableArray<string> EntryPoint,

            string? WorkingDirectory)
        {
            this.Command = Command;
            this.EntryPoint = EntryPoint;
            this.WorkingDirectory = WorkingDirectory;
        }
    }
}
