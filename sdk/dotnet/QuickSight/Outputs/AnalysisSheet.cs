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
    /// &lt;p&gt;A &lt;i&gt;sheet&lt;/i&gt;, which is an object that contains a set of visuals that
    ///             are viewed together on one page in the Amazon QuickSight console. Every analysis and dashboard
    ///             contains at least one sheet. Each sheet contains at least one visualization widget, for
    ///             example a chart, pivot table, or narrative insight. Sheets can be associated with other
    ///             components, such as controls, filters, and so on.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class AnalysisSheet
    {
        /// <summary>
        /// &lt;p&gt;The name of a sheet. This name is displayed on the sheet's tab in the QuickSight
        ///             console.&lt;/p&gt;
        /// </summary>
        public readonly string? Name;
        /// <summary>
        /// &lt;p&gt;The unique identifier associated with a sheet.&lt;/p&gt;
        /// </summary>
        public readonly string? SheetId;

        [OutputConstructor]
        private AnalysisSheet(
            string? name,

            string? sheetId)
        {
            Name = name;
            SheetId = sheetId;
        }
    }
}
