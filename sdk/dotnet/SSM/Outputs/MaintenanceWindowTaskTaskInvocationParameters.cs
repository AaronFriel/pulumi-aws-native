// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SSM.Outputs
{

    [OutputType]
    public sealed class MaintenanceWindowTaskTaskInvocationParameters
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowautomationparameters
        /// </summary>
        public readonly Outputs.MaintenanceWindowTaskMaintenanceWindowAutomationParameters? MaintenanceWindowAutomationParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowlambdaparameters
        /// </summary>
        public readonly Outputs.MaintenanceWindowTaskMaintenanceWindowLambdaParameters? MaintenanceWindowLambdaParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowruncommandparameters
        /// </summary>
        public readonly Outputs.MaintenanceWindowTaskMaintenanceWindowRunCommandParameters? MaintenanceWindowRunCommandParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-maintenancewindowtask-taskinvocationparameters.html#cfn-ssm-maintenancewindowtask-taskinvocationparameters-maintenancewindowstepfunctionsparameters
        /// </summary>
        public readonly Outputs.MaintenanceWindowTaskMaintenanceWindowStepFunctionsParameters? MaintenanceWindowStepFunctionsParameters;

        [OutputConstructor]
        private MaintenanceWindowTaskTaskInvocationParameters(
            Outputs.MaintenanceWindowTaskMaintenanceWindowAutomationParameters? MaintenanceWindowAutomationParameters,

            Outputs.MaintenanceWindowTaskMaintenanceWindowLambdaParameters? MaintenanceWindowLambdaParameters,

            Outputs.MaintenanceWindowTaskMaintenanceWindowRunCommandParameters? MaintenanceWindowRunCommandParameters,

            Outputs.MaintenanceWindowTaskMaintenanceWindowStepFunctionsParameters? MaintenanceWindowStepFunctionsParameters)
        {
            this.MaintenanceWindowAutomationParameters = MaintenanceWindowAutomationParameters;
            this.MaintenanceWindowLambdaParameters = MaintenanceWindowLambdaParameters;
            this.MaintenanceWindowRunCommandParameters = MaintenanceWindowRunCommandParameters;
            this.MaintenanceWindowStepFunctionsParameters = MaintenanceWindowStepFunctionsParameters;
        }
    }
}
