# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'KeyspaceTagArgs',
    'TableBillingModeArgs',
    'TableClusteringKeyColumnArgs',
    'TableColumnArgs',
    'TableEncryptionSpecificationArgs',
    'TableProvisionedThroughputArgs',
    'TableTagArgs',
]

@pulumi.input_type
class KeyspaceTagArgs:
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


@pulumi.input_type
class TableBillingModeArgs:
    def __init__(__self__, *,
                 mode: pulumi.Input[str],
                 provisioned_throughput: Optional[pulumi.Input['TableProvisionedThroughputArgs']] = None):
        pulumi.set(__self__, "mode", mode)
        if provisioned_throughput is not None:
            pulumi.set(__self__, "provisioned_throughput", provisioned_throughput)

    @property
    @pulumi.getter
    def mode(self) -> pulumi.Input[str]:
        return pulumi.get(self, "mode")

    @mode.setter
    def mode(self, value: pulumi.Input[str]):
        pulumi.set(self, "mode", value)

    @property
    @pulumi.getter(name="provisionedThroughput")
    def provisioned_throughput(self) -> Optional[pulumi.Input['TableProvisionedThroughputArgs']]:
        return pulumi.get(self, "provisioned_throughput")

    @provisioned_throughput.setter
    def provisioned_throughput(self, value: Optional[pulumi.Input['TableProvisionedThroughputArgs']]):
        pulumi.set(self, "provisioned_throughput", value)


@pulumi.input_type
class TableClusteringKeyColumnArgs:
    def __init__(__self__, *,
                 column: pulumi.Input['TableColumnArgs'],
                 order_by: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "column", column)
        if order_by is not None:
            pulumi.set(__self__, "order_by", order_by)

    @property
    @pulumi.getter
    def column(self) -> pulumi.Input['TableColumnArgs']:
        return pulumi.get(self, "column")

    @column.setter
    def column(self, value: pulumi.Input['TableColumnArgs']):
        pulumi.set(self, "column", value)

    @property
    @pulumi.getter(name="orderBy")
    def order_by(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "order_by")

    @order_by.setter
    def order_by(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "order_by", value)


@pulumi.input_type
class TableColumnArgs:
    def __init__(__self__, *,
                 column_name: pulumi.Input[str],
                 column_type: pulumi.Input[str]):
        pulumi.set(__self__, "column_name", column_name)
        pulumi.set(__self__, "column_type", column_type)

    @property
    @pulumi.getter(name="columnName")
    def column_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "column_name")

    @column_name.setter
    def column_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "column_name", value)

    @property
    @pulumi.getter(name="columnType")
    def column_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "column_type")

    @column_type.setter
    def column_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "column_type", value)


@pulumi.input_type
class TableEncryptionSpecificationArgs:
    def __init__(__self__, *,
                 encryption_type: pulumi.Input[str],
                 kms_key_identifier: Optional[pulumi.Input[str]] = None):
        """
        Represents the settings used to enable server-side encryption
        """
        pulumi.set(__self__, "encryption_type", encryption_type)
        if kms_key_identifier is not None:
            pulumi.set(__self__, "kms_key_identifier", kms_key_identifier)

    @property
    @pulumi.getter(name="encryptionType")
    def encryption_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "encryption_type")

    @encryption_type.setter
    def encryption_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "encryption_type", value)

    @property
    @pulumi.getter(name="kmsKeyIdentifier")
    def kms_key_identifier(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "kms_key_identifier")

    @kms_key_identifier.setter
    def kms_key_identifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "kms_key_identifier", value)


@pulumi.input_type
class TableProvisionedThroughputArgs:
    def __init__(__self__, *,
                 read_capacity_units: pulumi.Input[int],
                 write_capacity_units: pulumi.Input[int]):
        """
        Throughput for the specified table, which consists of values for ReadCapacityUnits and WriteCapacityUnits
        """
        pulumi.set(__self__, "read_capacity_units", read_capacity_units)
        pulumi.set(__self__, "write_capacity_units", write_capacity_units)

    @property
    @pulumi.getter(name="readCapacityUnits")
    def read_capacity_units(self) -> pulumi.Input[int]:
        return pulumi.get(self, "read_capacity_units")

    @read_capacity_units.setter
    def read_capacity_units(self, value: pulumi.Input[int]):
        pulumi.set(self, "read_capacity_units", value)

    @property
    @pulumi.getter(name="writeCapacityUnits")
    def write_capacity_units(self) -> pulumi.Input[int]:
        return pulumi.get(self, "write_capacity_units")

    @write_capacity_units.setter
    def write_capacity_units(self, value: pulumi.Input[int]):
        pulumi.set(self, "write_capacity_units", value)


@pulumi.input_type
class TableTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to apply to the resource
        """
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


