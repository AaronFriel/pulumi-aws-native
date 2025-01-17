// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package amazonmq

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AmazonMQ::Broker
//
// Deprecated: Broker is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
type Broker struct {
	pulumi.CustomResourceState

	AmqpEndpoints              pulumi.StringArrayOutput          `pulumi:"amqpEndpoints"`
	Arn                        pulumi.StringOutput               `pulumi:"arn"`
	AuthenticationStrategy     pulumi.StringPtrOutput            `pulumi:"authenticationStrategy"`
	AutoMinorVersionUpgrade    pulumi.BoolOutput                 `pulumi:"autoMinorVersionUpgrade"`
	BrokerName                 pulumi.StringOutput               `pulumi:"brokerName"`
	Configuration              BrokerConfigurationIdPtrOutput    `pulumi:"configuration"`
	ConfigurationId            pulumi.StringOutput               `pulumi:"configurationId"`
	ConfigurationRevision      pulumi.IntOutput                  `pulumi:"configurationRevision"`
	DeploymentMode             pulumi.StringOutput               `pulumi:"deploymentMode"`
	EncryptionOptions          BrokerEncryptionOptionsPtrOutput  `pulumi:"encryptionOptions"`
	EngineType                 pulumi.StringOutput               `pulumi:"engineType"`
	EngineVersion              pulumi.StringOutput               `pulumi:"engineVersion"`
	HostInstanceType           pulumi.StringOutput               `pulumi:"hostInstanceType"`
	IpAddresses                pulumi.StringArrayOutput          `pulumi:"ipAddresses"`
	LdapServerMetadata         BrokerLdapServerMetadataPtrOutput `pulumi:"ldapServerMetadata"`
	Logs                       BrokerLogListPtrOutput            `pulumi:"logs"`
	MaintenanceWindowStartTime BrokerMaintenanceWindowPtrOutput  `pulumi:"maintenanceWindowStartTime"`
	MqttEndpoints              pulumi.StringArrayOutput          `pulumi:"mqttEndpoints"`
	OpenWireEndpoints          pulumi.StringArrayOutput          `pulumi:"openWireEndpoints"`
	PubliclyAccessible         pulumi.BoolOutput                 `pulumi:"publiclyAccessible"`
	SecurityGroups             pulumi.StringArrayOutput          `pulumi:"securityGroups"`
	StompEndpoints             pulumi.StringArrayOutput          `pulumi:"stompEndpoints"`
	StorageType                pulumi.StringPtrOutput            `pulumi:"storageType"`
	SubnetIds                  pulumi.StringArrayOutput          `pulumi:"subnetIds"`
	Tags                       BrokerTagsEntryArrayOutput        `pulumi:"tags"`
	Users                      BrokerUserArrayOutput             `pulumi:"users"`
	WssEndpoints               pulumi.StringArrayOutput          `pulumi:"wssEndpoints"`
}

// NewBroker registers a new resource with the given unique name, arguments, and options.
func NewBroker(ctx *pulumi.Context,
	name string, args *BrokerArgs, opts ...pulumi.ResourceOption) (*Broker, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoMinorVersionUpgrade == nil {
		return nil, errors.New("invalid value for required argument 'AutoMinorVersionUpgrade'")
	}
	if args.DeploymentMode == nil {
		return nil, errors.New("invalid value for required argument 'DeploymentMode'")
	}
	if args.EngineType == nil {
		return nil, errors.New("invalid value for required argument 'EngineType'")
	}
	if args.EngineVersion == nil {
		return nil, errors.New("invalid value for required argument 'EngineVersion'")
	}
	if args.HostInstanceType == nil {
		return nil, errors.New("invalid value for required argument 'HostInstanceType'")
	}
	if args.PubliclyAccessible == nil {
		return nil, errors.New("invalid value for required argument 'PubliclyAccessible'")
	}
	if args.Users == nil {
		return nil, errors.New("invalid value for required argument 'Users'")
	}
	var resource Broker
	err := ctx.RegisterResource("aws-native:amazonmq:Broker", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetBroker gets an existing Broker resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetBroker(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *BrokerState, opts ...pulumi.ResourceOption) (*Broker, error) {
	var resource Broker
	err := ctx.ReadResource("aws-native:amazonmq:Broker", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Broker resources.
type brokerState struct {
}

type BrokerState struct {
}

func (BrokerState) ElementType() reflect.Type {
	return reflect.TypeOf((*brokerState)(nil)).Elem()
}

type brokerArgs struct {
	AuthenticationStrategy     *string                   `pulumi:"authenticationStrategy"`
	AutoMinorVersionUpgrade    bool                      `pulumi:"autoMinorVersionUpgrade"`
	BrokerName                 *string                   `pulumi:"brokerName"`
	Configuration              *BrokerConfigurationId    `pulumi:"configuration"`
	DeploymentMode             string                    `pulumi:"deploymentMode"`
	EncryptionOptions          *BrokerEncryptionOptions  `pulumi:"encryptionOptions"`
	EngineType                 string                    `pulumi:"engineType"`
	EngineVersion              string                    `pulumi:"engineVersion"`
	HostInstanceType           string                    `pulumi:"hostInstanceType"`
	LdapServerMetadata         *BrokerLdapServerMetadata `pulumi:"ldapServerMetadata"`
	Logs                       *BrokerLogList            `pulumi:"logs"`
	MaintenanceWindowStartTime *BrokerMaintenanceWindow  `pulumi:"maintenanceWindowStartTime"`
	PubliclyAccessible         bool                      `pulumi:"publiclyAccessible"`
	SecurityGroups             []string                  `pulumi:"securityGroups"`
	StorageType                *string                   `pulumi:"storageType"`
	SubnetIds                  []string                  `pulumi:"subnetIds"`
	Tags                       []BrokerTagsEntry         `pulumi:"tags"`
	Users                      []BrokerUser              `pulumi:"users"`
}

// The set of arguments for constructing a Broker resource.
type BrokerArgs struct {
	AuthenticationStrategy     pulumi.StringPtrInput
	AutoMinorVersionUpgrade    pulumi.BoolInput
	BrokerName                 pulumi.StringPtrInput
	Configuration              BrokerConfigurationIdPtrInput
	DeploymentMode             pulumi.StringInput
	EncryptionOptions          BrokerEncryptionOptionsPtrInput
	EngineType                 pulumi.StringInput
	EngineVersion              pulumi.StringInput
	HostInstanceType           pulumi.StringInput
	LdapServerMetadata         BrokerLdapServerMetadataPtrInput
	Logs                       BrokerLogListPtrInput
	MaintenanceWindowStartTime BrokerMaintenanceWindowPtrInput
	PubliclyAccessible         pulumi.BoolInput
	SecurityGroups             pulumi.StringArrayInput
	StorageType                pulumi.StringPtrInput
	SubnetIds                  pulumi.StringArrayInput
	Tags                       BrokerTagsEntryArrayInput
	Users                      BrokerUserArrayInput
}

func (BrokerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*brokerArgs)(nil)).Elem()
}

type BrokerInput interface {
	pulumi.Input

	ToBrokerOutput() BrokerOutput
	ToBrokerOutputWithContext(ctx context.Context) BrokerOutput
}

func (*Broker) ElementType() reflect.Type {
	return reflect.TypeOf((*Broker)(nil))
}

func (i *Broker) ToBrokerOutput() BrokerOutput {
	return i.ToBrokerOutputWithContext(context.Background())
}

func (i *Broker) ToBrokerOutputWithContext(ctx context.Context) BrokerOutput {
	return pulumi.ToOutputWithContext(ctx, i).(BrokerOutput)
}

type BrokerOutput struct{ *pulumi.OutputState }

func (BrokerOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Broker)(nil))
}

func (o BrokerOutput) ToBrokerOutput() BrokerOutput {
	return o
}

func (o BrokerOutput) ToBrokerOutputWithContext(ctx context.Context) BrokerOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*BrokerInput)(nil)).Elem(), &Broker{})
	pulumi.RegisterOutputType(BrokerOutput{})
}
