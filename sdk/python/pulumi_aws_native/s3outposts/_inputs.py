# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AccessPointVpcConfigurationArgs',
    'BucketAbortIncompleteMultipartUploadArgs',
    'BucketLifecycleConfigurationArgs',
    'BucketRuleArgs',
    'BucketTagArgs',
]

@pulumi.input_type
class AccessPointVpcConfigurationArgs:
    def __init__(__self__, *,
                 vpc_id: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] vpc_id: Virtual Private Cloud (VPC) Id from which AccessPoint will allow requests.
        """
        if vpc_id is not None:
            pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> Optional[pulumi.Input[str]]:
        """
        Virtual Private Cloud (VPC) Id from which AccessPoint will allow requests.
        """
        return pulumi.get(self, "vpc_id")

    @vpc_id.setter
    def vpc_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpc_id", value)


@pulumi.input_type
class BucketAbortIncompleteMultipartUploadArgs:
    def __init__(__self__, *,
                 days_after_initiation: pulumi.Input[int]):
        """
        Specifies the days since the initiation of an incomplete multipart upload that Amazon S3Outposts will wait before permanently removing all parts of the upload.
        :param pulumi.Input[int] days_after_initiation: Specifies the number of days after which Amazon S3Outposts aborts an incomplete multipart upload.
        """
        pulumi.set(__self__, "days_after_initiation", days_after_initiation)

    @property
    @pulumi.getter(name="daysAfterInitiation")
    def days_after_initiation(self) -> pulumi.Input[int]:
        """
        Specifies the number of days after which Amazon S3Outposts aborts an incomplete multipart upload.
        """
        return pulumi.get(self, "days_after_initiation")

    @days_after_initiation.setter
    def days_after_initiation(self, value: pulumi.Input[int]):
        pulumi.set(self, "days_after_initiation", value)


@pulumi.input_type
class BucketLifecycleConfigurationArgs:
    def __init__(__self__, *,
                 rules: pulumi.Input[Sequence[pulumi.Input['BucketRuleArgs']]]):
        """
        :param pulumi.Input[Sequence[pulumi.Input['BucketRuleArgs']]] rules: A list of lifecycle rules for individual objects in an Amazon S3Outposts bucket.
        """
        pulumi.set(__self__, "rules", rules)

    @property
    @pulumi.getter
    def rules(self) -> pulumi.Input[Sequence[pulumi.Input['BucketRuleArgs']]]:
        """
        A list of lifecycle rules for individual objects in an Amazon S3Outposts bucket.
        """
        return pulumi.get(self, "rules")

    @rules.setter
    def rules(self, value: pulumi.Input[Sequence[pulumi.Input['BucketRuleArgs']]]):
        pulumi.set(self, "rules", value)


@pulumi.input_type
class BucketRuleArgs:
    def __init__(__self__, *,
                 abort_incomplete_multipart_upload: Optional[pulumi.Input['BucketAbortIncompleteMultipartUploadArgs']] = None,
                 expiration_date: Optional[pulumi.Input[str]] = None,
                 expiration_in_days: Optional[pulumi.Input[int]] = None,
                 filter: Optional[Any] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Specifies lifecycle rules for an Amazon S3Outposts bucket. You must specify at least one of the following: AbortIncompleteMultipartUpload, ExpirationDate, ExpirationInDays.
        :param pulumi.Input['BucketAbortIncompleteMultipartUploadArgs'] abort_incomplete_multipart_upload: Specifies a lifecycle rule that stops incomplete multipart uploads to an Amazon S3Outposts bucket.
        :param pulumi.Input[str] expiration_date: Indicates when objects are deleted from Amazon S3Outposts. The date value must be in ISO 8601 format. The time is always midnight UTC.
        :param pulumi.Input[int] expiration_in_days: Indicates the number of days after creation when objects are deleted from Amazon S3Outposts.
        :param Any filter: The container for the filter of the lifecycle rule.
        :param pulumi.Input[str] id: Unique identifier for the lifecycle rule. The value can't be longer than 255 characters.
        """
        if abort_incomplete_multipart_upload is not None:
            pulumi.set(__self__, "abort_incomplete_multipart_upload", abort_incomplete_multipart_upload)
        if expiration_date is not None:
            pulumi.set(__self__, "expiration_date", expiration_date)
        if expiration_in_days is not None:
            pulumi.set(__self__, "expiration_in_days", expiration_in_days)
        if filter is not None:
            pulumi.set(__self__, "filter", filter)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="abortIncompleteMultipartUpload")
    def abort_incomplete_multipart_upload(self) -> Optional[pulumi.Input['BucketAbortIncompleteMultipartUploadArgs']]:
        """
        Specifies a lifecycle rule that stops incomplete multipart uploads to an Amazon S3Outposts bucket.
        """
        return pulumi.get(self, "abort_incomplete_multipart_upload")

    @abort_incomplete_multipart_upload.setter
    def abort_incomplete_multipart_upload(self, value: Optional[pulumi.Input['BucketAbortIncompleteMultipartUploadArgs']]):
        pulumi.set(self, "abort_incomplete_multipart_upload", value)

    @property
    @pulumi.getter(name="expirationDate")
    def expiration_date(self) -> Optional[pulumi.Input[str]]:
        """
        Indicates when objects are deleted from Amazon S3Outposts. The date value must be in ISO 8601 format. The time is always midnight UTC.
        """
        return pulumi.get(self, "expiration_date")

    @expiration_date.setter
    def expiration_date(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "expiration_date", value)

    @property
    @pulumi.getter(name="expirationInDays")
    def expiration_in_days(self) -> Optional[pulumi.Input[int]]:
        """
        Indicates the number of days after creation when objects are deleted from Amazon S3Outposts.
        """
        return pulumi.get(self, "expiration_in_days")

    @expiration_in_days.setter
    def expiration_in_days(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "expiration_in_days", value)

    @property
    @pulumi.getter
    def filter(self) -> Optional[Any]:
        """
        The container for the filter of the lifecycle rule.
        """
        return pulumi.get(self, "filter")

    @filter.setter
    def filter(self, value: Optional[Any]):
        pulumi.set(self, "filter", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Unique identifier for the lifecycle rule. The value can't be longer than 255 characters.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class BucketTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


