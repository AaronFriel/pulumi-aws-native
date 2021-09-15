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
    /// Parameters to define a mitigation action that enables AWS IoT logging at a specified level of detail.
    /// </summary>
    [OutputType]
    public sealed class MitigationActionEnableIoTLoggingParams
    {
        /// <summary>
        ///  Specifies which types of information are logged.
        /// </summary>
        public readonly string LogLevel;
        /// <summary>
        ///  The ARN of the IAM role used for logging.
        /// </summary>
        public readonly string RoleArnForLogging;

        [OutputConstructor]
        private MitigationActionEnableIoTLoggingParams(
            string logLevel,

            string roleArnForLogging)
        {
            LogLevel = logLevel;
            RoleArnForLogging = roleArnForLogging;
        }
    }
}
