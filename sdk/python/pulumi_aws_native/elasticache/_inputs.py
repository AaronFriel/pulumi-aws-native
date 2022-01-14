# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from ._enums import *

__all__ = [
    'CacheClusterCloudWatchLogsDestinationDetailsArgs',
    'CacheClusterDestinationDetailsArgs',
    'CacheClusterKinesisFirehoseDestinationDetailsArgs',
    'CacheClusterLogDeliveryConfigurationRequestArgs',
    'CacheClusterTagArgs',
    'GlobalReplicationGroupMemberArgs',
    'GlobalReplicationGroupRegionalConfigurationArgs',
    'GlobalReplicationGroupReshardingConfigurationArgs',
    'ParameterGroupTagArgs',
    'ReplicationGroupCloudWatchLogsDestinationDetailsArgs',
    'ReplicationGroupDestinationDetailsArgs',
    'ReplicationGroupKinesisFirehoseDestinationDetailsArgs',
    'ReplicationGroupLogDeliveryConfigurationRequestArgs',
    'ReplicationGroupNodeGroupConfigurationArgs',
    'ReplicationGroupTagArgs',
    'SecurityGroupTagArgs',
    'SubnetGroupTagArgs',
]

@pulumi.input_type
class CacheClusterCloudWatchLogsDestinationDetailsArgs:
    def __init__(__self__, *,
                 log_group: pulumi.Input[str]):
        pulumi.set(__self__, "log_group", log_group)

    @property
    @pulumi.getter(name="logGroup")
    def log_group(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_group")

    @log_group.setter
    def log_group(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_group", value)


@pulumi.input_type
class CacheClusterDestinationDetailsArgs:
    def __init__(__self__, *,
                 cloud_watch_logs_details: Optional[pulumi.Input['CacheClusterCloudWatchLogsDestinationDetailsArgs']] = None,
                 kinesis_firehose_details: Optional[pulumi.Input['CacheClusterKinesisFirehoseDestinationDetailsArgs']] = None):
        if cloud_watch_logs_details is not None:
            pulumi.set(__self__, "cloud_watch_logs_details", cloud_watch_logs_details)
        if kinesis_firehose_details is not None:
            pulumi.set(__self__, "kinesis_firehose_details", kinesis_firehose_details)

    @property
    @pulumi.getter(name="cloudWatchLogsDetails")
    def cloud_watch_logs_details(self) -> Optional[pulumi.Input['CacheClusterCloudWatchLogsDestinationDetailsArgs']]:
        return pulumi.get(self, "cloud_watch_logs_details")

    @cloud_watch_logs_details.setter
    def cloud_watch_logs_details(self, value: Optional[pulumi.Input['CacheClusterCloudWatchLogsDestinationDetailsArgs']]):
        pulumi.set(self, "cloud_watch_logs_details", value)

    @property
    @pulumi.getter(name="kinesisFirehoseDetails")
    def kinesis_firehose_details(self) -> Optional[pulumi.Input['CacheClusterKinesisFirehoseDestinationDetailsArgs']]:
        return pulumi.get(self, "kinesis_firehose_details")

    @kinesis_firehose_details.setter
    def kinesis_firehose_details(self, value: Optional[pulumi.Input['CacheClusterKinesisFirehoseDestinationDetailsArgs']]):
        pulumi.set(self, "kinesis_firehose_details", value)


@pulumi.input_type
class CacheClusterKinesisFirehoseDestinationDetailsArgs:
    def __init__(__self__, *,
                 delivery_stream: pulumi.Input[str]):
        pulumi.set(__self__, "delivery_stream", delivery_stream)

    @property
    @pulumi.getter(name="deliveryStream")
    def delivery_stream(self) -> pulumi.Input[str]:
        return pulumi.get(self, "delivery_stream")

    @delivery_stream.setter
    def delivery_stream(self, value: pulumi.Input[str]):
        pulumi.set(self, "delivery_stream", value)


@pulumi.input_type
class CacheClusterLogDeliveryConfigurationRequestArgs:
    def __init__(__self__, *,
                 destination_details: pulumi.Input['CacheClusterDestinationDetailsArgs'],
                 destination_type: pulumi.Input[str],
                 log_format: pulumi.Input[str],
                 log_type: pulumi.Input[str]):
        pulumi.set(__self__, "destination_details", destination_details)
        pulumi.set(__self__, "destination_type", destination_type)
        pulumi.set(__self__, "log_format", log_format)
        pulumi.set(__self__, "log_type", log_type)

    @property
    @pulumi.getter(name="destinationDetails")
    def destination_details(self) -> pulumi.Input['CacheClusterDestinationDetailsArgs']:
        return pulumi.get(self, "destination_details")

    @destination_details.setter
    def destination_details(self, value: pulumi.Input['CacheClusterDestinationDetailsArgs']):
        pulumi.set(self, "destination_details", value)

    @property
    @pulumi.getter(name="destinationType")
    def destination_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "destination_type")

    @destination_type.setter
    def destination_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "destination_type", value)

    @property
    @pulumi.getter(name="logFormat")
    def log_format(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_format")

    @log_format.setter
    def log_format(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_format", value)

    @property
    @pulumi.getter(name="logType")
    def log_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_type")

    @log_type.setter
    def log_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_type", value)


@pulumi.input_type
class CacheClusterTagArgs:
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
class GlobalReplicationGroupMemberArgs:
    def __init__(__self__, *,
                 replication_group_id: Optional[pulumi.Input[str]] = None,
                 replication_group_region: Optional[pulumi.Input[str]] = None,
                 role: Optional[pulumi.Input['GlobalReplicationGroupMemberRole']] = None):
        """
        :param pulumi.Input[str] replication_group_id: Regionally unique identifier for the member i.e. ReplicationGroupId.
        :param pulumi.Input[str] replication_group_region: The AWS region of the Global Datastore member.
        :param pulumi.Input['GlobalReplicationGroupMemberRole'] role: Indicates the role of the member, primary or secondary.
        """
        if replication_group_id is not None:
            pulumi.set(__self__, "replication_group_id", replication_group_id)
        if replication_group_region is not None:
            pulumi.set(__self__, "replication_group_region", replication_group_region)
        if role is not None:
            pulumi.set(__self__, "role", role)

    @property
    @pulumi.getter(name="replicationGroupId")
    def replication_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Regionally unique identifier for the member i.e. ReplicationGroupId.
        """
        return pulumi.get(self, "replication_group_id")

    @replication_group_id.setter
    def replication_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replication_group_id", value)

    @property
    @pulumi.getter(name="replicationGroupRegion")
    def replication_group_region(self) -> Optional[pulumi.Input[str]]:
        """
        The AWS region of the Global Datastore member.
        """
        return pulumi.get(self, "replication_group_region")

    @replication_group_region.setter
    def replication_group_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replication_group_region", value)

    @property
    @pulumi.getter
    def role(self) -> Optional[pulumi.Input['GlobalReplicationGroupMemberRole']]:
        """
        Indicates the role of the member, primary or secondary.
        """
        return pulumi.get(self, "role")

    @role.setter
    def role(self, value: Optional[pulumi.Input['GlobalReplicationGroupMemberRole']]):
        pulumi.set(self, "role", value)


@pulumi.input_type
class GlobalReplicationGroupRegionalConfigurationArgs:
    def __init__(__self__, *,
                 replication_group_id: Optional[pulumi.Input[str]] = None,
                 replication_group_region: Optional[pulumi.Input[str]] = None,
                 resharding_configurations: Optional[pulumi.Input[Sequence[pulumi.Input['GlobalReplicationGroupReshardingConfigurationArgs']]]] = None):
        """
        :param pulumi.Input[str] replication_group_id: The replication group id of the Global Datastore member.
        :param pulumi.Input[str] replication_group_region: The AWS region of the Global Datastore member.
        :param pulumi.Input[Sequence[pulumi.Input['GlobalReplicationGroupReshardingConfigurationArgs']]] resharding_configurations: A list of PreferredAvailabilityZones objects that specifies the configuration of a node group in the resharded cluster. 
        """
        if replication_group_id is not None:
            pulumi.set(__self__, "replication_group_id", replication_group_id)
        if replication_group_region is not None:
            pulumi.set(__self__, "replication_group_region", replication_group_region)
        if resharding_configurations is not None:
            pulumi.set(__self__, "resharding_configurations", resharding_configurations)

    @property
    @pulumi.getter(name="replicationGroupId")
    def replication_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        The replication group id of the Global Datastore member.
        """
        return pulumi.get(self, "replication_group_id")

    @replication_group_id.setter
    def replication_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replication_group_id", value)

    @property
    @pulumi.getter(name="replicationGroupRegion")
    def replication_group_region(self) -> Optional[pulumi.Input[str]]:
        """
        The AWS region of the Global Datastore member.
        """
        return pulumi.get(self, "replication_group_region")

    @replication_group_region.setter
    def replication_group_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "replication_group_region", value)

    @property
    @pulumi.getter(name="reshardingConfigurations")
    def resharding_configurations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['GlobalReplicationGroupReshardingConfigurationArgs']]]]:
        """
        A list of PreferredAvailabilityZones objects that specifies the configuration of a node group in the resharded cluster. 
        """
        return pulumi.get(self, "resharding_configurations")

    @resharding_configurations.setter
    def resharding_configurations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['GlobalReplicationGroupReshardingConfigurationArgs']]]]):
        pulumi.set(self, "resharding_configurations", value)


@pulumi.input_type
class GlobalReplicationGroupReshardingConfigurationArgs:
    def __init__(__self__, *,
                 node_group_id: Optional[pulumi.Input[str]] = None,
                 preferred_availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        :param pulumi.Input[str] node_group_id: Unique identifier for the Node Group. This is either auto-generated by ElastiCache (4-digit id) or a user supplied id.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] preferred_availability_zones: A list of preferred availability zones for the nodes of new node groups.
        """
        if node_group_id is not None:
            pulumi.set(__self__, "node_group_id", node_group_id)
        if preferred_availability_zones is not None:
            pulumi.set(__self__, "preferred_availability_zones", preferred_availability_zones)

    @property
    @pulumi.getter(name="nodeGroupId")
    def node_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        Unique identifier for the Node Group. This is either auto-generated by ElastiCache (4-digit id) or a user supplied id.
        """
        return pulumi.get(self, "node_group_id")

    @node_group_id.setter
    def node_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "node_group_id", value)

    @property
    @pulumi.getter(name="preferredAvailabilityZones")
    def preferred_availability_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of preferred availability zones for the nodes of new node groups.
        """
        return pulumi.get(self, "preferred_availability_zones")

    @preferred_availability_zones.setter
    def preferred_availability_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "preferred_availability_zones", value)


@pulumi.input_type
class ParameterGroupTagArgs:
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
class ReplicationGroupCloudWatchLogsDestinationDetailsArgs:
    def __init__(__self__, *,
                 log_group: pulumi.Input[str]):
        pulumi.set(__self__, "log_group", log_group)

    @property
    @pulumi.getter(name="logGroup")
    def log_group(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_group")

    @log_group.setter
    def log_group(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_group", value)


@pulumi.input_type
class ReplicationGroupDestinationDetailsArgs:
    def __init__(__self__, *,
                 cloud_watch_logs_details: Optional[pulumi.Input['ReplicationGroupCloudWatchLogsDestinationDetailsArgs']] = None,
                 kinesis_firehose_details: Optional[pulumi.Input['ReplicationGroupKinesisFirehoseDestinationDetailsArgs']] = None):
        if cloud_watch_logs_details is not None:
            pulumi.set(__self__, "cloud_watch_logs_details", cloud_watch_logs_details)
        if kinesis_firehose_details is not None:
            pulumi.set(__self__, "kinesis_firehose_details", kinesis_firehose_details)

    @property
    @pulumi.getter(name="cloudWatchLogsDetails")
    def cloud_watch_logs_details(self) -> Optional[pulumi.Input['ReplicationGroupCloudWatchLogsDestinationDetailsArgs']]:
        return pulumi.get(self, "cloud_watch_logs_details")

    @cloud_watch_logs_details.setter
    def cloud_watch_logs_details(self, value: Optional[pulumi.Input['ReplicationGroupCloudWatchLogsDestinationDetailsArgs']]):
        pulumi.set(self, "cloud_watch_logs_details", value)

    @property
    @pulumi.getter(name="kinesisFirehoseDetails")
    def kinesis_firehose_details(self) -> Optional[pulumi.Input['ReplicationGroupKinesisFirehoseDestinationDetailsArgs']]:
        return pulumi.get(self, "kinesis_firehose_details")

    @kinesis_firehose_details.setter
    def kinesis_firehose_details(self, value: Optional[pulumi.Input['ReplicationGroupKinesisFirehoseDestinationDetailsArgs']]):
        pulumi.set(self, "kinesis_firehose_details", value)


@pulumi.input_type
class ReplicationGroupKinesisFirehoseDestinationDetailsArgs:
    def __init__(__self__, *,
                 delivery_stream: pulumi.Input[str]):
        pulumi.set(__self__, "delivery_stream", delivery_stream)

    @property
    @pulumi.getter(name="deliveryStream")
    def delivery_stream(self) -> pulumi.Input[str]:
        return pulumi.get(self, "delivery_stream")

    @delivery_stream.setter
    def delivery_stream(self, value: pulumi.Input[str]):
        pulumi.set(self, "delivery_stream", value)


@pulumi.input_type
class ReplicationGroupLogDeliveryConfigurationRequestArgs:
    def __init__(__self__, *,
                 destination_details: pulumi.Input['ReplicationGroupDestinationDetailsArgs'],
                 destination_type: pulumi.Input[str],
                 log_format: pulumi.Input[str],
                 log_type: pulumi.Input[str]):
        pulumi.set(__self__, "destination_details", destination_details)
        pulumi.set(__self__, "destination_type", destination_type)
        pulumi.set(__self__, "log_format", log_format)
        pulumi.set(__self__, "log_type", log_type)

    @property
    @pulumi.getter(name="destinationDetails")
    def destination_details(self) -> pulumi.Input['ReplicationGroupDestinationDetailsArgs']:
        return pulumi.get(self, "destination_details")

    @destination_details.setter
    def destination_details(self, value: pulumi.Input['ReplicationGroupDestinationDetailsArgs']):
        pulumi.set(self, "destination_details", value)

    @property
    @pulumi.getter(name="destinationType")
    def destination_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "destination_type")

    @destination_type.setter
    def destination_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "destination_type", value)

    @property
    @pulumi.getter(name="logFormat")
    def log_format(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_format")

    @log_format.setter
    def log_format(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_format", value)

    @property
    @pulumi.getter(name="logType")
    def log_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "log_type")

    @log_type.setter
    def log_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "log_type", value)


@pulumi.input_type
class ReplicationGroupNodeGroupConfigurationArgs:
    def __init__(__self__, *,
                 node_group_id: Optional[pulumi.Input[str]] = None,
                 primary_availability_zone: Optional[pulumi.Input[str]] = None,
                 replica_availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 replica_count: Optional[pulumi.Input[int]] = None,
                 slots: Optional[pulumi.Input[str]] = None):
        if node_group_id is not None:
            pulumi.set(__self__, "node_group_id", node_group_id)
        if primary_availability_zone is not None:
            pulumi.set(__self__, "primary_availability_zone", primary_availability_zone)
        if replica_availability_zones is not None:
            pulumi.set(__self__, "replica_availability_zones", replica_availability_zones)
        if replica_count is not None:
            pulumi.set(__self__, "replica_count", replica_count)
        if slots is not None:
            pulumi.set(__self__, "slots", slots)

    @property
    @pulumi.getter(name="nodeGroupId")
    def node_group_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "node_group_id")

    @node_group_id.setter
    def node_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "node_group_id", value)

    @property
    @pulumi.getter(name="primaryAvailabilityZone")
    def primary_availability_zone(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "primary_availability_zone")

    @primary_availability_zone.setter
    def primary_availability_zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "primary_availability_zone", value)

    @property
    @pulumi.getter(name="replicaAvailabilityZones")
    def replica_availability_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "replica_availability_zones")

    @replica_availability_zones.setter
    def replica_availability_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "replica_availability_zones", value)

    @property
    @pulumi.getter(name="replicaCount")
    def replica_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "replica_count")

    @replica_count.setter
    def replica_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "replica_count", value)

    @property
    @pulumi.getter
    def slots(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "slots")

    @slots.setter
    def slots(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "slots", value)


@pulumi.input_type
class ReplicationGroupTagArgs:
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
class SecurityGroupTagArgs:
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
class SubnetGroupTagArgs:
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


