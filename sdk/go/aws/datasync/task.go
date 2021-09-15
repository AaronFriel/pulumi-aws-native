// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datasync

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::DataSync::Task.
type Task struct {
	pulumi.CustomResourceState

	// The ARN of the Amazon CloudWatch log group that is used to monitor and log events in the task.
	CloudWatchLogGroupArn pulumi.StringPtrOutput `pulumi:"cloudWatchLogGroupArn"`
	// The ARN of an AWS storage resource's location.
	DestinationLocationArn          pulumi.StringOutput      `pulumi:"destinationLocationArn"`
	DestinationNetworkInterfaceArns pulumi.StringArrayOutput `pulumi:"destinationNetworkInterfaceArns"`
	// Errors that AWS DataSync encountered during execution of the task. You can use this error code to help troubleshoot issues.
	ErrorCode pulumi.StringOutput `pulumi:"errorCode"`
	// Detailed description of an error that was encountered during the task execution.
	ErrorDetail pulumi.StringOutput       `pulumi:"errorDetail"`
	Excludes    TaskFilterRuleArrayOutput `pulumi:"excludes"`
	Includes    TaskFilterRuleArrayOutput `pulumi:"includes"`
	// The name of a task. This value is a text reference that is used to identify the task in the console.
	Name     pulumi.StringPtrOutput    `pulumi:"name"`
	Options  TaskOptionsPtrOutput      `pulumi:"options"`
	Schedule TaskTaskSchedulePtrOutput `pulumi:"schedule"`
	// The ARN of the source location for the task.
	SourceLocationArn          pulumi.StringOutput      `pulumi:"sourceLocationArn"`
	SourceNetworkInterfaceArns pulumi.StringArrayOutput `pulumi:"sourceNetworkInterfaceArns"`
	// The status of the task that was described.
	Status pulumi.StringOutput `pulumi:"status"`
	// An array of key-value pairs to apply to this resource.
	Tags TaskTagArrayOutput `pulumi:"tags"`
	// The ARN of the task.
	TaskArn pulumi.StringOutput `pulumi:"taskArn"`
}

// NewTask registers a new resource with the given unique name, arguments, and options.
func NewTask(ctx *pulumi.Context,
	name string, args *TaskArgs, opts ...pulumi.ResourceOption) (*Task, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.DestinationLocationArn == nil {
		return nil, errors.New("invalid value for required argument 'DestinationLocationArn'")
	}
	if args.SourceLocationArn == nil {
		return nil, errors.New("invalid value for required argument 'SourceLocationArn'")
	}
	var resource Task
	err := ctx.RegisterResource("aws-native:datasync:Task", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTask gets an existing Task resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTask(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TaskState, opts ...pulumi.ResourceOption) (*Task, error) {
	var resource Task
	err := ctx.ReadResource("aws-native:datasync:Task", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Task resources.
type taskState struct {
}

type TaskState struct {
}

func (TaskState) ElementType() reflect.Type {
	return reflect.TypeOf((*taskState)(nil)).Elem()
}

type taskArgs struct {
	// The ARN of the Amazon CloudWatch log group that is used to monitor and log events in the task.
	CloudWatchLogGroupArn *string `pulumi:"cloudWatchLogGroupArn"`
	// The ARN of an AWS storage resource's location.
	DestinationLocationArn string           `pulumi:"destinationLocationArn"`
	Excludes               []TaskFilterRule `pulumi:"excludes"`
	Includes               []TaskFilterRule `pulumi:"includes"`
	// The name of a task. This value is a text reference that is used to identify the task in the console.
	Name     *string           `pulumi:"name"`
	Options  *TaskOptions      `pulumi:"options"`
	Schedule *TaskTaskSchedule `pulumi:"schedule"`
	// The ARN of the source location for the task.
	SourceLocationArn string `pulumi:"sourceLocationArn"`
	// An array of key-value pairs to apply to this resource.
	Tags []TaskTag `pulumi:"tags"`
}

// The set of arguments for constructing a Task resource.
type TaskArgs struct {
	// The ARN of the Amazon CloudWatch log group that is used to monitor and log events in the task.
	CloudWatchLogGroupArn pulumi.StringPtrInput
	// The ARN of an AWS storage resource's location.
	DestinationLocationArn pulumi.StringInput
	Excludes               TaskFilterRuleArrayInput
	Includes               TaskFilterRuleArrayInput
	// The name of a task. This value is a text reference that is used to identify the task in the console.
	Name     pulumi.StringPtrInput
	Options  TaskOptionsPtrInput
	Schedule TaskTaskSchedulePtrInput
	// The ARN of the source location for the task.
	SourceLocationArn pulumi.StringInput
	// An array of key-value pairs to apply to this resource.
	Tags TaskTagArrayInput
}

func (TaskArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*taskArgs)(nil)).Elem()
}

type TaskInput interface {
	pulumi.Input

	ToTaskOutput() TaskOutput
	ToTaskOutputWithContext(ctx context.Context) TaskOutput
}

func (*Task) ElementType() reflect.Type {
	return reflect.TypeOf((*Task)(nil))
}

func (i *Task) ToTaskOutput() TaskOutput {
	return i.ToTaskOutputWithContext(context.Background())
}

func (i *Task) ToTaskOutputWithContext(ctx context.Context) TaskOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TaskOutput)
}

type TaskOutput struct{ *pulumi.OutputState }

func (TaskOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*Task)(nil))
}

func (o TaskOutput) ToTaskOutput() TaskOutput {
	return o
}

func (o TaskOutput) ToTaskOutputWithContext(ctx context.Context) TaskOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(TaskOutput{})
}
