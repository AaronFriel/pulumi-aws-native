// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SecretsManager.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html
    /// </summary>
    [OutputType]
    public sealed class RotationScheduleHostedRotationLambda
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-kmskeyarn
        /// </summary>
        public readonly string? KmsKeyArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-mastersecretarn
        /// </summary>
        public readonly string? MasterSecretArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-mastersecretkmskeyarn
        /// </summary>
        public readonly string? MasterSecretKmsKeyArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-rotationlambdaname
        /// </summary>
        public readonly string? RotationLambdaName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-rotationtype
        /// </summary>
        public readonly string RotationType;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-vpcsecuritygroupids
        /// </summary>
        public readonly string? VpcSecurityGroupIds;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-hostedrotationlambda.html#cfn-secretsmanager-rotationschedule-hostedrotationlambda-vpcsubnetids
        /// </summary>
        public readonly string? VpcSubnetIds;

        [OutputConstructor]
        private RotationScheduleHostedRotationLambda(
            string? kmsKeyArn,

            string? masterSecretArn,

            string? masterSecretKmsKeyArn,

            string? rotationLambdaName,

            string rotationType,

            string? vpcSecurityGroupIds,

            string? vpcSubnetIds)
        {
            KmsKeyArn = kmsKeyArn;
            MasterSecretArn = masterSecretArn;
            MasterSecretKmsKeyArn = masterSecretKmsKeyArn;
            RotationLambdaName = rotationLambdaName;
            RotationType = rotationType;
            VpcSecurityGroupIds = vpcSecurityGroupIds;
            VpcSubnetIds = vpcSubnetIds;
        }
    }
}