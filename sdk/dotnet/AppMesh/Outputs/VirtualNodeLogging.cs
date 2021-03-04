// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppMesh.Outputs
{

    [OutputType]
    public sealed class VirtualNodeLogging
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appmesh-virtualnode-logging.html#cfn-appmesh-virtualnode-logging-accesslog
        /// </summary>
        public readonly Outputs.VirtualNodeAccessLog? AccessLog;

        [OutputConstructor]
        private VirtualNodeLogging(Outputs.VirtualNodeAccessLog? AccessLog)
        {
            this.AccessLog = AccessLog;
        }
    }
}
