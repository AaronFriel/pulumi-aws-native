# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AccessPointNetworkOrigin',
    'AccessPointPolicyStatusPropertiesIsPublic',
    'BucketAccelerateConfigurationAccelerationStatus',
    'BucketAccessControl',
    'BucketCorsRuleAllowedMethodsItem',
    'BucketDefaultRetentionMode',
    'BucketDeleteMarkerReplicationStatus',
    'BucketDestinationFormat',
    'BucketIntelligentTieringConfigurationStatus',
    'BucketInventoryConfigurationIncludedObjectVersions',
    'BucketInventoryConfigurationOptionalFieldsItem',
    'BucketInventoryConfigurationScheduleFrequency',
    'BucketMetricsStatus',
    'BucketNoncurrentVersionTransitionStorageClass',
    'BucketOwnershipControlsRuleObjectOwnership',
    'BucketRedirectAllRequestsToProtocol',
    'BucketRedirectRuleProtocol',
    'BucketReplicaModificationsStatus',
    'BucketReplicationDestinationStorageClass',
    'BucketReplicationRuleStatus',
    'BucketReplicationTimeStatus',
    'BucketRuleStatus',
    'BucketServerSideEncryptionByDefaultSSEAlgorithm',
    'BucketSseKmsEncryptedObjectsStatus',
    'BucketTieringAccessTier',
    'BucketTransitionStorageClass',
    'BucketVersioningConfigurationStatus',
    'MultiRegionAccessPointPolicyPolicyStatusPropertiesIsPublic',
    'StorageLensS3BucketDestinationFormat',
    'StorageLensS3BucketDestinationOutputSchemaVersion',
]


class AccessPointNetworkOrigin(str, Enum):
    """
    Indicates whether this Access Point allows access from the public Internet. If VpcConfiguration is specified for this Access Point, then NetworkOrigin is VPC, and the Access Point doesn't allow access from the public Internet. Otherwise, NetworkOrigin is Internet, and the Access Point allows access from the public Internet, subject to the Access Point and bucket access policies.
    """
    INTERNET = "Internet"
    VPC = "VPC"


class AccessPointPolicyStatusPropertiesIsPublic(str, Enum):
    """
    Specifies whether the policy is public or not.
    """
    TRUE = "true"
    FALSE = "false"


class BucketAccelerateConfigurationAccelerationStatus(str, Enum):
    """
    Configures the transfer acceleration state for an Amazon S3 bucket.
    """
    ENABLED = "Enabled"
    SUSPENDED = "Suspended"


class BucketAccessControl(str, Enum):
    """
    A canned access control list (ACL) that grants predefined permissions to the bucket.
    """
    AUTHENTICATED_READ = "AuthenticatedRead"
    AWS_EXEC_READ = "AwsExecRead"
    BUCKET_OWNER_FULL_CONTROL = "BucketOwnerFullControl"
    BUCKET_OWNER_READ = "BucketOwnerRead"
    LOG_DELIVERY_WRITE = "LogDeliveryWrite"
    PRIVATE = "Private"
    PUBLIC_READ = "PublicRead"
    PUBLIC_READ_WRITE = "PublicReadWrite"


class BucketCorsRuleAllowedMethodsItem(str, Enum):
    GET = "GET"
    PUT = "PUT"
    HEAD = "HEAD"
    POST = "POST"
    DELETE = "DELETE"


class BucketDefaultRetentionMode(str, Enum):
    COMPLIANCE = "COMPLIANCE"
    GOVERNANCE = "GOVERNANCE"


class BucketDeleteMarkerReplicationStatus(str, Enum):
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketDestinationFormat(str, Enum):
    """
    Specifies the file format used when exporting data to Amazon S3.
    """
    CSV = "CSV"
    ORC = "ORC"
    PARQUET = "Parquet"


class BucketIntelligentTieringConfigurationStatus(str, Enum):
    """
    Specifies the status of the configuration.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketInventoryConfigurationIncludedObjectVersions(str, Enum):
    """
    Object versions to include in the inventory list.
    """
    ALL = "All"
    CURRENT = "Current"


class BucketInventoryConfigurationOptionalFieldsItem(str, Enum):
    SIZE = "Size"
    LAST_MODIFIED_DATE = "LastModifiedDate"
    STORAGE_CLASS = "StorageClass"
    E_TAG = "ETag"
    IS_MULTIPART_UPLOADED = "IsMultipartUploaded"
    REPLICATION_STATUS = "ReplicationStatus"
    ENCRYPTION_STATUS = "EncryptionStatus"
    OBJECT_LOCK_RETAIN_UNTIL_DATE = "ObjectLockRetainUntilDate"
    OBJECT_LOCK_MODE = "ObjectLockMode"
    OBJECT_LOCK_LEGAL_HOLD_STATUS = "ObjectLockLegalHoldStatus"
    INTELLIGENT_TIERING_ACCESS_TIER = "IntelligentTieringAccessTier"
    BUCKET_KEY_STATUS = "BucketKeyStatus"


class BucketInventoryConfigurationScheduleFrequency(str, Enum):
    """
    Specifies the schedule for generating inventory results.
    """
    DAILY = "Daily"
    WEEKLY = "Weekly"


class BucketMetricsStatus(str, Enum):
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketNoncurrentVersionTransitionStorageClass(str, Enum):
    """
    The class of storage used to store the object.
    """
    DEEP_ARCHIVE = "DEEP_ARCHIVE"
    GLACIER = "GLACIER"
    GLACIER_IR = "GLACIER_IR"
    INTELLIGENT_TIERING = "INTELLIGENT_TIERING"
    ONEZONE_IA = "ONEZONE_IA"
    STANDARD_IA = "STANDARD_IA"


class BucketOwnershipControlsRuleObjectOwnership(str, Enum):
    """
    Specifies an object ownership rule.
    """
    OBJECT_WRITER = "ObjectWriter"
    BUCKET_OWNER_PREFERRED = "BucketOwnerPreferred"


class BucketRedirectAllRequestsToProtocol(str, Enum):
    """
    Protocol to use when redirecting requests. The default is the protocol that is used in the original request.
    """
    HTTP = "http"
    HTTPS = "https"


class BucketRedirectRuleProtocol(str, Enum):
    """
    Protocol to use when redirecting requests. The default is the protocol that is used in the original request.
    """
    HTTP = "http"
    HTTPS = "https"


class BucketReplicaModificationsStatus(str, Enum):
    """
    Specifies whether Amazon S3 replicates modifications on replicas.
    """
    ENABLED = "Enabled"
    DISABLED = "Disabled"


class BucketReplicationDestinationStorageClass(str, Enum):
    """
    The storage class to use when replicating objects, such as S3 Standard or reduced redundancy.
    """
    DEEP_ARCHIVE = "DEEP_ARCHIVE"
    GLACIER = "GLACIER"
    GLACIER_IR = "GLACIER_IR"
    INTELLIGENT_TIERING = "INTELLIGENT_TIERING"
    ONEZONE_IA = "ONEZONE_IA"
    REDUCED_REDUNDANCY = "REDUCED_REDUNDANCY"
    STANDARD = "STANDARD"
    STANDARD_IA = "STANDARD_IA"


class BucketReplicationRuleStatus(str, Enum):
    """
    Specifies whether the rule is enabled.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketReplicationTimeStatus(str, Enum):
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketRuleStatus(str, Enum):
    ENABLED = "Enabled"
    DISABLED = "Disabled"


class BucketServerSideEncryptionByDefaultSSEAlgorithm(str, Enum):
    AWSKMS = "aws:kms"
    AES256 = "AES256"


class BucketSseKmsEncryptedObjectsStatus(str, Enum):
    """
    Specifies whether Amazon S3 replicates objects created with server-side encryption using a customer master key (CMK) stored in AWS Key Management Service.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class BucketTieringAccessTier(str, Enum):
    """
    S3 Intelligent-Tiering access tier. See Storage class for automatically optimizing frequently and infrequently accessed objects for a list of access tiers in the S3 Intelligent-Tiering storage class.
    """
    ARCHIVE_ACCESS = "ARCHIVE_ACCESS"
    DEEP_ARCHIVE_ACCESS = "DEEP_ARCHIVE_ACCESS"


class BucketTransitionStorageClass(str, Enum):
    DEEP_ARCHIVE = "DEEP_ARCHIVE"
    GLACIER = "GLACIER"
    GLACIER_IR = "GLACIER_IR"
    INTELLIGENT_TIERING = "INTELLIGENT_TIERING"
    ONEZONE_IA = "ONEZONE_IA"
    STANDARD_IA = "STANDARD_IA"


class BucketVersioningConfigurationStatus(str, Enum):
    """
    The versioning state of the bucket.
    """
    ENABLED = "Enabled"
    SUSPENDED = "Suspended"


class MultiRegionAccessPointPolicyPolicyStatusPropertiesIsPublic(str, Enum):
    """
    Specifies whether the policy is public or not.
    """
    TRUE = "true"
    FALSE = "false"


class StorageLensS3BucketDestinationFormat(str, Enum):
    """
    Specifies the file format to use when exporting Amazon S3 Storage Lens metrics export.
    """
    CSV = "CSV"
    PARQUET = "Parquet"


class StorageLensS3BucketDestinationOutputSchemaVersion(str, Enum):
    """
    The version of the output schema to use when exporting Amazon S3 Storage Lens metrics.
    """
    V1 = "V_1"
