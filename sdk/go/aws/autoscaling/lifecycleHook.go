// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package autoscaling

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource Type definition for AWS::AutoScaling::LifecycleHook
type LifecycleHook struct {
	pulumi.CustomResourceState

	// The name of the Auto Scaling group for the lifecycle hook.
	AutoScalingGroupName pulumi.StringOutput `pulumi:"autoScalingGroupName"`
	// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected failure occurs. The valid values are CONTINUE and ABANDON (default).
	DefaultResult pulumi.StringPtrOutput `pulumi:"defaultResult"`
	// The maximum time, in seconds, that can elapse before the lifecycle hook times out. The range is from 30 to 7200 seconds. The default value is 3600 seconds (1 hour). If the lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that you specified in the DefaultResult property.
	HeartbeatTimeout pulumi.IntPtrOutput `pulumi:"heartbeatTimeout"`
	// The name of the lifecycle hook.
	LifecycleHookName pulumi.StringPtrOutput `pulumi:"lifecycleHookName"`
	// The instance state to which you want to attach the lifecycle hook.
	LifecycleTransition pulumi.StringOutput `pulumi:"lifecycleTransition"`
	// Additional information that is included any time Amazon EC2 Auto Scaling sends a message to the notification target.
	NotificationMetadata pulumi.StringPtrOutput `pulumi:"notificationMetadata"`
	// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to notify you when an instance is in the transition state for the lifecycle hook. You can specify an Amazon SQS queue or an Amazon SNS topic. The notification message includes the following information: lifecycle action token, user account ID, Auto Scaling group name, lifecycle hook name, instance ID, lifecycle transition, and notification metadata.
	NotificationTargetARN pulumi.StringPtrOutput `pulumi:"notificationTargetARN"`
	// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification target, for example, an Amazon SNS topic or an Amazon SQS queue.
	RoleARN pulumi.StringPtrOutput `pulumi:"roleARN"`
}

// NewLifecycleHook registers a new resource with the given unique name, arguments, and options.
func NewLifecycleHook(ctx *pulumi.Context,
	name string, args *LifecycleHookArgs, opts ...pulumi.ResourceOption) (*LifecycleHook, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.AutoScalingGroupName == nil {
		return nil, errors.New("invalid value for required argument 'AutoScalingGroupName'")
	}
	if args.LifecycleTransition == nil {
		return nil, errors.New("invalid value for required argument 'LifecycleTransition'")
	}
	var resource LifecycleHook
	err := ctx.RegisterResource("aws-native:autoscaling:LifecycleHook", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetLifecycleHook gets an existing LifecycleHook resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLifecycleHook(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *LifecycleHookState, opts ...pulumi.ResourceOption) (*LifecycleHook, error) {
	var resource LifecycleHook
	err := ctx.ReadResource("aws-native:autoscaling:LifecycleHook", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering LifecycleHook resources.
type lifecycleHookState struct {
}

type LifecycleHookState struct {
}

func (LifecycleHookState) ElementType() reflect.Type {
	return reflect.TypeOf((*lifecycleHookState)(nil)).Elem()
}

type lifecycleHookArgs struct {
	// The name of the Auto Scaling group for the lifecycle hook.
	AutoScalingGroupName string `pulumi:"autoScalingGroupName"`
	// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected failure occurs. The valid values are CONTINUE and ABANDON (default).
	DefaultResult *string `pulumi:"defaultResult"`
	// The maximum time, in seconds, that can elapse before the lifecycle hook times out. The range is from 30 to 7200 seconds. The default value is 3600 seconds (1 hour). If the lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that you specified in the DefaultResult property.
	HeartbeatTimeout *int `pulumi:"heartbeatTimeout"`
	// The name of the lifecycle hook.
	LifecycleHookName *string `pulumi:"lifecycleHookName"`
	// The instance state to which you want to attach the lifecycle hook.
	LifecycleTransition string `pulumi:"lifecycleTransition"`
	// Additional information that is included any time Amazon EC2 Auto Scaling sends a message to the notification target.
	NotificationMetadata *string `pulumi:"notificationMetadata"`
	// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to notify you when an instance is in the transition state for the lifecycle hook. You can specify an Amazon SQS queue or an Amazon SNS topic. The notification message includes the following information: lifecycle action token, user account ID, Auto Scaling group name, lifecycle hook name, instance ID, lifecycle transition, and notification metadata.
	NotificationTargetARN *string `pulumi:"notificationTargetARN"`
	// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification target, for example, an Amazon SNS topic or an Amazon SQS queue.
	RoleARN *string `pulumi:"roleARN"`
}

// The set of arguments for constructing a LifecycleHook resource.
type LifecycleHookArgs struct {
	// The name of the Auto Scaling group for the lifecycle hook.
	AutoScalingGroupName pulumi.StringInput
	// The action the Auto Scaling group takes when the lifecycle hook timeout elapses or if an unexpected failure occurs. The valid values are CONTINUE and ABANDON (default).
	DefaultResult pulumi.StringPtrInput
	// The maximum time, in seconds, that can elapse before the lifecycle hook times out. The range is from 30 to 7200 seconds. The default value is 3600 seconds (1 hour). If the lifecycle hook times out, Amazon EC2 Auto Scaling performs the action that you specified in the DefaultResult property.
	HeartbeatTimeout pulumi.IntPtrInput
	// The name of the lifecycle hook.
	LifecycleHookName pulumi.StringPtrInput
	// The instance state to which you want to attach the lifecycle hook.
	LifecycleTransition pulumi.StringInput
	// Additional information that is included any time Amazon EC2 Auto Scaling sends a message to the notification target.
	NotificationMetadata pulumi.StringPtrInput
	// The Amazon Resource Name (ARN) of the notification target that Amazon EC2 Auto Scaling uses to notify you when an instance is in the transition state for the lifecycle hook. You can specify an Amazon SQS queue or an Amazon SNS topic. The notification message includes the following information: lifecycle action token, user account ID, Auto Scaling group name, lifecycle hook name, instance ID, lifecycle transition, and notification metadata.
	NotificationTargetARN pulumi.StringPtrInput
	// The ARN of the IAM role that allows the Auto Scaling group to publish to the specified notification target, for example, an Amazon SNS topic or an Amazon SQS queue.
	RoleARN pulumi.StringPtrInput
}

func (LifecycleHookArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*lifecycleHookArgs)(nil)).Elem()
}

type LifecycleHookInput interface {
	pulumi.Input

	ToLifecycleHookOutput() LifecycleHookOutput
	ToLifecycleHookOutputWithContext(ctx context.Context) LifecycleHookOutput
}

func (*LifecycleHook) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecycleHook)(nil))
}

func (i *LifecycleHook) ToLifecycleHookOutput() LifecycleHookOutput {
	return i.ToLifecycleHookOutputWithContext(context.Background())
}

func (i *LifecycleHook) ToLifecycleHookOutputWithContext(ctx context.Context) LifecycleHookOutput {
	return pulumi.ToOutputWithContext(ctx, i).(LifecycleHookOutput)
}

type LifecycleHookOutput struct{ *pulumi.OutputState }

func (LifecycleHookOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LifecycleHook)(nil))
}

func (o LifecycleHookOutput) ToLifecycleHookOutput() LifecycleHookOutput {
	return o
}

func (o LifecycleHookOutput) ToLifecycleHookOutputWithContext(ctx context.Context) LifecycleHookOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*LifecycleHookInput)(nil)).Elem(), &LifecycleHook{})
	pulumi.RegisterOutputType(LifecycleHookOutput{})
}
