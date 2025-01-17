# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *

__all__ = [
    'PublicRepositoryTag',
    'ReplicationConfiguration',
    'ReplicationConfigurationReplicationDestination',
    'ReplicationConfigurationReplicationRule',
    'ReplicationConfigurationRepositoryFilter',
    'RepositoryCatalogDataProperties',
    'RepositoryEncryptionConfiguration',
    'RepositoryImageScanningConfiguration',
    'RepositoryLifecyclePolicy',
    'RepositoryTag',
]

@pulumi.output_type
class PublicRepositoryTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")


@pulumi.output_type
class ReplicationConfiguration(dict):
    """
    An object representing the replication configuration for a registry.
    """
    def __init__(__self__, *,
                 rules: Sequence['outputs.ReplicationConfigurationReplicationRule']):
        """
        An object representing the replication configuration for a registry.
        :param Sequence['ReplicationConfigurationReplicationRule'] rules: An array of objects representing the replication rules for a replication configuration. A replication configuration may contain a maximum of 10 rules.
        """
        pulumi.set(__self__, "rules", rules)

    @property
    @pulumi.getter
    def rules(self) -> Sequence['outputs.ReplicationConfigurationReplicationRule']:
        """
        An array of objects representing the replication rules for a replication configuration. A replication configuration may contain a maximum of 10 rules.
        """
        return pulumi.get(self, "rules")


@pulumi.output_type
class ReplicationConfigurationReplicationDestination(dict):
    """
    An array of objects representing the details of a replication destination.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "registryId":
            suggest = "registry_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ReplicationConfigurationReplicationDestination. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ReplicationConfigurationReplicationDestination.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ReplicationConfigurationReplicationDestination.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 region: str,
                 registry_id: str):
        """
        An array of objects representing the details of a replication destination.
        """
        pulumi.set(__self__, "region", region)
        pulumi.set(__self__, "registry_id", registry_id)

    @property
    @pulumi.getter
    def region(self) -> str:
        return pulumi.get(self, "region")

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> str:
        return pulumi.get(self, "registry_id")


@pulumi.output_type
class ReplicationConfigurationReplicationRule(dict):
    """
    An array of objects representing the details of a replication destination.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "repositoryFilters":
            suggest = "repository_filters"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ReplicationConfigurationReplicationRule. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ReplicationConfigurationReplicationRule.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ReplicationConfigurationReplicationRule.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 destinations: Sequence['outputs.ReplicationConfigurationReplicationDestination'],
                 repository_filters: Optional[Sequence['outputs.ReplicationConfigurationRepositoryFilter']] = None):
        """
        An array of objects representing the details of a replication destination.
        :param Sequence['ReplicationConfigurationReplicationDestination'] destinations: An array of objects representing the details of a replication destination.
        :param Sequence['ReplicationConfigurationRepositoryFilter'] repository_filters: An array of objects representing the details of a repository filter.
        """
        pulumi.set(__self__, "destinations", destinations)
        if repository_filters is not None:
            pulumi.set(__self__, "repository_filters", repository_filters)

    @property
    @pulumi.getter
    def destinations(self) -> Sequence['outputs.ReplicationConfigurationReplicationDestination']:
        """
        An array of objects representing the details of a replication destination.
        """
        return pulumi.get(self, "destinations")

    @property
    @pulumi.getter(name="repositoryFilters")
    def repository_filters(self) -> Optional[Sequence['outputs.ReplicationConfigurationRepositoryFilter']]:
        """
        An array of objects representing the details of a repository filter.
        """
        return pulumi.get(self, "repository_filters")


@pulumi.output_type
class ReplicationConfigurationRepositoryFilter(dict):
    """
    An array of objects representing the details of a repository filter.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "filterType":
            suggest = "filter_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in ReplicationConfigurationRepositoryFilter. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        ReplicationConfigurationRepositoryFilter.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        ReplicationConfigurationRepositoryFilter.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 filter: str,
                 filter_type: 'ReplicationConfigurationFilterType'):
        """
        An array of objects representing the details of a repository filter.
        """
        pulumi.set(__self__, "filter", filter)
        pulumi.set(__self__, "filter_type", filter_type)

    @property
    @pulumi.getter
    def filter(self) -> str:
        return pulumi.get(self, "filter")

    @property
    @pulumi.getter(name="filterType")
    def filter_type(self) -> 'ReplicationConfigurationFilterType':
        return pulumi.get(self, "filter_type")


@pulumi.output_type
class RepositoryCatalogDataProperties(dict):
    """
    The CatalogData property type specifies Catalog data for ECR Public Repository. For information about Catalog Data, see <link>
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "aboutText":
            suggest = "about_text"
        elif key == "operatingSystems":
            suggest = "operating_systems"
        elif key == "repositoryDescription":
            suggest = "repository_description"
        elif key == "usageText":
            suggest = "usage_text"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RepositoryCatalogDataProperties. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RepositoryCatalogDataProperties.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RepositoryCatalogDataProperties.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 about_text: Optional[str] = None,
                 architectures: Optional[Sequence[str]] = None,
                 operating_systems: Optional[Sequence[str]] = None,
                 repository_description: Optional[str] = None,
                 usage_text: Optional[str] = None):
        """
        The CatalogData property type specifies Catalog data for ECR Public Repository. For information about Catalog Data, see <link>
        """
        if about_text is not None:
            pulumi.set(__self__, "about_text", about_text)
        if architectures is not None:
            pulumi.set(__self__, "architectures", architectures)
        if operating_systems is not None:
            pulumi.set(__self__, "operating_systems", operating_systems)
        if repository_description is not None:
            pulumi.set(__self__, "repository_description", repository_description)
        if usage_text is not None:
            pulumi.set(__self__, "usage_text", usage_text)

    @property
    @pulumi.getter(name="aboutText")
    def about_text(self) -> Optional[str]:
        return pulumi.get(self, "about_text")

    @property
    @pulumi.getter
    def architectures(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "architectures")

    @property
    @pulumi.getter(name="operatingSystems")
    def operating_systems(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "operating_systems")

    @property
    @pulumi.getter(name="repositoryDescription")
    def repository_description(self) -> Optional[str]:
        return pulumi.get(self, "repository_description")

    @property
    @pulumi.getter(name="usageText")
    def usage_text(self) -> Optional[str]:
        return pulumi.get(self, "usage_text")


@pulumi.output_type
class RepositoryEncryptionConfiguration(dict):
    """
    The encryption configuration for the repository. This determines how the contents of your repository are encrypted at rest.

    By default, when no encryption configuration is set or the AES256 encryption type is used, Amazon ECR uses server-side encryption with Amazon S3-managed encryption keys which encrypts your data at rest using an AES-256 encryption algorithm. This does not require any action on your part.

    For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/encryption-at-rest.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "encryptionType":
            suggest = "encryption_type"
        elif key == "kmsKey":
            suggest = "kms_key"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RepositoryEncryptionConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RepositoryEncryptionConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RepositoryEncryptionConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 encryption_type: 'RepositoryEncryptionType',
                 kms_key: Optional[str] = None):
        """
        The encryption configuration for the repository. This determines how the contents of your repository are encrypted at rest.

        By default, when no encryption configuration is set or the AES256 encryption type is used, Amazon ECR uses server-side encryption with Amazon S3-managed encryption keys which encrypts your data at rest using an AES-256 encryption algorithm. This does not require any action on your part.

        For more information, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/encryption-at-rest.html
        """
        pulumi.set(__self__, "encryption_type", encryption_type)
        if kms_key is not None:
            pulumi.set(__self__, "kms_key", kms_key)

    @property
    @pulumi.getter(name="encryptionType")
    def encryption_type(self) -> 'RepositoryEncryptionType':
        return pulumi.get(self, "encryption_type")

    @property
    @pulumi.getter(name="kmsKey")
    def kms_key(self) -> Optional[str]:
        return pulumi.get(self, "kms_key")


@pulumi.output_type
class RepositoryImageScanningConfiguration(dict):
    """
    The image scanning configuration for the repository. This setting determines whether images are scanned for known vulnerabilities after being pushed to the repository.
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "scanOnPush":
            suggest = "scan_on_push"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RepositoryImageScanningConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RepositoryImageScanningConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RepositoryImageScanningConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 scan_on_push: Optional[bool] = None):
        """
        The image scanning configuration for the repository. This setting determines whether images are scanned for known vulnerabilities after being pushed to the repository.
        """
        if scan_on_push is not None:
            pulumi.set(__self__, "scan_on_push", scan_on_push)

    @property
    @pulumi.getter(name="scanOnPush")
    def scan_on_push(self) -> Optional[bool]:
        return pulumi.get(self, "scan_on_push")


@pulumi.output_type
class RepositoryLifecyclePolicy(dict):
    """
    The LifecyclePolicy property type specifies a lifecycle policy. For information about lifecycle policy syntax, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html
    """
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "lifecyclePolicyText":
            suggest = "lifecycle_policy_text"
        elif key == "registryId":
            suggest = "registry_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in RepositoryLifecyclePolicy. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        RepositoryLifecyclePolicy.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        RepositoryLifecyclePolicy.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 lifecycle_policy_text: Optional[str] = None,
                 registry_id: Optional[str] = None):
        """
        The LifecyclePolicy property type specifies a lifecycle policy. For information about lifecycle policy syntax, see https://docs.aws.amazon.com/AmazonECR/latest/userguide/LifecyclePolicies.html
        """
        if lifecycle_policy_text is not None:
            pulumi.set(__self__, "lifecycle_policy_text", lifecycle_policy_text)
        if registry_id is not None:
            pulumi.set(__self__, "registry_id", registry_id)

    @property
    @pulumi.getter(name="lifecyclePolicyText")
    def lifecycle_policy_text(self) -> Optional[str]:
        return pulumi.get(self, "lifecycle_policy_text")

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> Optional[str]:
        return pulumi.get(self, "registry_id")


@pulumi.output_type
class RepositoryTag(dict):
    """
    A key-value pair to associate with a resource.
    """
    def __init__(__self__, *,
                 key: str,
                 value: str):
        """
        A key-value pair to associate with a resource.
        :param str key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param str value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")


