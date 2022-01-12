// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lex.Outputs
{

    /// <summary>
    /// The location of audio log files collected when conversation logging is enabled for a bot.
    /// </summary>
    [OutputType]
    public sealed class BotAliasAudioLogDestination
    {
        public readonly Outputs.BotAliasS3BucketLogDestination? S3Bucket;

        [OutputConstructor]
        private BotAliasAudioLogDestination(Outputs.BotAliasS3BucketLogDestination? s3Bucket)
        {
            S3Bucket = s3Bucket;
        }
    }
}
