# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['CacheClusterArgs', 'CacheCluster']

@pulumi.input_type
class CacheClusterArgs:
    def __init__(__self__, *,
                 cache_node_type: pulumi.Input[str],
                 engine: pulumi.Input[str],
                 num_cache_nodes: pulumi.Input[int],
                 a_z_mode: Optional[pulumi.Input[str]] = None,
                 auto_minor_version_upgrade: Optional[pulumi.Input[bool]] = None,
                 cache_parameter_group_name: Optional[pulumi.Input[str]] = None,
                 cache_security_group_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cache_subnet_group_name: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_address: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_port: Optional[pulumi.Input[str]] = None,
                 engine_version: Optional[pulumi.Input[str]] = None,
                 log_delivery_configurations: Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterLogDeliveryConfigurationRequestArgs']]]] = None,
                 notification_topic_arn: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 preferred_availability_zone: Optional[pulumi.Input[str]] = None,
                 preferred_availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 preferred_maintenance_window: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_address: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_port: Optional[pulumi.Input[str]] = None,
                 snapshot_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 snapshot_retention_limit: Optional[pulumi.Input[int]] = None,
                 snapshot_window: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterTagArgs']]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a CacheCluster resource.
        """
        pulumi.set(__self__, "cache_node_type", cache_node_type)
        pulumi.set(__self__, "engine", engine)
        pulumi.set(__self__, "num_cache_nodes", num_cache_nodes)
        if a_z_mode is not None:
            pulumi.set(__self__, "a_z_mode", a_z_mode)
        if auto_minor_version_upgrade is not None:
            pulumi.set(__self__, "auto_minor_version_upgrade", auto_minor_version_upgrade)
        if cache_parameter_group_name is not None:
            pulumi.set(__self__, "cache_parameter_group_name", cache_parameter_group_name)
        if cache_security_group_names is not None:
            pulumi.set(__self__, "cache_security_group_names", cache_security_group_names)
        if cache_subnet_group_name is not None:
            pulumi.set(__self__, "cache_subnet_group_name", cache_subnet_group_name)
        if cluster_name is not None:
            pulumi.set(__self__, "cluster_name", cluster_name)
        if configuration_endpoint_address is not None:
            pulumi.set(__self__, "configuration_endpoint_address", configuration_endpoint_address)
        if configuration_endpoint_port is not None:
            pulumi.set(__self__, "configuration_endpoint_port", configuration_endpoint_port)
        if engine_version is not None:
            pulumi.set(__self__, "engine_version", engine_version)
        if log_delivery_configurations is not None:
            pulumi.set(__self__, "log_delivery_configurations", log_delivery_configurations)
        if notification_topic_arn is not None:
            pulumi.set(__self__, "notification_topic_arn", notification_topic_arn)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if preferred_availability_zone is not None:
            pulumi.set(__self__, "preferred_availability_zone", preferred_availability_zone)
        if preferred_availability_zones is not None:
            pulumi.set(__self__, "preferred_availability_zones", preferred_availability_zones)
        if preferred_maintenance_window is not None:
            pulumi.set(__self__, "preferred_maintenance_window", preferred_maintenance_window)
        if redis_endpoint_address is not None:
            pulumi.set(__self__, "redis_endpoint_address", redis_endpoint_address)
        if redis_endpoint_port is not None:
            pulumi.set(__self__, "redis_endpoint_port", redis_endpoint_port)
        if snapshot_arns is not None:
            pulumi.set(__self__, "snapshot_arns", snapshot_arns)
        if snapshot_name is not None:
            pulumi.set(__self__, "snapshot_name", snapshot_name)
        if snapshot_retention_limit is not None:
            pulumi.set(__self__, "snapshot_retention_limit", snapshot_retention_limit)
        if snapshot_window is not None:
            pulumi.set(__self__, "snapshot_window", snapshot_window)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if vpc_security_group_ids is not None:
            pulumi.set(__self__, "vpc_security_group_ids", vpc_security_group_ids)

    @property
    @pulumi.getter(name="cacheNodeType")
    def cache_node_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "cache_node_type")

    @cache_node_type.setter
    def cache_node_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "cache_node_type", value)

    @property
    @pulumi.getter
    def engine(self) -> pulumi.Input[str]:
        return pulumi.get(self, "engine")

    @engine.setter
    def engine(self, value: pulumi.Input[str]):
        pulumi.set(self, "engine", value)

    @property
    @pulumi.getter(name="numCacheNodes")
    def num_cache_nodes(self) -> pulumi.Input[int]:
        return pulumi.get(self, "num_cache_nodes")

    @num_cache_nodes.setter
    def num_cache_nodes(self, value: pulumi.Input[int]):
        pulumi.set(self, "num_cache_nodes", value)

    @property
    @pulumi.getter(name="aZMode")
    def a_z_mode(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "a_z_mode")

    @a_z_mode.setter
    def a_z_mode(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "a_z_mode", value)

    @property
    @pulumi.getter(name="autoMinorVersionUpgrade")
    def auto_minor_version_upgrade(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "auto_minor_version_upgrade")

    @auto_minor_version_upgrade.setter
    def auto_minor_version_upgrade(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "auto_minor_version_upgrade", value)

    @property
    @pulumi.getter(name="cacheParameterGroupName")
    def cache_parameter_group_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cache_parameter_group_name")

    @cache_parameter_group_name.setter
    def cache_parameter_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cache_parameter_group_name", value)

    @property
    @pulumi.getter(name="cacheSecurityGroupNames")
    def cache_security_group_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "cache_security_group_names")

    @cache_security_group_names.setter
    def cache_security_group_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "cache_security_group_names", value)

    @property
    @pulumi.getter(name="cacheSubnetGroupName")
    def cache_subnet_group_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cache_subnet_group_name")

    @cache_subnet_group_name.setter
    def cache_subnet_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cache_subnet_group_name", value)

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cluster_name")

    @cluster_name.setter
    def cluster_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_name", value)

    @property
    @pulumi.getter(name="configurationEndpointAddress")
    def configuration_endpoint_address(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "configuration_endpoint_address")

    @configuration_endpoint_address.setter
    def configuration_endpoint_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "configuration_endpoint_address", value)

    @property
    @pulumi.getter(name="configurationEndpointPort")
    def configuration_endpoint_port(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "configuration_endpoint_port")

    @configuration_endpoint_port.setter
    def configuration_endpoint_port(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "configuration_endpoint_port", value)

    @property
    @pulumi.getter(name="engineVersion")
    def engine_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "engine_version")

    @engine_version.setter
    def engine_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "engine_version", value)

    @property
    @pulumi.getter(name="logDeliveryConfigurations")
    def log_delivery_configurations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterLogDeliveryConfigurationRequestArgs']]]]:
        return pulumi.get(self, "log_delivery_configurations")

    @log_delivery_configurations.setter
    def log_delivery_configurations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterLogDeliveryConfigurationRequestArgs']]]]):
        pulumi.set(self, "log_delivery_configurations", value)

    @property
    @pulumi.getter(name="notificationTopicArn")
    def notification_topic_arn(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "notification_topic_arn")

    @notification_topic_arn.setter
    def notification_topic_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "notification_topic_arn", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="preferredAvailabilityZone")
    def preferred_availability_zone(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "preferred_availability_zone")

    @preferred_availability_zone.setter
    def preferred_availability_zone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "preferred_availability_zone", value)

    @property
    @pulumi.getter(name="preferredAvailabilityZones")
    def preferred_availability_zones(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "preferred_availability_zones")

    @preferred_availability_zones.setter
    def preferred_availability_zones(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "preferred_availability_zones", value)

    @property
    @pulumi.getter(name="preferredMaintenanceWindow")
    def preferred_maintenance_window(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "preferred_maintenance_window")

    @preferred_maintenance_window.setter
    def preferred_maintenance_window(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "preferred_maintenance_window", value)

    @property
    @pulumi.getter(name="redisEndpointAddress")
    def redis_endpoint_address(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "redis_endpoint_address")

    @redis_endpoint_address.setter
    def redis_endpoint_address(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "redis_endpoint_address", value)

    @property
    @pulumi.getter(name="redisEndpointPort")
    def redis_endpoint_port(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "redis_endpoint_port")

    @redis_endpoint_port.setter
    def redis_endpoint_port(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "redis_endpoint_port", value)

    @property
    @pulumi.getter(name="snapshotArns")
    def snapshot_arns(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "snapshot_arns")

    @snapshot_arns.setter
    def snapshot_arns(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "snapshot_arns", value)

    @property
    @pulumi.getter(name="snapshotName")
    def snapshot_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "snapshot_name")

    @snapshot_name.setter
    def snapshot_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "snapshot_name", value)

    @property
    @pulumi.getter(name="snapshotRetentionLimit")
    def snapshot_retention_limit(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "snapshot_retention_limit")

    @snapshot_retention_limit.setter
    def snapshot_retention_limit(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "snapshot_retention_limit", value)

    @property
    @pulumi.getter(name="snapshotWindow")
    def snapshot_window(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "snapshot_window")

    @snapshot_window.setter
    def snapshot_window(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "snapshot_window", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterTagArgs']]]]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['CacheClusterTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "vpc_security_group_ids")

    @vpc_security_group_ids.setter
    def vpc_security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "vpc_security_group_ids", value)


warnings.warn("""CacheCluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class CacheCluster(pulumi.CustomResource):
    warnings.warn("""CacheCluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 a_z_mode: Optional[pulumi.Input[str]] = None,
                 auto_minor_version_upgrade: Optional[pulumi.Input[bool]] = None,
                 cache_node_type: Optional[pulumi.Input[str]] = None,
                 cache_parameter_group_name: Optional[pulumi.Input[str]] = None,
                 cache_security_group_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cache_subnet_group_name: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_address: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_port: Optional[pulumi.Input[str]] = None,
                 engine: Optional[pulumi.Input[str]] = None,
                 engine_version: Optional[pulumi.Input[str]] = None,
                 log_delivery_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CacheClusterLogDeliveryConfigurationRequestArgs']]]]] = None,
                 notification_topic_arn: Optional[pulumi.Input[str]] = None,
                 num_cache_nodes: Optional[pulumi.Input[int]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 preferred_availability_zone: Optional[pulumi.Input[str]] = None,
                 preferred_availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 preferred_maintenance_window: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_address: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_port: Optional[pulumi.Input[str]] = None,
                 snapshot_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 snapshot_retention_limit: Optional[pulumi.Input[int]] = None,
                 snapshot_window: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CacheClusterTagArgs']]]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::ElastiCache::CacheCluster

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: CacheClusterArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::ElastiCache::CacheCluster

        :param str resource_name: The name of the resource.
        :param CacheClusterArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(CacheClusterArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 a_z_mode: Optional[pulumi.Input[str]] = None,
                 auto_minor_version_upgrade: Optional[pulumi.Input[bool]] = None,
                 cache_node_type: Optional[pulumi.Input[str]] = None,
                 cache_parameter_group_name: Optional[pulumi.Input[str]] = None,
                 cache_security_group_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 cache_subnet_group_name: Optional[pulumi.Input[str]] = None,
                 cluster_name: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_address: Optional[pulumi.Input[str]] = None,
                 configuration_endpoint_port: Optional[pulumi.Input[str]] = None,
                 engine: Optional[pulumi.Input[str]] = None,
                 engine_version: Optional[pulumi.Input[str]] = None,
                 log_delivery_configurations: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CacheClusterLogDeliveryConfigurationRequestArgs']]]]] = None,
                 notification_topic_arn: Optional[pulumi.Input[str]] = None,
                 num_cache_nodes: Optional[pulumi.Input[int]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 preferred_availability_zone: Optional[pulumi.Input[str]] = None,
                 preferred_availability_zones: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 preferred_maintenance_window: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_address: Optional[pulumi.Input[str]] = None,
                 redis_endpoint_port: Optional[pulumi.Input[str]] = None,
                 snapshot_arns: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 snapshot_name: Optional[pulumi.Input[str]] = None,
                 snapshot_retention_limit: Optional[pulumi.Input[int]] = None,
                 snapshot_window: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['CacheClusterTagArgs']]]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        pulumi.log.warn("""CacheCluster is deprecated: CacheCluster is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = CacheClusterArgs.__new__(CacheClusterArgs)

            __props__.__dict__["a_z_mode"] = a_z_mode
            __props__.__dict__["auto_minor_version_upgrade"] = auto_minor_version_upgrade
            if cache_node_type is None and not opts.urn:
                raise TypeError("Missing required property 'cache_node_type'")
            __props__.__dict__["cache_node_type"] = cache_node_type
            __props__.__dict__["cache_parameter_group_name"] = cache_parameter_group_name
            __props__.__dict__["cache_security_group_names"] = cache_security_group_names
            __props__.__dict__["cache_subnet_group_name"] = cache_subnet_group_name
            __props__.__dict__["cluster_name"] = cluster_name
            __props__.__dict__["configuration_endpoint_address"] = configuration_endpoint_address
            __props__.__dict__["configuration_endpoint_port"] = configuration_endpoint_port
            if engine is None and not opts.urn:
                raise TypeError("Missing required property 'engine'")
            __props__.__dict__["engine"] = engine
            __props__.__dict__["engine_version"] = engine_version
            __props__.__dict__["log_delivery_configurations"] = log_delivery_configurations
            __props__.__dict__["notification_topic_arn"] = notification_topic_arn
            if num_cache_nodes is None and not opts.urn:
                raise TypeError("Missing required property 'num_cache_nodes'")
            __props__.__dict__["num_cache_nodes"] = num_cache_nodes
            __props__.__dict__["port"] = port
            __props__.__dict__["preferred_availability_zone"] = preferred_availability_zone
            __props__.__dict__["preferred_availability_zones"] = preferred_availability_zones
            __props__.__dict__["preferred_maintenance_window"] = preferred_maintenance_window
            __props__.__dict__["redis_endpoint_address"] = redis_endpoint_address
            __props__.__dict__["redis_endpoint_port"] = redis_endpoint_port
            __props__.__dict__["snapshot_arns"] = snapshot_arns
            __props__.__dict__["snapshot_name"] = snapshot_name
            __props__.__dict__["snapshot_retention_limit"] = snapshot_retention_limit
            __props__.__dict__["snapshot_window"] = snapshot_window
            __props__.__dict__["tags"] = tags
            __props__.__dict__["vpc_security_group_ids"] = vpc_security_group_ids
        super(CacheCluster, __self__).__init__(
            'aws-native:elasticache:CacheCluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'CacheCluster':
        """
        Get an existing CacheCluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = CacheClusterArgs.__new__(CacheClusterArgs)

        __props__.__dict__["a_z_mode"] = None
        __props__.__dict__["auto_minor_version_upgrade"] = None
        __props__.__dict__["cache_node_type"] = None
        __props__.__dict__["cache_parameter_group_name"] = None
        __props__.__dict__["cache_security_group_names"] = None
        __props__.__dict__["cache_subnet_group_name"] = None
        __props__.__dict__["cluster_name"] = None
        __props__.__dict__["configuration_endpoint_address"] = None
        __props__.__dict__["configuration_endpoint_port"] = None
        __props__.__dict__["engine"] = None
        __props__.__dict__["engine_version"] = None
        __props__.__dict__["log_delivery_configurations"] = None
        __props__.__dict__["notification_topic_arn"] = None
        __props__.__dict__["num_cache_nodes"] = None
        __props__.__dict__["port"] = None
        __props__.__dict__["preferred_availability_zone"] = None
        __props__.__dict__["preferred_availability_zones"] = None
        __props__.__dict__["preferred_maintenance_window"] = None
        __props__.__dict__["redis_endpoint_address"] = None
        __props__.__dict__["redis_endpoint_port"] = None
        __props__.__dict__["snapshot_arns"] = None
        __props__.__dict__["snapshot_name"] = None
        __props__.__dict__["snapshot_retention_limit"] = None
        __props__.__dict__["snapshot_window"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["vpc_security_group_ids"] = None
        return CacheCluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="aZMode")
    def a_z_mode(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "a_z_mode")

    @property
    @pulumi.getter(name="autoMinorVersionUpgrade")
    def auto_minor_version_upgrade(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "auto_minor_version_upgrade")

    @property
    @pulumi.getter(name="cacheNodeType")
    def cache_node_type(self) -> pulumi.Output[str]:
        return pulumi.get(self, "cache_node_type")

    @property
    @pulumi.getter(name="cacheParameterGroupName")
    def cache_parameter_group_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "cache_parameter_group_name")

    @property
    @pulumi.getter(name="cacheSecurityGroupNames")
    def cache_security_group_names(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "cache_security_group_names")

    @property
    @pulumi.getter(name="cacheSubnetGroupName")
    def cache_subnet_group_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "cache_subnet_group_name")

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "cluster_name")

    @property
    @pulumi.getter(name="configurationEndpointAddress")
    def configuration_endpoint_address(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "configuration_endpoint_address")

    @property
    @pulumi.getter(name="configurationEndpointPort")
    def configuration_endpoint_port(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "configuration_endpoint_port")

    @property
    @pulumi.getter
    def engine(self) -> pulumi.Output[str]:
        return pulumi.get(self, "engine")

    @property
    @pulumi.getter(name="engineVersion")
    def engine_version(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "engine_version")

    @property
    @pulumi.getter(name="logDeliveryConfigurations")
    def log_delivery_configurations(self) -> pulumi.Output[Optional[Sequence['outputs.CacheClusterLogDeliveryConfigurationRequest']]]:
        return pulumi.get(self, "log_delivery_configurations")

    @property
    @pulumi.getter(name="notificationTopicArn")
    def notification_topic_arn(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "notification_topic_arn")

    @property
    @pulumi.getter(name="numCacheNodes")
    def num_cache_nodes(self) -> pulumi.Output[int]:
        return pulumi.get(self, "num_cache_nodes")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="preferredAvailabilityZone")
    def preferred_availability_zone(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "preferred_availability_zone")

    @property
    @pulumi.getter(name="preferredAvailabilityZones")
    def preferred_availability_zones(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "preferred_availability_zones")

    @property
    @pulumi.getter(name="preferredMaintenanceWindow")
    def preferred_maintenance_window(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "preferred_maintenance_window")

    @property
    @pulumi.getter(name="redisEndpointAddress")
    def redis_endpoint_address(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "redis_endpoint_address")

    @property
    @pulumi.getter(name="redisEndpointPort")
    def redis_endpoint_port(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "redis_endpoint_port")

    @property
    @pulumi.getter(name="snapshotArns")
    def snapshot_arns(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "snapshot_arns")

    @property
    @pulumi.getter(name="snapshotName")
    def snapshot_name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "snapshot_name")

    @property
    @pulumi.getter(name="snapshotRetentionLimit")
    def snapshot_retention_limit(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "snapshot_retention_limit")

    @property
    @pulumi.getter(name="snapshotWindow")
    def snapshot_window(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "snapshot_window")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.CacheClusterTag']]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        return pulumi.get(self, "vpc_security_group_ids")

