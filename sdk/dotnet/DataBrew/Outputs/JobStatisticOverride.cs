// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    [OutputType]
    public sealed class JobStatisticOverride
    {
        public readonly Outputs.JobParameterMap Parameters;
        public readonly string Statistic;

        [OutputConstructor]
        private JobStatisticOverride(
            Outputs.JobParameterMap parameters,

            string statistic)
        {
            Parameters = parameters;
            Statistic = statistic;
        }
    }
}
