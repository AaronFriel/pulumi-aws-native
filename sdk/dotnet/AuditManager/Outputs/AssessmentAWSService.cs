// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AuditManager.Outputs
{

    [OutputType]
    public sealed class AssessmentAWSService
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-auditmanager-assessment-awsservice.html#cfn-auditmanager-assessment-awsservice-servicename
        /// </summary>
        public readonly string? ServiceName;

        [OutputConstructor]
        private AssessmentAWSService(string? serviceName)
        {
            ServiceName = serviceName;
        }
    }
}
