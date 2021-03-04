// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EMR.Outputs
{

    [OutputType]
    public sealed class ClusterHadoopJarStepConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-args
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-jar
        /// </summary>
        public readonly string Jar;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-mainclass
        /// </summary>
        public readonly string? MainClass;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-hadoopjarstepconfig.html#cfn-elasticmapreduce-cluster-hadoopjarstepconfig-stepproperties
        /// </summary>
        public readonly ImmutableArray<Outputs.ClusterKeyValue> StepProperties;

        [OutputConstructor]
        private ClusterHadoopJarStepConfig(
            ImmutableArray<string> Args,

            string Jar,

            string? MainClass,

            ImmutableArray<Outputs.ClusterKeyValue> StepProperties)
        {
            this.Args = Args;
            this.Jar = Jar;
            this.MainClass = MainClass;
            this.StepProperties = StepProperties;
        }
    }
}
