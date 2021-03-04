// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RoboMaker.Outputs
{

    [OutputType]
    public sealed class SimulationApplicationVersionProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplicationversion.html#cfn-robomaker-simulationapplicationversion-application
        /// </summary>
        public readonly string Application;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-simulationapplicationversion.html#cfn-robomaker-simulationapplicationversion-currentrevisionid
        /// </summary>
        public readonly string? CurrentRevisionId;

        [OutputConstructor]
        private SimulationApplicationVersionProperties(
            string Application,

            string? CurrentRevisionId)
        {
            this.Application = Application;
            this.CurrentRevisionId = CurrentRevisionId;
        }
    }
}
