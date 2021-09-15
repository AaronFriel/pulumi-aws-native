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
    /// &lt;p&gt;Permission for the resource.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class DataSourceResourcePermission
    {
        /// <summary>
        /// &lt;p&gt;The IAM action to grant or revoke permissions on.&lt;/p&gt;
        /// </summary>
        public readonly ImmutableArray<string> Actions;
        /// <summary>
        /// &lt;p&gt;The Amazon Resource Name (ARN) of the principal. This can be one of the
        ///             following:&lt;/p&gt;
        ///         &lt;ul&gt;
        ///             &lt;li&gt;
        ///                 &lt;p&gt;The ARN of an Amazon QuickSight user or group associated with a data source or dataset. (This is common.)&lt;/p&gt;
        ///             &lt;/li&gt;
        ///             &lt;li&gt;
        ///                 &lt;p&gt;The ARN of an Amazon QuickSight user, group, or namespace associated with an analysis, dashboard, template, or theme. (This is common.)&lt;/p&gt;
        ///             &lt;/li&gt;
        ///             &lt;li&gt;
        ///                 &lt;p&gt;The ARN of an AWS account root: This is an IAM ARN rather than a QuickSight
        ///                     ARN. Use this option only to share resources (templates) across AWS accounts.
        ///                     (This is less common.) &lt;/p&gt;
        ///             &lt;/li&gt;
        ///          &lt;/ul&gt;
        /// </summary>
        public readonly string Principal;

        [OutputConstructor]
        private DataSourceResourcePermission(
            ImmutableArray<string> actions,

            string principal)
        {
            Actions = actions;
            Principal = principal;
        }
    }
}
