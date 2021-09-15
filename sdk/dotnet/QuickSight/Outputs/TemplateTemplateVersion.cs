// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;A version of a template.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class TemplateTemplateVersion
    {
        /// <summary>
        /// &lt;p&gt;The time that this template version was created.&lt;/p&gt;
        /// </summary>
        public readonly string? CreatedTime;
        /// <summary>
        /// &lt;p&gt;Schema of the dataset identified by the placeholder. Any dashboard created from this
        ///             template should be bound to new datasets matching the same schema described through this
        ///             API operation.&lt;/p&gt;
        /// </summary>
        public readonly ImmutableArray<Outputs.TemplateDataSetConfiguration> DataSetConfigurations;
        /// <summary>
        /// &lt;p&gt;The description of the template.&lt;/p&gt;
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// &lt;p&gt;Errors associated with this template version.&lt;/p&gt;
        /// </summary>
        public readonly ImmutableArray<Outputs.TemplateTemplateError> Errors;
        /// <summary>
        /// &lt;p&gt;A list of the associated sheets with the unique identifier and name of each sheet.&lt;/p&gt;
        /// </summary>
        public readonly ImmutableArray<Outputs.TemplateSheet> Sheets;
        /// <summary>
        /// &lt;p&gt;The Amazon Resource Name (ARN) of an analysis or template that was used to create this
        ///             template.&lt;/p&gt;
        /// </summary>
        public readonly string? SourceEntityArn;
        public readonly string? Status;
        /// <summary>
        /// &lt;p&gt;The ARN of the theme associated with this version of the template.&lt;/p&gt;
        /// </summary>
        public readonly string? ThemeArn;
        /// <summary>
        /// &lt;p&gt;The version number of the template version.&lt;/p&gt;
        /// </summary>
        public readonly double? VersionNumber;

        [OutputConstructor]
        private TemplateTemplateVersion(
            string? createdTime,

            ImmutableArray<Outputs.TemplateDataSetConfiguration> dataSetConfigurations,

            string? description,

            ImmutableArray<Outputs.TemplateTemplateError> errors,

            ImmutableArray<Outputs.TemplateSheet> sheets,

            string? sourceEntityArn,

            string? status,

            string? themeArn,

            double? versionNumber)
        {
            CreatedTime = createdTime;
            DataSetConfigurations = dataSetConfigurations;
            Description = description;
            Errors = errors;
            Sheets = sheets;
            SourceEntityArn = sourceEntityArn;
            Status = status;
            ThemeArn = themeArn;
            VersionNumber = versionNumber;
        }
    }
}
