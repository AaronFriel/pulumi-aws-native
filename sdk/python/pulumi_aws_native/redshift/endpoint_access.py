# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = ['EndpointAccessArgs', 'EndpointAccess']

@pulumi.input_type
class EndpointAccessArgs:
    def __init__(__self__, *,
                 endpoint_name: pulumi.Input[str],
                 vpc_security_group_ids: pulumi.Input[Sequence[pulumi.Input[str]]],
                 cluster_identifier: Optional[pulumi.Input[str]] = None,
                 resource_owner: Optional[pulumi.Input[str]] = None,
                 subnet_group_name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a EndpointAccess resource.
        :param pulumi.Input[str] endpoint_name: The name of the endpoint.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_security_group_ids: A list of vpc security group ids to apply to the created endpoint access.
        :param pulumi.Input[str] cluster_identifier: A unique identifier for the cluster. You use this identifier to refer to the cluster for any subsequent cluster operations such as deleting or modifying. All alphabetical characters must be lower case, no hypens at the end, no two consecutive hyphens. Cluster name should be unique for all clusters within an AWS account
        :param pulumi.Input[str] resource_owner: The AWS account ID of the owner of the cluster.
        :param pulumi.Input[str] subnet_group_name: The subnet group name where Amazon Redshift chooses to deploy the endpoint.
        """
        pulumi.set(__self__, "endpoint_name", endpoint_name)
        pulumi.set(__self__, "vpc_security_group_ids", vpc_security_group_ids)
        if cluster_identifier is not None:
            pulumi.set(__self__, "cluster_identifier", cluster_identifier)
        if resource_owner is not None:
            pulumi.set(__self__, "resource_owner", resource_owner)
        if subnet_group_name is not None:
            pulumi.set(__self__, "subnet_group_name", subnet_group_name)

    @property
    @pulumi.getter(name="endpointName")
    def endpoint_name(self) -> pulumi.Input[str]:
        """
        The name of the endpoint.
        """
        return pulumi.get(self, "endpoint_name")

    @endpoint_name.setter
    def endpoint_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "endpoint_name", value)

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A list of vpc security group ids to apply to the created endpoint access.
        """
        return pulumi.get(self, "vpc_security_group_ids")

    @vpc_security_group_ids.setter
    def vpc_security_group_ids(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "vpc_security_group_ids", value)

    @property
    @pulumi.getter(name="clusterIdentifier")
    def cluster_identifier(self) -> Optional[pulumi.Input[str]]:
        """
        A unique identifier for the cluster. You use this identifier to refer to the cluster for any subsequent cluster operations such as deleting or modifying. All alphabetical characters must be lower case, no hypens at the end, no two consecutive hyphens. Cluster name should be unique for all clusters within an AWS account
        """
        return pulumi.get(self, "cluster_identifier")

    @cluster_identifier.setter
    def cluster_identifier(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_identifier", value)

    @property
    @pulumi.getter(name="resourceOwner")
    def resource_owner(self) -> Optional[pulumi.Input[str]]:
        """
        The AWS account ID of the owner of the cluster.
        """
        return pulumi.get(self, "resource_owner")

    @resource_owner.setter
    def resource_owner(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_owner", value)

    @property
    @pulumi.getter(name="subnetGroupName")
    def subnet_group_name(self) -> Optional[pulumi.Input[str]]:
        """
        The subnet group name where Amazon Redshift chooses to deploy the endpoint.
        """
        return pulumi.get(self, "subnet_group_name")

    @subnet_group_name.setter
    def subnet_group_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subnet_group_name", value)


class EndpointAccess(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_identifier: Optional[pulumi.Input[str]] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 resource_owner: Optional[pulumi.Input[str]] = None,
                 subnet_group_name: Optional[pulumi.Input[str]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Resource schema for a Redshift-managed VPC endpoint.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_identifier: A unique identifier for the cluster. You use this identifier to refer to the cluster for any subsequent cluster operations such as deleting or modifying. All alphabetical characters must be lower case, no hypens at the end, no two consecutive hyphens. Cluster name should be unique for all clusters within an AWS account
        :param pulumi.Input[str] endpoint_name: The name of the endpoint.
        :param pulumi.Input[str] resource_owner: The AWS account ID of the owner of the cluster.
        :param pulumi.Input[str] subnet_group_name: The subnet group name where Amazon Redshift chooses to deploy the endpoint.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_security_group_ids: A list of vpc security group ids to apply to the created endpoint access.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: EndpointAccessArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for a Redshift-managed VPC endpoint.

        :param str resource_name: The name of the resource.
        :param EndpointAccessArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(EndpointAccessArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_identifier: Optional[pulumi.Input[str]] = None,
                 endpoint_name: Optional[pulumi.Input[str]] = None,
                 resource_owner: Optional[pulumi.Input[str]] = None,
                 subnet_group_name: Optional[pulumi.Input[str]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = EndpointAccessArgs.__new__(EndpointAccessArgs)

            __props__.__dict__["cluster_identifier"] = cluster_identifier
            if endpoint_name is None and not opts.urn:
                raise TypeError("Missing required property 'endpoint_name'")
            __props__.__dict__["endpoint_name"] = endpoint_name
            __props__.__dict__["resource_owner"] = resource_owner
            __props__.__dict__["subnet_group_name"] = subnet_group_name
            if vpc_security_group_ids is None and not opts.urn:
                raise TypeError("Missing required property 'vpc_security_group_ids'")
            __props__.__dict__["vpc_security_group_ids"] = vpc_security_group_ids
            __props__.__dict__["address"] = None
            __props__.__dict__["endpoint_create_time"] = None
            __props__.__dict__["endpoint_status"] = None
            __props__.__dict__["port"] = None
            __props__.__dict__["vpc_endpoint"] = None
            __props__.__dict__["vpc_security_groups"] = None
        super(EndpointAccess, __self__).__init__(
            'aws-native:redshift:EndpointAccess',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'EndpointAccess':
        """
        Get an existing EndpointAccess resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = EndpointAccessArgs.__new__(EndpointAccessArgs)

        __props__.__dict__["address"] = None
        __props__.__dict__["cluster_identifier"] = None
        __props__.__dict__["endpoint_create_time"] = None
        __props__.__dict__["endpoint_name"] = None
        __props__.__dict__["endpoint_status"] = None
        __props__.__dict__["port"] = None
        __props__.__dict__["resource_owner"] = None
        __props__.__dict__["subnet_group_name"] = None
        __props__.__dict__["vpc_endpoint"] = None
        __props__.__dict__["vpc_security_group_ids"] = None
        __props__.__dict__["vpc_security_groups"] = None
        return EndpointAccess(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def address(self) -> pulumi.Output[str]:
        """
        The DNS address of the endpoint.
        """
        return pulumi.get(self, "address")

    @property
    @pulumi.getter(name="clusterIdentifier")
    def cluster_identifier(self) -> pulumi.Output[Optional[str]]:
        """
        A unique identifier for the cluster. You use this identifier to refer to the cluster for any subsequent cluster operations such as deleting or modifying. All alphabetical characters must be lower case, no hypens at the end, no two consecutive hyphens. Cluster name should be unique for all clusters within an AWS account
        """
        return pulumi.get(self, "cluster_identifier")

    @property
    @pulumi.getter(name="endpointCreateTime")
    def endpoint_create_time(self) -> pulumi.Output[str]:
        """
        The time (UTC) that the endpoint was created.
        """
        return pulumi.get(self, "endpoint_create_time")

    @property
    @pulumi.getter(name="endpointName")
    def endpoint_name(self) -> pulumi.Output[str]:
        """
        The name of the endpoint.
        """
        return pulumi.get(self, "endpoint_name")

    @property
    @pulumi.getter(name="endpointStatus")
    def endpoint_status(self) -> pulumi.Output[str]:
        """
        The status of the endpoint.
        """
        return pulumi.get(self, "endpoint_status")

    @property
    @pulumi.getter
    def port(self) -> pulumi.Output[int]:
        """
        The port number on which the cluster accepts incoming connections.
        """
        return pulumi.get(self, "port")

    @property
    @pulumi.getter(name="resourceOwner")
    def resource_owner(self) -> pulumi.Output[Optional[str]]:
        """
        The AWS account ID of the owner of the cluster.
        """
        return pulumi.get(self, "resource_owner")

    @property
    @pulumi.getter(name="subnetGroupName")
    def subnet_group_name(self) -> pulumi.Output[Optional[str]]:
        """
        The subnet group name where Amazon Redshift chooses to deploy the endpoint.
        """
        return pulumi.get(self, "subnet_group_name")

    @property
    @pulumi.getter(name="vpcEndpoint")
    def vpc_endpoint(self) -> pulumi.Output['outputs.VpcEndpointProperties']:
        """
        The connection endpoint for connecting to an Amazon Redshift cluster through the proxy.
        """
        return pulumi.get(self, "vpc_endpoint")

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> pulumi.Output[Sequence[str]]:
        """
        A list of vpc security group ids to apply to the created endpoint access.
        """
        return pulumi.get(self, "vpc_security_group_ids")

    @property
    @pulumi.getter(name="vpcSecurityGroups")
    def vpc_security_groups(self) -> pulumi.Output[Sequence['outputs.EndpointAccessVpcSecurityGroup']]:
        """
        A list of Virtual Private Cloud (VPC) security groups to be associated with the endpoint.
        """
        return pulumi.get(self, "vpc_security_groups")
