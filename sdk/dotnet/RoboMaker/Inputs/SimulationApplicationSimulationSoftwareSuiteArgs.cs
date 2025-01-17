// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RoboMaker.Inputs
{

    /// <summary>
    /// Information about a simulation software suite.
    /// </summary>
    public sealed class SimulationApplicationSimulationSoftwareSuiteArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the simulation software suite.
        /// </summary>
        [Input("name", required: true)]
        public Input<Pulumi.AwsNative.RoboMaker.SimulationApplicationSimulationSoftwareSuiteName> Name { get; set; } = null!;

        /// <summary>
        /// The version of the simulation software suite.
        /// </summary>
        [Input("version", required: true)]
        public Input<Pulumi.AwsNative.RoboMaker.SimulationApplicationSimulationSoftwareSuiteVersion> Version { get; set; } = null!;

        public SimulationApplicationSimulationSoftwareSuiteArgs()
        {
        }
    }
}
