# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['RepositoryAssociationArgs', 'RepositoryAssociation']

@pulumi.input_type
class RepositoryAssociationArgs:
    def __init__(__self__, *,
                 name: pulumi.Input[str],
                 type: pulumi.Input[str],
                 bucket_name: Optional[pulumi.Input[str]] = None,
                 connection_arn: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['RepositoryAssociationTagArgs']]]] = None):
        """
        The set of arguments for constructing a RepositoryAssociation resource.
        :param pulumi.Input[str] name: Name of the repository to be associated.
        :param pulumi.Input[str] type: The type of repository to be associated.
        :param pulumi.Input[str] bucket_name: The name of the S3 bucket associated with an associated S3 repository. It must start with `codeguru-reviewer-`.
        :param pulumi.Input[str] connection_arn: The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection.
        :param pulumi.Input[str] owner: The owner of the repository. For a Bitbucket repository, this is the username for the account that owns the repository.
        :param pulumi.Input[Sequence[pulumi.Input['RepositoryAssociationTagArgs']]] tags: The tags associated with a repository association.
        """
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "type", type)
        if bucket_name is not None:
            pulumi.set(__self__, "bucket_name", bucket_name)
        if connection_arn is not None:
            pulumi.set(__self__, "connection_arn", connection_arn)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        """
        Name of the repository to be associated.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input[str]:
        """
        The type of repository to be associated.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input[str]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the S3 bucket associated with an associated S3 repository. It must start with `codeguru-reviewer-`.
        """
        return pulumi.get(self, "bucket_name")

    @bucket_name.setter
    def bucket_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "bucket_name", value)

    @property
    @pulumi.getter(name="connectionArn")
    def connection_arn(self) -> Optional[pulumi.Input[str]]:
        """
        The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection.
        """
        return pulumi.get(self, "connection_arn")

    @connection_arn.setter
    def connection_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_arn", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[str]]:
        """
        The owner of the repository. For a Bitbucket repository, this is the username for the account that owns the repository.
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['RepositoryAssociationTagArgs']]]]:
        """
        The tags associated with a repository association.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['RepositoryAssociationTagArgs']]]]):
        pulumi.set(self, "tags", value)


class RepositoryAssociation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket_name: Optional[pulumi.Input[str]] = None,
                 connection_arn: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RepositoryAssociationTagArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        This resource schema represents the RepositoryAssociation resource in the Amazon CodeGuru Reviewer service.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] bucket_name: The name of the S3 bucket associated with an associated S3 repository. It must start with `codeguru-reviewer-`.
        :param pulumi.Input[str] connection_arn: The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection.
        :param pulumi.Input[str] name: Name of the repository to be associated.
        :param pulumi.Input[str] owner: The owner of the repository. For a Bitbucket repository, this is the username for the account that owns the repository.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RepositoryAssociationTagArgs']]]] tags: The tags associated with a repository association.
        :param pulumi.Input[str] type: The type of repository to be associated.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: RepositoryAssociationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource schema represents the RepositoryAssociation resource in the Amazon CodeGuru Reviewer service.

        :param str resource_name: The name of the resource.
        :param RepositoryAssociationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(RepositoryAssociationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 bucket_name: Optional[pulumi.Input[str]] = None,
                 connection_arn: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['RepositoryAssociationTagArgs']]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
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
            __props__ = RepositoryAssociationArgs.__new__(RepositoryAssociationArgs)

            __props__.__dict__["bucket_name"] = bucket_name
            __props__.__dict__["connection_arn"] = connection_arn
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
            __props__.__dict__["owner"] = owner
            __props__.__dict__["tags"] = tags
            if type is None and not opts.urn:
                raise TypeError("Missing required property 'type'")
            __props__.__dict__["type"] = type
            __props__.__dict__["association_arn"] = None
        super(RepositoryAssociation, __self__).__init__(
            'aws-native:codegurureviewer:RepositoryAssociation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'RepositoryAssociation':
        """
        Get an existing RepositoryAssociation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = RepositoryAssociationArgs.__new__(RepositoryAssociationArgs)

        __props__.__dict__["association_arn"] = None
        __props__.__dict__["bucket_name"] = None
        __props__.__dict__["connection_arn"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["owner"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["type"] = None
        return RepositoryAssociation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="associationArn")
    def association_arn(self) -> pulumi.Output[str]:
        """
        The Amazon Resource Name (ARN) of the repository association.
        """
        return pulumi.get(self, "association_arn")

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the S3 bucket associated with an associated S3 repository. It must start with `codeguru-reviewer-`.
        """
        return pulumi.get(self, "bucket_name")

    @property
    @pulumi.getter(name="connectionArn")
    def connection_arn(self) -> pulumi.Output[Optional[str]]:
        """
        The Amazon Resource Name (ARN) of an AWS CodeStar Connections connection.
        """
        return pulumi.get(self, "connection_arn")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Name of the repository to be associated.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[Optional[str]]:
        """
        The owner of the repository. For a Bitbucket repository, this is the username for the account that owns the repository.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.RepositoryAssociationTag']]]:
        """
        The tags associated with a repository association.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        The type of repository to be associated.
        """
        return pulumi.get(self, "type")

