// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Inputs
{

    /// <summary>
    /// &lt;p&gt;Dashboard publish options.&lt;/p&gt;
    /// </summary>
    public sealed class DashboardDashboardPublishOptionsArgs : Pulumi.ResourceArgs
    {
        [Input("adHocFilteringOption")]
        public Input<Inputs.DashboardAdHocFilteringOptionArgs>? AdHocFilteringOption { get; set; }

        [Input("exportToCSVOption")]
        public Input<Inputs.DashboardExportToCSVOptionArgs>? ExportToCSVOption { get; set; }

        [Input("sheetControlsOption")]
        public Input<Inputs.DashboardSheetControlsOptionArgs>? SheetControlsOption { get; set; }

        public DashboardDashboardPublishOptionsArgs()
        {
        }
    }
}
