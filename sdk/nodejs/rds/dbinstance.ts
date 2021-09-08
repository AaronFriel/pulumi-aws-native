// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html
 */
export class DBInstance extends pulumi.CustomResource {
    /**
     * Get an existing DBInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DBInstance {
        return new DBInstance(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:rds:DBInstance';

    /**
     * Returns true if the given object is an instance of DBInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DBInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DBInstance.__pulumiType;
    }

    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allocatedstorage
     */
    public readonly allocatedStorage!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allowmajorversionupgrade
     */
    public readonly allowMajorVersionUpgrade!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-associatedroles
     */
    public readonly associatedRoles!: pulumi.Output<outputs.rds.DBInstanceDBInstanceRole[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-autominorversionupgrade
     */
    public readonly autoMinorVersionUpgrade!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-availabilityzone
     */
    public readonly availabilityZone!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-backupretentionperiod
     */
    public readonly backupRetentionPeriod!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-cacertificateidentifier
     */
    public readonly cACertificateIdentifier!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-charactersetname
     */
    public readonly characterSetName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-copytagstosnapshot
     */
    public readonly copyTagsToSnapshot!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbclusteridentifier
     */
    public readonly dBClusterIdentifier!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceclass
     */
    public readonly dBInstanceClass!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceidentifier
     */
    public readonly dBInstanceIdentifier!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbname
     */
    public readonly dBName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbparametergroupname
     */
    public readonly dBParameterGroupName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsecuritygroups
     */
    public readonly dBSecurityGroups!: pulumi.Output<string[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsnapshotidentifier
     */
    public readonly dBSnapshotIdentifier!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsubnetgroupname
     */
    public readonly dBSubnetGroupName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deleteautomatedbackups
     */
    public readonly deleteAutomatedBackups!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deletionprotection
     */
    public readonly deletionProtection!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domain
     */
    public readonly domain!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domainiamrolename
     */
    public readonly domainIAMRoleName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enablecloudwatchlogsexports
     */
    public readonly enableCloudwatchLogsExports!: pulumi.Output<string[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableiamdatabaseauthentication
     */
    public readonly enableIAMDatabaseAuthentication!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableperformanceinsights
     */
    public readonly enablePerformanceInsights!: pulumi.Output<boolean | undefined>;
    public /*out*/ readonly endpointAddress!: pulumi.Output<string>;
    public /*out*/ readonly endpointPort!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engine
     */
    public readonly engine!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engineversion
     */
    public readonly engineVersion!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-iops
     */
    public readonly iops!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-kmskeyid
     */
    public readonly kmsKeyId!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-licensemodel
     */
    public readonly licenseModel!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masteruserpassword
     */
    public readonly masterUserPassword!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masterusername
     */
    public readonly masterUsername!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-maxallocatedstorage
     */
    public readonly maxAllocatedStorage!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringinterval
     */
    public readonly monitoringInterval!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringrolearn
     */
    public readonly monitoringRoleArn!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-multiaz
     */
    public readonly multiAZ!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-optiongroupname
     */
    public readonly optionGroupName!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightskmskeyid
     */
    public readonly performanceInsightsKMSKeyId!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightsretentionperiod
     */
    public readonly performanceInsightsRetentionPeriod!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-port
     */
    public readonly port!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredbackupwindow
     */
    public readonly preferredBackupWindow!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredmaintenancewindow
     */
    public readonly preferredMaintenanceWindow!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-processorfeatures
     */
    public readonly processorFeatures!: pulumi.Output<outputs.rds.DBInstanceProcessorFeature[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-promotiontier
     */
    public readonly promotionTier!: pulumi.Output<number | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-publiclyaccessible
     */
    public readonly publiclyAccessible!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourcedbinstanceidentifier
     */
    public readonly sourceDBInstanceIdentifier!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourceregion
     */
    public readonly sourceRegion!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storageencrypted
     */
    public readonly storageEncrypted!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storagetype
     */
    public readonly storageType!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-tags
     */
    public readonly tags!: pulumi.Output<outputs.Tag[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-timezone
     */
    public readonly timezone!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-usedefaultprocessorfeatures
     */
    public readonly useDefaultProcessorFeatures!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-vpcsecuritygroups
     */
    public readonly vPCSecurityGroups!: pulumi.Output<string[] | undefined>;

    /**
     * Create a DBInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DBInstanceArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.dBInstanceClass === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dBInstanceClass'");
            }
            inputs["allocatedStorage"] = args ? args.allocatedStorage : undefined;
            inputs["allowMajorVersionUpgrade"] = args ? args.allowMajorVersionUpgrade : undefined;
            inputs["associatedRoles"] = args ? args.associatedRoles : undefined;
            inputs["autoMinorVersionUpgrade"] = args ? args.autoMinorVersionUpgrade : undefined;
            inputs["availabilityZone"] = args ? args.availabilityZone : undefined;
            inputs["backupRetentionPeriod"] = args ? args.backupRetentionPeriod : undefined;
            inputs["cACertificateIdentifier"] = args ? args.cACertificateIdentifier : undefined;
            inputs["characterSetName"] = args ? args.characterSetName : undefined;
            inputs["copyTagsToSnapshot"] = args ? args.copyTagsToSnapshot : undefined;
            inputs["dBClusterIdentifier"] = args ? args.dBClusterIdentifier : undefined;
            inputs["dBInstanceClass"] = args ? args.dBInstanceClass : undefined;
            inputs["dBInstanceIdentifier"] = args ? args.dBInstanceIdentifier : undefined;
            inputs["dBName"] = args ? args.dBName : undefined;
            inputs["dBParameterGroupName"] = args ? args.dBParameterGroupName : undefined;
            inputs["dBSecurityGroups"] = args ? args.dBSecurityGroups : undefined;
            inputs["dBSnapshotIdentifier"] = args ? args.dBSnapshotIdentifier : undefined;
            inputs["dBSubnetGroupName"] = args ? args.dBSubnetGroupName : undefined;
            inputs["deleteAutomatedBackups"] = args ? args.deleteAutomatedBackups : undefined;
            inputs["deletionProtection"] = args ? args.deletionProtection : undefined;
            inputs["domain"] = args ? args.domain : undefined;
            inputs["domainIAMRoleName"] = args ? args.domainIAMRoleName : undefined;
            inputs["enableCloudwatchLogsExports"] = args ? args.enableCloudwatchLogsExports : undefined;
            inputs["enableIAMDatabaseAuthentication"] = args ? args.enableIAMDatabaseAuthentication : undefined;
            inputs["enablePerformanceInsights"] = args ? args.enablePerformanceInsights : undefined;
            inputs["engine"] = args ? args.engine : undefined;
            inputs["engineVersion"] = args ? args.engineVersion : undefined;
            inputs["iops"] = args ? args.iops : undefined;
            inputs["kmsKeyId"] = args ? args.kmsKeyId : undefined;
            inputs["licenseModel"] = args ? args.licenseModel : undefined;
            inputs["masterUserPassword"] = args ? args.masterUserPassword : undefined;
            inputs["masterUsername"] = args ? args.masterUsername : undefined;
            inputs["maxAllocatedStorage"] = args ? args.maxAllocatedStorage : undefined;
            inputs["monitoringInterval"] = args ? args.monitoringInterval : undefined;
            inputs["monitoringRoleArn"] = args ? args.monitoringRoleArn : undefined;
            inputs["multiAZ"] = args ? args.multiAZ : undefined;
            inputs["optionGroupName"] = args ? args.optionGroupName : undefined;
            inputs["performanceInsightsKMSKeyId"] = args ? args.performanceInsightsKMSKeyId : undefined;
            inputs["performanceInsightsRetentionPeriod"] = args ? args.performanceInsightsRetentionPeriod : undefined;
            inputs["port"] = args ? args.port : undefined;
            inputs["preferredBackupWindow"] = args ? args.preferredBackupWindow : undefined;
            inputs["preferredMaintenanceWindow"] = args ? args.preferredMaintenanceWindow : undefined;
            inputs["processorFeatures"] = args ? args.processorFeatures : undefined;
            inputs["promotionTier"] = args ? args.promotionTier : undefined;
            inputs["publiclyAccessible"] = args ? args.publiclyAccessible : undefined;
            inputs["sourceDBInstanceIdentifier"] = args ? args.sourceDBInstanceIdentifier : undefined;
            inputs["sourceRegion"] = args ? args.sourceRegion : undefined;
            inputs["storageEncrypted"] = args ? args.storageEncrypted : undefined;
            inputs["storageType"] = args ? args.storageType : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["timezone"] = args ? args.timezone : undefined;
            inputs["useDefaultProcessorFeatures"] = args ? args.useDefaultProcessorFeatures : undefined;
            inputs["vPCSecurityGroups"] = args ? args.vPCSecurityGroups : undefined;
            inputs["endpointAddress"] = undefined /*out*/;
            inputs["endpointPort"] = undefined /*out*/;
        } else {
            inputs["allocatedStorage"] = undefined /*out*/;
            inputs["allowMajorVersionUpgrade"] = undefined /*out*/;
            inputs["associatedRoles"] = undefined /*out*/;
            inputs["autoMinorVersionUpgrade"] = undefined /*out*/;
            inputs["availabilityZone"] = undefined /*out*/;
            inputs["backupRetentionPeriod"] = undefined /*out*/;
            inputs["cACertificateIdentifier"] = undefined /*out*/;
            inputs["characterSetName"] = undefined /*out*/;
            inputs["copyTagsToSnapshot"] = undefined /*out*/;
            inputs["dBClusterIdentifier"] = undefined /*out*/;
            inputs["dBInstanceClass"] = undefined /*out*/;
            inputs["dBInstanceIdentifier"] = undefined /*out*/;
            inputs["dBName"] = undefined /*out*/;
            inputs["dBParameterGroupName"] = undefined /*out*/;
            inputs["dBSecurityGroups"] = undefined /*out*/;
            inputs["dBSnapshotIdentifier"] = undefined /*out*/;
            inputs["dBSubnetGroupName"] = undefined /*out*/;
            inputs["deleteAutomatedBackups"] = undefined /*out*/;
            inputs["deletionProtection"] = undefined /*out*/;
            inputs["domain"] = undefined /*out*/;
            inputs["domainIAMRoleName"] = undefined /*out*/;
            inputs["enableCloudwatchLogsExports"] = undefined /*out*/;
            inputs["enableIAMDatabaseAuthentication"] = undefined /*out*/;
            inputs["enablePerformanceInsights"] = undefined /*out*/;
            inputs["endpointAddress"] = undefined /*out*/;
            inputs["endpointPort"] = undefined /*out*/;
            inputs["engine"] = undefined /*out*/;
            inputs["engineVersion"] = undefined /*out*/;
            inputs["iops"] = undefined /*out*/;
            inputs["kmsKeyId"] = undefined /*out*/;
            inputs["licenseModel"] = undefined /*out*/;
            inputs["masterUserPassword"] = undefined /*out*/;
            inputs["masterUsername"] = undefined /*out*/;
            inputs["maxAllocatedStorage"] = undefined /*out*/;
            inputs["monitoringInterval"] = undefined /*out*/;
            inputs["monitoringRoleArn"] = undefined /*out*/;
            inputs["multiAZ"] = undefined /*out*/;
            inputs["optionGroupName"] = undefined /*out*/;
            inputs["performanceInsightsKMSKeyId"] = undefined /*out*/;
            inputs["performanceInsightsRetentionPeriod"] = undefined /*out*/;
            inputs["port"] = undefined /*out*/;
            inputs["preferredBackupWindow"] = undefined /*out*/;
            inputs["preferredMaintenanceWindow"] = undefined /*out*/;
            inputs["processorFeatures"] = undefined /*out*/;
            inputs["promotionTier"] = undefined /*out*/;
            inputs["publiclyAccessible"] = undefined /*out*/;
            inputs["sourceDBInstanceIdentifier"] = undefined /*out*/;
            inputs["sourceRegion"] = undefined /*out*/;
            inputs["storageEncrypted"] = undefined /*out*/;
            inputs["storageType"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["timezone"] = undefined /*out*/;
            inputs["useDefaultProcessorFeatures"] = undefined /*out*/;
            inputs["vPCSecurityGroups"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(DBInstance.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a DBInstance resource.
 */
export interface DBInstanceArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allocatedstorage
     */
    allocatedStorage?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allowmajorversionupgrade
     */
    allowMajorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-associatedroles
     */
    associatedRoles?: pulumi.Input<pulumi.Input<inputs.rds.DBInstanceDBInstanceRoleArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-autominorversionupgrade
     */
    autoMinorVersionUpgrade?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-availabilityzone
     */
    availabilityZone?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-backupretentionperiod
     */
    backupRetentionPeriod?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-cacertificateidentifier
     */
    cACertificateIdentifier?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-charactersetname
     */
    characterSetName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-copytagstosnapshot
     */
    copyTagsToSnapshot?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbclusteridentifier
     */
    dBClusterIdentifier?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceclass
     */
    dBInstanceClass: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceidentifier
     */
    dBInstanceIdentifier?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbname
     */
    dBName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbparametergroupname
     */
    dBParameterGroupName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsecuritygroups
     */
    dBSecurityGroups?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsnapshotidentifier
     */
    dBSnapshotIdentifier?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsubnetgroupname
     */
    dBSubnetGroupName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deleteautomatedbackups
     */
    deleteAutomatedBackups?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deletionprotection
     */
    deletionProtection?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domain
     */
    domain?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domainiamrolename
     */
    domainIAMRoleName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enablecloudwatchlogsexports
     */
    enableCloudwatchLogsExports?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableiamdatabaseauthentication
     */
    enableIAMDatabaseAuthentication?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableperformanceinsights
     */
    enablePerformanceInsights?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engine
     */
    engine?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engineversion
     */
    engineVersion?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-iops
     */
    iops?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-kmskeyid
     */
    kmsKeyId?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-licensemodel
     */
    licenseModel?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masteruserpassword
     */
    masterUserPassword?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masterusername
     */
    masterUsername?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-maxallocatedstorage
     */
    maxAllocatedStorage?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringinterval
     */
    monitoringInterval?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringrolearn
     */
    monitoringRoleArn?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-multiaz
     */
    multiAZ?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-optiongroupname
     */
    optionGroupName?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightskmskeyid
     */
    performanceInsightsKMSKeyId?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightsretentionperiod
     */
    performanceInsightsRetentionPeriod?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-port
     */
    port?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredbackupwindow
     */
    preferredBackupWindow?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredmaintenancewindow
     */
    preferredMaintenanceWindow?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-processorfeatures
     */
    processorFeatures?: pulumi.Input<pulumi.Input<inputs.rds.DBInstanceProcessorFeatureArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-promotiontier
     */
    promotionTier?: pulumi.Input<number>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-publiclyaccessible
     */
    publiclyAccessible?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourcedbinstanceidentifier
     */
    sourceDBInstanceIdentifier?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourceregion
     */
    sourceRegion?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storageencrypted
     */
    storageEncrypted?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storagetype
     */
    storageType?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.TagArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-timezone
     */
    timezone?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-usedefaultprocessorfeatures
     */
    useDefaultProcessorFeatures?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-vpcsecuritygroups
     */
    vPCSecurityGroups?: pulumi.Input<pulumi.Input<string>[]>;
}