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

__all__ = ['TemplateArgs', 'Template']

@pulumi.input_type
class TemplateArgs:
    def __init__(__self__, *,
                 aws_account_id: pulumi.Input[str],
                 source_entity: pulumi.Input['TemplateSourceEntityArgs'],
                 template_id: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateResourcePermissionArgs']]]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateTagArgs']]]] = None,
                 version_description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Template resource.
        :param pulumi.Input[str] name: <p>A display name for the template.</p>
        :param pulumi.Input[Sequence[pulumi.Input['TemplateResourcePermissionArgs']]] permissions: <p>A list of resource permissions to be set on the template. </p>
        :param pulumi.Input[Sequence[pulumi.Input['TemplateTagArgs']]] tags: <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the resource.</p>
        :param pulumi.Input[str] version_description: <p>A description of the current template version being created. This API operation creates the
               			first version of the template. Every time <code>UpdateTemplate</code> is called, a new
               			version is created. Each version of the template maintains a description of the version
               			in the <code>VersionDescription</code> field.</p>
        """
        pulumi.set(__self__, "aws_account_id", aws_account_id)
        pulumi.set(__self__, "source_entity", source_entity)
        pulumi.set(__self__, "template_id", template_id)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if permissions is not None:
            pulumi.set(__self__, "permissions", permissions)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if version_description is not None:
            pulumi.set(__self__, "version_description", version_description)

    @property
    @pulumi.getter(name="awsAccountId")
    def aws_account_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "aws_account_id")

    @aws_account_id.setter
    def aws_account_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "aws_account_id", value)

    @property
    @pulumi.getter(name="sourceEntity")
    def source_entity(self) -> pulumi.Input['TemplateSourceEntityArgs']:
        return pulumi.get(self, "source_entity")

    @source_entity.setter
    def source_entity(self, value: pulumi.Input['TemplateSourceEntityArgs']):
        pulumi.set(self, "source_entity", value)

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "template_id")

    @template_id.setter
    def template_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "template_id", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        <p>A display name for the template.</p>
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def permissions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateResourcePermissionArgs']]]]:
        """
        <p>A list of resource permissions to be set on the template. </p>
        """
        return pulumi.get(self, "permissions")

    @permissions.setter
    def permissions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateResourcePermissionArgs']]]]):
        pulumi.set(self, "permissions", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['TemplateTagArgs']]]]:
        """
        <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the resource.</p>
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['TemplateTagArgs']]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="versionDescription")
    def version_description(self) -> Optional[pulumi.Input[str]]:
        """
        <p>A description of the current template version being created. This API operation creates the
        			first version of the template. Every time <code>UpdateTemplate</code> is called, a new
        			version is created. Each version of the template maintains a description of the version
        			in the <code>VersionDescription</code> field.</p>
        """
        return pulumi.get(self, "version_description")

    @version_description.setter
    def version_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version_description", value)


class Template(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aws_account_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateResourcePermissionArgs']]]]] = None,
                 source_entity: Optional[pulumi.Input[pulumi.InputType['TemplateSourceEntityArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateTagArgs']]]]] = None,
                 template_id: Optional[pulumi.Input[str]] = None,
                 version_description: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Definition of the AWS::QuickSight::Template Resource Type.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: <p>A display name for the template.</p>
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateResourcePermissionArgs']]]] permissions: <p>A list of resource permissions to be set on the template. </p>
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateTagArgs']]]] tags: <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the resource.</p>
        :param pulumi.Input[str] version_description: <p>A description of the current template version being created. This API operation creates the
               			first version of the template. Every time <code>UpdateTemplate</code> is called, a new
               			version is created. Each version of the template maintains a description of the version
               			in the <code>VersionDescription</code> field.</p>
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: TemplateArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Definition of the AWS::QuickSight::Template Resource Type.

        :param str resource_name: The name of the resource.
        :param TemplateArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(TemplateArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 aws_account_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 permissions: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateResourcePermissionArgs']]]]] = None,
                 source_entity: Optional[pulumi.Input[pulumi.InputType['TemplateSourceEntityArgs']]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['TemplateTagArgs']]]]] = None,
                 template_id: Optional[pulumi.Input[str]] = None,
                 version_description: Optional[pulumi.Input[str]] = None,
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
            __props__ = TemplateArgs.__new__(TemplateArgs)

            if aws_account_id is None and not opts.urn:
                raise TypeError("Missing required property 'aws_account_id'")
            __props__.__dict__["aws_account_id"] = aws_account_id
            __props__.__dict__["name"] = name
            __props__.__dict__["permissions"] = permissions
            if source_entity is None and not opts.urn:
                raise TypeError("Missing required property 'source_entity'")
            __props__.__dict__["source_entity"] = source_entity
            __props__.__dict__["tags"] = tags
            if template_id is None and not opts.urn:
                raise TypeError("Missing required property 'template_id'")
            __props__.__dict__["template_id"] = template_id
            __props__.__dict__["version_description"] = version_description
            __props__.__dict__["arn"] = None
            __props__.__dict__["created_time"] = None
            __props__.__dict__["last_updated_time"] = None
            __props__.__dict__["version"] = None
        super(Template, __self__).__init__(
            'aws-native:quicksight:Template',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Template':
        """
        Get an existing Template resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = TemplateArgs.__new__(TemplateArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["aws_account_id"] = None
        __props__.__dict__["created_time"] = None
        __props__.__dict__["last_updated_time"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["permissions"] = None
        __props__.__dict__["source_entity"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["template_id"] = None
        __props__.__dict__["version"] = None
        __props__.__dict__["version_description"] = None
        return Template(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        """
        <p>The Amazon Resource Name (ARN) of the template.</p>
        """
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter(name="awsAccountId")
    def aws_account_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "aws_account_id")

    @property
    @pulumi.getter(name="createdTime")
    def created_time(self) -> pulumi.Output[str]:
        """
        <p>Time when this was created.</p>
        """
        return pulumi.get(self, "created_time")

    @property
    @pulumi.getter(name="lastUpdatedTime")
    def last_updated_time(self) -> pulumi.Output[str]:
        """
        <p>Time when this was last updated.</p>
        """
        return pulumi.get(self, "last_updated_time")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        <p>A display name for the template.</p>
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def permissions(self) -> pulumi.Output[Optional[Sequence['outputs.TemplateResourcePermission']]]:
        """
        <p>A list of resource permissions to be set on the template. </p>
        """
        return pulumi.get(self, "permissions")

    @property
    @pulumi.getter(name="sourceEntity")
    def source_entity(self) -> pulumi.Output['outputs.TemplateSourceEntity']:
        return pulumi.get(self, "source_entity")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.TemplateTag']]]:
        """
        <p>Contains a map of the key-value pairs for the resource tag or tags assigned to the resource.</p>
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="templateId")
    def template_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "template_id")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output['outputs.TemplateVersion']:
        return pulumi.get(self, "version")

    @property
    @pulumi.getter(name="versionDescription")
    def version_description(self) -> pulumi.Output[Optional[str]]:
        """
        <p>A description of the current template version being created. This API operation creates the
        			first version of the template. Every time <code>UpdateTemplate</code> is called, a new
        			version is created. Each version of the template maintains a description of the version
        			in the <code>VersionDescription</code> field.</p>
        """
        return pulumi.get(self, "version_description")

