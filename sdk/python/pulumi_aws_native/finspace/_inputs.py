# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'EnvironmentFederationParametersArgs',
]

@pulumi.input_type
class EnvironmentFederationParametersArgs:
    def __init__(__self__, *,
                 application_call_back_url: Optional[pulumi.Input[str]] = None,
                 attribute_map: Optional[Any] = None,
                 federation_provider_name: Optional[pulumi.Input[str]] = None,
                 federation_urn: Optional[pulumi.Input[str]] = None,
                 saml_metadata_document: Optional[pulumi.Input[str]] = None,
                 saml_metadata_url: Optional[pulumi.Input[str]] = None):
        """
        Additional parameters to identify Federation mode
        :param pulumi.Input[str] application_call_back_url: SAML metadata URL to link with the Environment
        :param Any attribute_map: Attribute map for SAML configuration
        :param pulumi.Input[str] federation_provider_name: Federation provider name to link with the Environment
        :param pulumi.Input[str] federation_urn: SAML metadata URL to link with the Environment
        :param pulumi.Input[str] saml_metadata_document: SAML metadata document to link the federation provider to the Environment
        :param pulumi.Input[str] saml_metadata_url: SAML metadata URL to link with the Environment
        """
        if application_call_back_url is not None:
            pulumi.set(__self__, "application_call_back_url", application_call_back_url)
        if attribute_map is not None:
            pulumi.set(__self__, "attribute_map", attribute_map)
        if federation_provider_name is not None:
            pulumi.set(__self__, "federation_provider_name", federation_provider_name)
        if federation_urn is not None:
            pulumi.set(__self__, "federation_urn", federation_urn)
        if saml_metadata_document is not None:
            pulumi.set(__self__, "saml_metadata_document", saml_metadata_document)
        if saml_metadata_url is not None:
            pulumi.set(__self__, "saml_metadata_url", saml_metadata_url)

    @property
    @pulumi.getter(name="applicationCallBackURL")
    def application_call_back_url(self) -> Optional[pulumi.Input[str]]:
        """
        SAML metadata URL to link with the Environment
        """
        return pulumi.get(self, "application_call_back_url")

    @application_call_back_url.setter
    def application_call_back_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "application_call_back_url", value)

    @property
    @pulumi.getter(name="attributeMap")
    def attribute_map(self) -> Optional[Any]:
        """
        Attribute map for SAML configuration
        """
        return pulumi.get(self, "attribute_map")

    @attribute_map.setter
    def attribute_map(self, value: Optional[Any]):
        pulumi.set(self, "attribute_map", value)

    @property
    @pulumi.getter(name="federationProviderName")
    def federation_provider_name(self) -> Optional[pulumi.Input[str]]:
        """
        Federation provider name to link with the Environment
        """
        return pulumi.get(self, "federation_provider_name")

    @federation_provider_name.setter
    def federation_provider_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "federation_provider_name", value)

    @property
    @pulumi.getter(name="federationURN")
    def federation_urn(self) -> Optional[pulumi.Input[str]]:
        """
        SAML metadata URL to link with the Environment
        """
        return pulumi.get(self, "federation_urn")

    @federation_urn.setter
    def federation_urn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "federation_urn", value)

    @property
    @pulumi.getter(name="samlMetadataDocument")
    def saml_metadata_document(self) -> Optional[pulumi.Input[str]]:
        """
        SAML metadata document to link the federation provider to the Environment
        """
        return pulumi.get(self, "saml_metadata_document")

    @saml_metadata_document.setter
    def saml_metadata_document(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "saml_metadata_document", value)

    @property
    @pulumi.getter(name="samlMetadataURL")
    def saml_metadata_url(self) -> Optional[pulumi.Input[str]]:
        """
        SAML metadata URL to link with the Environment
        """
        return pulumi.get(self, "saml_metadata_url")

    @saml_metadata_url.setter
    def saml_metadata_url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "saml_metadata_url", value)


