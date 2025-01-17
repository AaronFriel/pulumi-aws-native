// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AwsNative.ImageBuilder
{
    /// <summary>
    /// The platform of the component.
    /// </summary>
    [EnumType]
    public readonly struct ComponentPlatform : IEquatable<ComponentPlatform>
    {
        private readonly string _value;

        private ComponentPlatform(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ComponentPlatform Windows { get; } = new ComponentPlatform("Windows");
        public static ComponentPlatform Linux { get; } = new ComponentPlatform("Linux");

        public static bool operator ==(ComponentPlatform left, ComponentPlatform right) => left.Equals(right);
        public static bool operator !=(ComponentPlatform left, ComponentPlatform right) => !left.Equals(right);

        public static explicit operator string(ComponentPlatform value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ComponentPlatform other && Equals(other);
        public bool Equals(ComponentPlatform other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The type of the component denotes whether the component is used to build the image or only to test it. 
    /// </summary>
    [EnumType]
    public readonly struct ComponentType : IEquatable<ComponentType>
    {
        private readonly string _value;

        private ComponentType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ComponentType Build { get; } = new ComponentType("BUILD");
        public static ComponentType Test { get; } = new ComponentType("TEST");

        public static bool operator ==(ComponentType left, ComponentType right) => left.Equals(right);
        public static bool operator !=(ComponentType left, ComponentType right) => !left.Equals(right);

        public static explicit operator string(ComponentType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ComponentType other && Equals(other);
        public bool Equals(ComponentType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the type of container, such as Docker.
    /// </summary>
    [EnumType]
    public readonly struct ContainerRecipeContainerType : IEquatable<ContainerRecipeContainerType>
    {
        private readonly string _value;

        private ContainerRecipeContainerType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ContainerRecipeContainerType Docker { get; } = new ContainerRecipeContainerType("DOCKER");

        public static bool operator ==(ContainerRecipeContainerType left, ContainerRecipeContainerType right) => left.Equals(right);
        public static bool operator !=(ContainerRecipeContainerType left, ContainerRecipeContainerType right) => !left.Equals(right);

        public static explicit operator string(ContainerRecipeContainerType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerRecipeContainerType other && Equals(other);
        public bool Equals(ContainerRecipeContainerType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Use to override the device's volume type.
    /// </summary>
    [EnumType]
    public readonly struct ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType : IEquatable<ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType>
    {
        private readonly string _value;

        private ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Standard { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("standard");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Io1 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("io1");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Io2 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("io2");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Gp2 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("gp2");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Gp3 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("gp3");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType Sc1 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("sc1");
        public static ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType St1 { get; } = new ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType("st1");

        public static bool operator ==(ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType left, ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType right) => left.Equals(right);
        public static bool operator !=(ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType left, ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType right) => !left.Equals(right);

        public static explicit operator string(ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType other && Equals(other);
        public bool Equals(ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the operating system platform when you use a custom source image.
    /// </summary>
    [EnumType]
    public readonly struct ContainerRecipePlatformOverride : IEquatable<ContainerRecipePlatformOverride>
    {
        private readonly string _value;

        private ContainerRecipePlatformOverride(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ContainerRecipePlatformOverride Windows { get; } = new ContainerRecipePlatformOverride("Windows");
        public static ContainerRecipePlatformOverride Linux { get; } = new ContainerRecipePlatformOverride("Linux");

        public static bool operator ==(ContainerRecipePlatformOverride left, ContainerRecipePlatformOverride right) => left.Equals(right);
        public static bool operator !=(ContainerRecipePlatformOverride left, ContainerRecipePlatformOverride right) => !left.Equals(right);

        public static explicit operator string(ContainerRecipePlatformOverride value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerRecipePlatformOverride other && Equals(other);
        public bool Equals(ContainerRecipePlatformOverride other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Specifies the service in which this image was registered.
    /// </summary>
    [EnumType]
    public readonly struct ContainerRecipeTargetContainerRepositoryService : IEquatable<ContainerRecipeTargetContainerRepositoryService>
    {
        private readonly string _value;

        private ContainerRecipeTargetContainerRepositoryService(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ContainerRecipeTargetContainerRepositoryService Ecr { get; } = new ContainerRecipeTargetContainerRepositoryService("ECR");

        public static bool operator ==(ContainerRecipeTargetContainerRepositoryService left, ContainerRecipeTargetContainerRepositoryService right) => left.Equals(right);
        public static bool operator !=(ContainerRecipeTargetContainerRepositoryService left, ContainerRecipeTargetContainerRepositoryService right) => !left.Equals(right);

        public static explicit operator string(ContainerRecipeTargetContainerRepositoryService value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ContainerRecipeTargetContainerRepositoryService other && Equals(other);
        public bool Equals(ContainerRecipeTargetContainerRepositoryService other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The service of target container repository.
    /// </summary>
    [EnumType]
    public readonly struct DistributionConfigurationTargetContainerRepositoryService : IEquatable<DistributionConfigurationTargetContainerRepositoryService>
    {
        private readonly string _value;

        private DistributionConfigurationTargetContainerRepositoryService(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static DistributionConfigurationTargetContainerRepositoryService Ecr { get; } = new DistributionConfigurationTargetContainerRepositoryService("ECR");

        public static bool operator ==(DistributionConfigurationTargetContainerRepositoryService left, DistributionConfigurationTargetContainerRepositoryService right) => left.Equals(right);
        public static bool operator !=(DistributionConfigurationTargetContainerRepositoryService left, DistributionConfigurationTargetContainerRepositoryService right) => !left.Equals(right);

        public static explicit operator string(DistributionConfigurationTargetContainerRepositoryService value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is DistributionConfigurationTargetContainerRepositoryService other && Equals(other);
        public bool Equals(DistributionConfigurationTargetContainerRepositoryService other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The condition configures when the pipeline should trigger a new image build.
    /// </summary>
    [EnumType]
    public readonly struct ImagePipelineSchedulePipelineExecutionStartCondition : IEquatable<ImagePipelineSchedulePipelineExecutionStartCondition>
    {
        private readonly string _value;

        private ImagePipelineSchedulePipelineExecutionStartCondition(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ImagePipelineSchedulePipelineExecutionStartCondition ExpressionMatchOnly { get; } = new ImagePipelineSchedulePipelineExecutionStartCondition("EXPRESSION_MATCH_ONLY");
        public static ImagePipelineSchedulePipelineExecutionStartCondition ExpressionMatchAndDependencyUpdatesAvailable { get; } = new ImagePipelineSchedulePipelineExecutionStartCondition("EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE");

        public static bool operator ==(ImagePipelineSchedulePipelineExecutionStartCondition left, ImagePipelineSchedulePipelineExecutionStartCondition right) => left.Equals(right);
        public static bool operator !=(ImagePipelineSchedulePipelineExecutionStartCondition left, ImagePipelineSchedulePipelineExecutionStartCondition right) => !left.Equals(right);

        public static explicit operator string(ImagePipelineSchedulePipelineExecutionStartCondition value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ImagePipelineSchedulePipelineExecutionStartCondition other && Equals(other);
        public bool Equals(ImagePipelineSchedulePipelineExecutionStartCondition other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// The status of the image pipeline.
    /// </summary>
    [EnumType]
    public readonly struct ImagePipelineStatus : IEquatable<ImagePipelineStatus>
    {
        private readonly string _value;

        private ImagePipelineStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ImagePipelineStatus Disabled { get; } = new ImagePipelineStatus("DISABLED");
        public static ImagePipelineStatus Enabled { get; } = new ImagePipelineStatus("ENABLED");

        public static bool operator ==(ImagePipelineStatus left, ImagePipelineStatus right) => left.Equals(right);
        public static bool operator !=(ImagePipelineStatus left, ImagePipelineStatus right) => !left.Equals(right);

        public static explicit operator string(ImagePipelineStatus value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ImagePipelineStatus other && Equals(other);
        public bool Equals(ImagePipelineStatus other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Use to override the device's volume type.
    /// </summary>
    [EnumType]
    public readonly struct ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType : IEquatable<ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType>
    {
        private readonly string _value;

        private ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Standard { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("standard");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Io1 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("io1");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Io2 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("io2");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Gp2 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("gp2");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Gp3 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("gp3");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType Sc1 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("sc1");
        public static ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType St1 { get; } = new ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType("st1");

        public static bool operator ==(ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType left, ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType right) => left.Equals(right);
        public static bool operator !=(ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType left, ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType right) => !left.Equals(right);

        public static explicit operator string(ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType other && Equals(other);
        public bool Equals(ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Indicates whether a signed token header is required for instance metadata retrieval requests. The values affect the response as follows: 
    /// </summary>
    [EnumType]
    public readonly struct InfrastructureConfigurationInstanceMetadataOptionsHttpTokens : IEquatable<InfrastructureConfigurationInstanceMetadataOptionsHttpTokens>
    {
        private readonly string _value;

        private InfrastructureConfigurationInstanceMetadataOptionsHttpTokens(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static InfrastructureConfigurationInstanceMetadataOptionsHttpTokens Required { get; } = new InfrastructureConfigurationInstanceMetadataOptionsHttpTokens("required");
        public static InfrastructureConfigurationInstanceMetadataOptionsHttpTokens Optional { get; } = new InfrastructureConfigurationInstanceMetadataOptionsHttpTokens("optional");

        public static bool operator ==(InfrastructureConfigurationInstanceMetadataOptionsHttpTokens left, InfrastructureConfigurationInstanceMetadataOptionsHttpTokens right) => left.Equals(right);
        public static bool operator !=(InfrastructureConfigurationInstanceMetadataOptionsHttpTokens left, InfrastructureConfigurationInstanceMetadataOptionsHttpTokens right) => !left.Equals(right);

        public static explicit operator string(InfrastructureConfigurationInstanceMetadataOptionsHttpTokens value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is InfrastructureConfigurationInstanceMetadataOptionsHttpTokens other && Equals(other);
        public bool Equals(InfrastructureConfigurationInstanceMetadataOptionsHttpTokens other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
