// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getUrlSuffix(opts?: pulumi.InvokeOptions): Promise<GetUrlSuffixResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("cloudformation:index:getUrlSuffix", {
    }, opts);
}

export interface GetUrlSuffixResult {
    readonly urlSuffix: string;
}
