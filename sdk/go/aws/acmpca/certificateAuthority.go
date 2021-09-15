// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package acmpca

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Private certificate authority.
type CertificateAuthority struct {
	pulumi.CustomResourceState

	// The Amazon Resource Name (ARN) of the certificate authority.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The base64 PEM-encoded certificate signing request (CSR) for your certificate authority certificate.
	CertificateSigningRequest pulumi.StringOutput `pulumi:"certificateSigningRequest"`
	// Structure that contains CSR pass through extension information used by the CreateCertificateAuthority action.
	CsrExtensions CertificateAuthorityCsrExtensionsPtrOutput `pulumi:"csrExtensions"`
	// Public key algorithm and size, in bits, of the key pair that your CA creates when it issues a certificate.
	KeyAlgorithm pulumi.StringOutput `pulumi:"keyAlgorithm"`
	// KeyStorageSecurityStadard defines a cryptographic key management compliance standard used for handling CA keys.
	KeyStorageSecurityStandard pulumi.StringPtrOutput `pulumi:"keyStorageSecurityStandard"`
	// Certificate revocation information used by the CreateCertificateAuthority and UpdateCertificateAuthority actions.
	RevocationConfiguration CertificateAuthorityRevocationConfigurationPtrOutput `pulumi:"revocationConfiguration"`
	// Algorithm your CA uses to sign certificate requests.
	SigningAlgorithm pulumi.StringOutput `pulumi:"signingAlgorithm"`
	// Structure that contains X.500 distinguished name information for your CA.
	Subject CertificateAuthoritySubjectOutput  `pulumi:"subject"`
	Tags    CertificateAuthorityTagArrayOutput `pulumi:"tags"`
	// The type of the certificate authority.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewCertificateAuthority registers a new resource with the given unique name, arguments, and options.
func NewCertificateAuthority(ctx *pulumi.Context,
	name string, args *CertificateAuthorityArgs, opts ...pulumi.ResourceOption) (*CertificateAuthority, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.KeyAlgorithm == nil {
		return nil, errors.New("invalid value for required argument 'KeyAlgorithm'")
	}
	if args.SigningAlgorithm == nil {
		return nil, errors.New("invalid value for required argument 'SigningAlgorithm'")
	}
	if args.Subject == nil {
		return nil, errors.New("invalid value for required argument 'Subject'")
	}
	if args.Type == nil {
		return nil, errors.New("invalid value for required argument 'Type'")
	}
	var resource CertificateAuthority
	err := ctx.RegisterResource("aws-native:acmpca:CertificateAuthority", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCertificateAuthority gets an existing CertificateAuthority resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCertificateAuthority(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CertificateAuthorityState, opts ...pulumi.ResourceOption) (*CertificateAuthority, error) {
	var resource CertificateAuthority
	err := ctx.ReadResource("aws-native:acmpca:CertificateAuthority", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CertificateAuthority resources.
type certificateAuthorityState struct {
}

type CertificateAuthorityState struct {
}

func (CertificateAuthorityState) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateAuthorityState)(nil)).Elem()
}

type certificateAuthorityArgs struct {
	// Structure that contains CSR pass through extension information used by the CreateCertificateAuthority action.
	CsrExtensions *CertificateAuthorityCsrExtensions `pulumi:"csrExtensions"`
	// Public key algorithm and size, in bits, of the key pair that your CA creates when it issues a certificate.
	KeyAlgorithm string `pulumi:"keyAlgorithm"`
	// KeyStorageSecurityStadard defines a cryptographic key management compliance standard used for handling CA keys.
	KeyStorageSecurityStandard *string `pulumi:"keyStorageSecurityStandard"`
	// Certificate revocation information used by the CreateCertificateAuthority and UpdateCertificateAuthority actions.
	RevocationConfiguration *CertificateAuthorityRevocationConfiguration `pulumi:"revocationConfiguration"`
	// Algorithm your CA uses to sign certificate requests.
	SigningAlgorithm string `pulumi:"signingAlgorithm"`
	// Structure that contains X.500 distinguished name information for your CA.
	Subject CertificateAuthoritySubject `pulumi:"subject"`
	Tags    []CertificateAuthorityTag   `pulumi:"tags"`
	// The type of the certificate authority.
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a CertificateAuthority resource.
type CertificateAuthorityArgs struct {
	// Structure that contains CSR pass through extension information used by the CreateCertificateAuthority action.
	CsrExtensions CertificateAuthorityCsrExtensionsPtrInput
	// Public key algorithm and size, in bits, of the key pair that your CA creates when it issues a certificate.
	KeyAlgorithm pulumi.StringInput
	// KeyStorageSecurityStadard defines a cryptographic key management compliance standard used for handling CA keys.
	KeyStorageSecurityStandard pulumi.StringPtrInput
	// Certificate revocation information used by the CreateCertificateAuthority and UpdateCertificateAuthority actions.
	RevocationConfiguration CertificateAuthorityRevocationConfigurationPtrInput
	// Algorithm your CA uses to sign certificate requests.
	SigningAlgorithm pulumi.StringInput
	// Structure that contains X.500 distinguished name information for your CA.
	Subject CertificateAuthoritySubjectInput
	Tags    CertificateAuthorityTagArrayInput
	// The type of the certificate authority.
	Type pulumi.StringInput
}

func (CertificateAuthorityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*certificateAuthorityArgs)(nil)).Elem()
}

type CertificateAuthorityInput interface {
	pulumi.Input

	ToCertificateAuthorityOutput() CertificateAuthorityOutput
	ToCertificateAuthorityOutputWithContext(ctx context.Context) CertificateAuthorityOutput
}

func (*CertificateAuthority) ElementType() reflect.Type {
	return reflect.TypeOf((*CertificateAuthority)(nil))
}

func (i *CertificateAuthority) ToCertificateAuthorityOutput() CertificateAuthorityOutput {
	return i.ToCertificateAuthorityOutputWithContext(context.Background())
}

func (i *CertificateAuthority) ToCertificateAuthorityOutputWithContext(ctx context.Context) CertificateAuthorityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(CertificateAuthorityOutput)
}

type CertificateAuthorityOutput struct{ *pulumi.OutputState }

func (CertificateAuthorityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*CertificateAuthority)(nil))
}

func (o CertificateAuthorityOutput) ToCertificateAuthorityOutput() CertificateAuthorityOutput {
	return o
}

func (o CertificateAuthorityOutput) ToCertificateAuthorityOutputWithContext(ctx context.Context) CertificateAuthorityOutput {
	return o
}

func init() {
	pulumi.RegisterOutputType(CertificateAuthorityOutput{})
}
