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
from ._inputs import *

__all__ = ['DBProxyArgs', 'DBProxy']

@pulumi.input_type
class DBProxyArgs:
    def __init__(__self__, *,
                 auth: pulumi.Input[Sequence[pulumi.Input['DBProxyAuthFormatArgs']]],
                 engine_family: pulumi.Input['DBProxyEngineFamily'],
                 role_arn: pulumi.Input[str],
                 vpc_subnet_ids: pulumi.Input[Sequence[pulumi.Input[str]]],
                 d_b_proxy_name: Optional[pulumi.Input[str]] = None,
                 debug_logging: Optional[pulumi.Input[bool]] = None,
                 idle_client_timeout: Optional[pulumi.Input[int]] = None,
                 require_tls: Optional[pulumi.Input[bool]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['DBProxyTagFormatArgs']]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        The set of arguments for constructing a DBProxy resource.
        :param pulumi.Input[Sequence[pulumi.Input['DBProxyAuthFormatArgs']]] auth: The authorization mechanism that the proxy uses.
        :param pulumi.Input['DBProxyEngineFamily'] engine_family: The kinds of databases that the proxy can connect to.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets in AWS Secrets Manager.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_subnet_ids: VPC subnet IDs to associate with the new proxy.
        :param pulumi.Input[str] d_b_proxy_name: The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
        :param pulumi.Input[bool] debug_logging: Whether the proxy includes detailed information about SQL statements in its logs.
        :param pulumi.Input[int] idle_client_timeout: The number of seconds that a connection to the proxy can be inactive before the proxy disconnects it.
        :param pulumi.Input[bool] require_tls: A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption is required for connections to the proxy.
        :param pulumi.Input[Sequence[pulumi.Input['DBProxyTagFormatArgs']]] tags: An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_security_group_ids: VPC security group IDs to associate with the new proxy.
        """
        pulumi.set(__self__, "auth", auth)
        pulumi.set(__self__, "engine_family", engine_family)
        pulumi.set(__self__, "role_arn", role_arn)
        pulumi.set(__self__, "vpc_subnet_ids", vpc_subnet_ids)
        if d_b_proxy_name is not None:
            pulumi.set(__self__, "d_b_proxy_name", d_b_proxy_name)
        if debug_logging is not None:
            pulumi.set(__self__, "debug_logging", debug_logging)
        if idle_client_timeout is not None:
            pulumi.set(__self__, "idle_client_timeout", idle_client_timeout)
        if require_tls is not None:
            pulumi.set(__self__, "require_tls", require_tls)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if vpc_security_group_ids is not None:
            pulumi.set(__self__, "vpc_security_group_ids", vpc_security_group_ids)

    @property
    @pulumi.getter
    def auth(self) -> pulumi.Input[Sequence[pulumi.Input['DBProxyAuthFormatArgs']]]:
        """
        The authorization mechanism that the proxy uses.
        """
        return pulumi.get(self, "auth")

    @auth.setter
    def auth(self, value: pulumi.Input[Sequence[pulumi.Input['DBProxyAuthFormatArgs']]]):
        pulumi.set(self, "auth", value)

    @property
    @pulumi.getter(name="engineFamily")
    def engine_family(self) -> pulumi.Input['DBProxyEngineFamily']:
        """
        The kinds of databases that the proxy can connect to.
        """
        return pulumi.get(self, "engine_family")

    @engine_family.setter
    def engine_family(self, value: pulumi.Input['DBProxyEngineFamily']):
        pulumi.set(self, "engine_family", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Input[str]:
        """
        The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets in AWS Secrets Manager.
        """
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter(name="vpcSubnetIds")
    def vpc_subnet_ids(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        VPC subnet IDs to associate with the new proxy.
        """
        return pulumi.get(self, "vpc_subnet_ids")

    @vpc_subnet_ids.setter
    def vpc_subnet_ids(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "vpc_subnet_ids", value)

    @property
    @pulumi.getter(name="dBProxyName")
    def d_b_proxy_name(self) -> Optional[pulumi.Input[str]]:
        """
        The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
        """
        return pulumi.get(self, "d_b_proxy_name")

    @d_b_proxy_name.setter
    def d_b_proxy_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "d_b_proxy_name", value)

    @property
    @pulumi.getter(name="debugLogging")
    def debug_logging(self) -> Optional[pulumi.Input[bool]]:
        """
        Whether the proxy includes detailed information about SQL statements in its logs.
        """
        return pulumi.get(self, "debug_logging")

    @debug_logging.setter
    def debug_logging(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "debug_logging", value)

    @property
    @pulumi.getter(name="idleClientTimeout")
    def idle_client_timeout(self) -> Optional[pulumi.Input[int]]:
        """
        The number of seconds that a connection to the proxy can be inactive before the proxy disconnects it.
        """
        return pulumi.get(self, "idle_client_timeout")

    @idle_client_timeout.setter
    def idle_client_timeout(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "idle_client_timeout", value)

    @property
    @pulumi.getter(name="requireTLS")
    def require_tls(self) -> Optional[pulumi.Input[bool]]:
        """
        A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption is required for connections to the proxy.
        """
        return pulumi.get(self, "require_tls")

    @require_tls.setter
    def require_tls(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "require_tls", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DBProxyTagFormatArgs']]]]:
        """
        An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DBProxyTagFormatArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        VPC security group IDs to associate with the new proxy.
        """
        return pulumi.get(self, "vpc_security_group_ids")

    @vpc_security_group_ids.setter
    def vpc_security_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "vpc_security_group_ids", value)


class DBProxy(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyAuthFormatArgs']]]]] = None,
                 d_b_proxy_name: Optional[pulumi.Input[str]] = None,
                 debug_logging: Optional[pulumi.Input[bool]] = None,
                 engine_family: Optional[pulumi.Input['DBProxyEngineFamily']] = None,
                 idle_client_timeout: Optional[pulumi.Input[int]] = None,
                 require_tls: Optional[pulumi.Input[bool]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyTagFormatArgs']]]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_subnet_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 __props__=None):
        """
        Resource schema for AWS::RDS::DBProxy

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyAuthFormatArgs']]]] auth: The authorization mechanism that the proxy uses.
        :param pulumi.Input[str] d_b_proxy_name: The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
        :param pulumi.Input[bool] debug_logging: Whether the proxy includes detailed information about SQL statements in its logs.
        :param pulumi.Input['DBProxyEngineFamily'] engine_family: The kinds of databases that the proxy can connect to.
        :param pulumi.Input[int] idle_client_timeout: The number of seconds that a connection to the proxy can be inactive before the proxy disconnects it.
        :param pulumi.Input[bool] require_tls: A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption is required for connections to the proxy.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets in AWS Secrets Manager.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyTagFormatArgs']]]] tags: An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_security_group_ids: VPC security group IDs to associate with the new proxy.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] vpc_subnet_ids: VPC subnet IDs to associate with the new proxy.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DBProxyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource schema for AWS::RDS::DBProxy

        :param str resource_name: The name of the resource.
        :param DBProxyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DBProxyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 auth: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyAuthFormatArgs']]]]] = None,
                 d_b_proxy_name: Optional[pulumi.Input[str]] = None,
                 debug_logging: Optional[pulumi.Input[bool]] = None,
                 engine_family: Optional[pulumi.Input['DBProxyEngineFamily']] = None,
                 idle_client_timeout: Optional[pulumi.Input[int]] = None,
                 require_tls: Optional[pulumi.Input[bool]] = None,
                 role_arn: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['DBProxyTagFormatArgs']]]]] = None,
                 vpc_security_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 vpc_subnet_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
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
            __props__ = DBProxyArgs.__new__(DBProxyArgs)

            if auth is None and not opts.urn:
                raise TypeError("Missing required property 'auth'")
            __props__.__dict__["auth"] = auth
            __props__.__dict__["d_b_proxy_name"] = d_b_proxy_name
            __props__.__dict__["debug_logging"] = debug_logging
            if engine_family is None and not opts.urn:
                raise TypeError("Missing required property 'engine_family'")
            __props__.__dict__["engine_family"] = engine_family
            __props__.__dict__["idle_client_timeout"] = idle_client_timeout
            __props__.__dict__["require_tls"] = require_tls
            if role_arn is None and not opts.urn:
                raise TypeError("Missing required property 'role_arn'")
            __props__.__dict__["role_arn"] = role_arn
            __props__.__dict__["tags"] = tags
            __props__.__dict__["vpc_security_group_ids"] = vpc_security_group_ids
            if vpc_subnet_ids is None and not opts.urn:
                raise TypeError("Missing required property 'vpc_subnet_ids'")
            __props__.__dict__["vpc_subnet_ids"] = vpc_subnet_ids
            __props__.__dict__["d_b_proxy_arn"] = None
            __props__.__dict__["endpoint"] = None
            __props__.__dict__["vpc_id"] = None
        super(DBProxy, __self__).__init__(
            'aws-native:rds:DBProxy',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'DBProxy':
        """
        Get an existing DBProxy resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = DBProxyArgs.__new__(DBProxyArgs)

        __props__.__dict__["auth"] = None
        __props__.__dict__["d_b_proxy_arn"] = None
        __props__.__dict__["d_b_proxy_name"] = None
        __props__.__dict__["debug_logging"] = None
        __props__.__dict__["endpoint"] = None
        __props__.__dict__["engine_family"] = None
        __props__.__dict__["idle_client_timeout"] = None
        __props__.__dict__["require_tls"] = None
        __props__.__dict__["role_arn"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["vpc_id"] = None
        __props__.__dict__["vpc_security_group_ids"] = None
        __props__.__dict__["vpc_subnet_ids"] = None
        return DBProxy(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def auth(self) -> pulumi.Output[Sequence['outputs.DBProxyAuthFormat']]:
        """
        The authorization mechanism that the proxy uses.
        """
        return pulumi.get(self, "auth")

    @property
    @pulumi.getter(name="dBProxyArn")
    def d_b_proxy_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) for the proxy.
        """
        return pulumi.get(self, "d_b_proxy_arn")

    @property
    @pulumi.getter(name="dBProxyName")
    def d_b_proxy_name(self) -> pulumi.Output[str]:
        """
        The identifier for the proxy. This name must be unique for all proxies owned by your AWS account in the specified AWS Region.
        """
        return pulumi.get(self, "d_b_proxy_name")

    @property
    @pulumi.getter(name="debugLogging")
    def debug_logging(self) -> pulumi.Output[Optional[bool]]:
        """
        Whether the proxy includes detailed information about SQL statements in its logs.
        """
        return pulumi.get(self, "debug_logging")

    @property
    @pulumi.getter
    def endpoint(self) -> pulumi.Output[str]:
        """
        The endpoint that you can use to connect to the proxy. You include the endpoint value in the connection string for a database client application.
        """
        return pulumi.get(self, "endpoint")

    @property
    @pulumi.getter(name="engineFamily")
    def engine_family(self) -> pulumi.Output['DBProxyEngineFamily']:
        """
        The kinds of databases that the proxy can connect to.
        """
        return pulumi.get(self, "engine_family")

    @property
    @pulumi.getter(name="idleClientTimeout")
    def idle_client_timeout(self) -> pulumi.Output[Optional[int]]:
        """
        The number of seconds that a connection to the proxy can be inactive before the proxy disconnects it.
        """
        return pulumi.get(self, "idle_client_timeout")

    @property
    @pulumi.getter(name="requireTLS")
    def require_tls(self) -> pulumi.Output[Optional[bool]]:
        """
        A Boolean parameter that specifies whether Transport Layer Security (TLS) encryption is required for connections to the proxy.
        """
        return pulumi.get(self, "require_tls")

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the IAM role that the proxy uses to access secrets in AWS Secrets Manager.
        """
        return pulumi.get(self, "role_arn")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.DBProxyTagFormat']]]:
        """
        An optional set of key-value pairs to associate arbitrary data of your choosing with the proxy.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> pulumi.Output[str]:
        """
        VPC ID to associate with the new DB proxy.
        """
        return pulumi.get(self, "vpc_id")

    @property
    @pulumi.getter(name="vpcSecurityGroupIds")
    def vpc_security_group_ids(self) -> pulumi.Output[Optional[Sequence[str]]]:
        """
        VPC security group IDs to associate with the new proxy.
        """
        return pulumi.get(self, "vpc_security_group_ids")

    @property
    @pulumi.getter(name="vpcSubnetIds")
    def vpc_subnet_ids(self) -> pulumi.Output[Sequence[str]]:
        """
        VPC subnet IDs to associate with the new proxy.
        """
        return pulumi.get(self, "vpc_subnet_ids")

