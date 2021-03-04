// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    [OutputType]
    public sealed class MLTransformTransformEncryption
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption.html#cfn-glue-mltransform-transformencryption-mluserdataencryption
        /// </summary>
        public readonly Outputs.MLTransformMLUserDataEncryption? MLUserDataEncryption;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-mltransform-transformencryption.html#cfn-glue-mltransform-transformencryption-taskrunsecurityconfigurationname
        /// </summary>
        public readonly string? TaskRunSecurityConfigurationName;

        [OutputConstructor]
        private MLTransformTransformEncryption(
            Outputs.MLTransformMLUserDataEncryption? MLUserDataEncryption,

            string? TaskRunSecurityConfigurationName)
        {
            this.MLUserDataEncryption = MLUserDataEncryption;
            this.TaskRunSecurityConfigurationName = TaskRunSecurityConfigurationName;
        }
    }
}
