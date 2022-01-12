// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package athena

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Resource schema for AWS::Athena::PreparedStatement
type PreparedStatement struct {
	pulumi.CustomResourceState

	// The description of the prepared statement.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// The query string for the prepared statement.
	QueryStatement pulumi.StringOutput `pulumi:"queryStatement"`
	// The name of the prepared statement.
	StatementName pulumi.StringOutput `pulumi:"statementName"`
	// The name of the workgroup to which the prepared statement belongs.
	WorkGroup pulumi.StringOutput `pulumi:"workGroup"`
}

// NewPreparedStatement registers a new resource with the given unique name, arguments, and options.
func NewPreparedStatement(ctx *pulumi.Context,
	name string, args *PreparedStatementArgs, opts ...pulumi.ResourceOption) (*PreparedStatement, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.QueryStatement == nil {
		return nil, errors.New("invalid value for required argument 'QueryStatement'")
	}
	if args.StatementName == nil {
		return nil, errors.New("invalid value for required argument 'StatementName'")
	}
	if args.WorkGroup == nil {
		return nil, errors.New("invalid value for required argument 'WorkGroup'")
	}
	var resource PreparedStatement
	err := ctx.RegisterResource("aws-native:athena:PreparedStatement", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPreparedStatement gets an existing PreparedStatement resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPreparedStatement(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PreparedStatementState, opts ...pulumi.ResourceOption) (*PreparedStatement, error) {
	var resource PreparedStatement
	err := ctx.ReadResource("aws-native:athena:PreparedStatement", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PreparedStatement resources.
type preparedStatementState struct {
}

type PreparedStatementState struct {
}

func (PreparedStatementState) ElementType() reflect.Type {
	return reflect.TypeOf((*preparedStatementState)(nil)).Elem()
}

type preparedStatementArgs struct {
	// The description of the prepared statement.
	Description *string `pulumi:"description"`
	// The query string for the prepared statement.
	QueryStatement string `pulumi:"queryStatement"`
	// The name of the prepared statement.
	StatementName string `pulumi:"statementName"`
	// The name of the workgroup to which the prepared statement belongs.
	WorkGroup string `pulumi:"workGroup"`
}

// The set of arguments for constructing a PreparedStatement resource.
type PreparedStatementArgs struct {
	// The description of the prepared statement.
	Description pulumi.StringPtrInput
	// The query string for the prepared statement.
	QueryStatement pulumi.StringInput
	// The name of the prepared statement.
	StatementName pulumi.StringInput
	// The name of the workgroup to which the prepared statement belongs.
	WorkGroup pulumi.StringInput
}

func (PreparedStatementArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*preparedStatementArgs)(nil)).Elem()
}

type PreparedStatementInput interface {
	pulumi.Input

	ToPreparedStatementOutput() PreparedStatementOutput
	ToPreparedStatementOutputWithContext(ctx context.Context) PreparedStatementOutput
}

func (*PreparedStatement) ElementType() reflect.Type {
	return reflect.TypeOf((*PreparedStatement)(nil))
}

func (i *PreparedStatement) ToPreparedStatementOutput() PreparedStatementOutput {
	return i.ToPreparedStatementOutputWithContext(context.Background())
}

func (i *PreparedStatement) ToPreparedStatementOutputWithContext(ctx context.Context) PreparedStatementOutput {
	return pulumi.ToOutputWithContext(ctx, i).(PreparedStatementOutput)
}

type PreparedStatementOutput struct{ *pulumi.OutputState }

func (PreparedStatementOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*PreparedStatement)(nil))
}

func (o PreparedStatementOutput) ToPreparedStatementOutput() PreparedStatementOutput {
	return o
}

func (o PreparedStatementOutput) ToPreparedStatementOutputWithContext(ctx context.Context) PreparedStatementOutput {
	return o
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*PreparedStatementInput)(nil)).Elem(), &PreparedStatement{})
	pulumi.RegisterOutputType(PreparedStatementOutput{})
}
