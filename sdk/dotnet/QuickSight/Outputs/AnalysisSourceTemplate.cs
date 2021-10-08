// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;The source template of an analysis.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class AnalysisSourceTemplate
    {
        /// <summary>
        /// &lt;p&gt;The Amazon Resource Name (ARN) of the source template of an analysis.&lt;/p&gt;
        /// </summary>
        public readonly string Arn;
        /// <summary>
        /// &lt;p&gt;The dataset references of the source template of an analysis.&lt;/p&gt;
        /// </summary>
        public readonly ImmutableArray<Outputs.AnalysisDataSetReference> DataSetReferences;

        [OutputConstructor]
        private AnalysisSourceTemplate(
            string arn,

            ImmutableArray<Outputs.AnalysisDataSetReference> dataSetReferences)
        {
            Arn = arn;
            DataSetReferences = dataSetReferences;
        }
    }
}