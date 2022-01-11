// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lex.Outputs
{

    [OutputType]
    public sealed class BotAliasCloudWatchLogGroupLogDestination
    {
        /// <summary>
        /// A string used to identify this tag
        /// </summary>
        public readonly string CloudWatchLogGroupArn;
        /// <summary>
        /// A string containing the value for the tag
        /// </summary>
        public readonly string LogPrefix;

        [OutputConstructor]
        private BotAliasCloudWatchLogGroupLogDestination(
            string cloudWatchLogGroupArn,

            string logPrefix)
        {
            CloudWatchLogGroupArn = cloudWatchLogGroupArn;
            LogPrefix = logPrefix;
        }
    }
}
