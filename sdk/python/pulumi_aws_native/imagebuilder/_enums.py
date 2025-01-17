# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ComponentPlatform',
    'ComponentType',
    'ContainerRecipeContainerType',
    'ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType',
    'ContainerRecipePlatformOverride',
    'ContainerRecipeTargetContainerRepositoryService',
    'DistributionConfigurationTargetContainerRepositoryService',
    'ImagePipelineSchedulePipelineExecutionStartCondition',
    'ImagePipelineStatus',
    'ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType',
    'InfrastructureConfigurationInstanceMetadataOptionsHttpTokens',
]


class ComponentPlatform(str, Enum):
    """
    The platform of the component.
    """
    WINDOWS = "Windows"
    LINUX = "Linux"


class ComponentType(str, Enum):
    """
    The type of the component denotes whether the component is used to build the image or only to test it. 
    """
    BUILD = "BUILD"
    TEST = "TEST"


class ContainerRecipeContainerType(str, Enum):
    """
    Specifies the type of container, such as Docker.
    """
    DOCKER = "DOCKER"


class ContainerRecipeEbsInstanceBlockDeviceSpecificationVolumeType(str, Enum):
    """
    Use to override the device's volume type.
    """
    STANDARD = "standard"
    IO1 = "io1"
    IO2 = "io2"
    GP2 = "gp2"
    GP3 = "gp3"
    SC1 = "sc1"
    ST1 = "st1"


class ContainerRecipePlatformOverride(str, Enum):
    """
    Specifies the operating system platform when you use a custom source image.
    """
    WINDOWS = "Windows"
    LINUX = "Linux"


class ContainerRecipeTargetContainerRepositoryService(str, Enum):
    """
    Specifies the service in which this image was registered.
    """
    ECR = "ECR"


class DistributionConfigurationTargetContainerRepositoryService(str, Enum):
    """
    The service of target container repository.
    """
    ECR = "ECR"


class ImagePipelineSchedulePipelineExecutionStartCondition(str, Enum):
    """
    The condition configures when the pipeline should trigger a new image build.
    """
    EXPRESSION_MATCH_ONLY = "EXPRESSION_MATCH_ONLY"
    EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE = "EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE"


class ImagePipelineStatus(str, Enum):
    """
    The status of the image pipeline.
    """
    DISABLED = "DISABLED"
    ENABLED = "ENABLED"


class ImageRecipeEbsInstanceBlockDeviceSpecificationVolumeType(str, Enum):
    """
    Use to override the device's volume type.
    """
    STANDARD = "standard"
    IO1 = "io1"
    IO2 = "io2"
    GP2 = "gp2"
    GP3 = "gp3"
    SC1 = "sc1"
    ST1 = "st1"


class InfrastructureConfigurationInstanceMetadataOptionsHttpTokens(str, Enum):
    """
    Indicates whether a signed token header is required for instance metadata retrieval requests. The values affect the response as follows: 
    """
    REQUIRED = "required"
    OPTIONAL = "optional"
