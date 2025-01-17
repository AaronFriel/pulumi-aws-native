// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const KeySpec = {
    SymmetricDefault: "SYMMETRIC_DEFAULT",
    Rsa2048: "RSA_2048",
    Rsa3072: "RSA_3072",
    Rsa4096: "RSA_4096",
    EccNistP256: "ECC_NIST_P256",
    EccNistP384: "ECC_NIST_P384",
    EccNistP521: "ECC_NIST_P521",
    EccSecgP256k1: "ECC_SECG_P256K1",
} as const;

/**
 * Specifies the type of CMK to create. The default value is SYMMETRIC_DEFAULT. This property is required only for asymmetric CMKs. You can't change the KeySpec value after the CMK is created.
 */
export type KeySpec = (typeof KeySpec)[keyof typeof KeySpec];

export const KeyUsage = {
    EncryptDecrypt: "ENCRYPT_DECRYPT",
    SignVerify: "SIGN_VERIFY",
} as const;

/**
 * Determines the cryptographic operations for which you can use the CMK. The default value is ENCRYPT_DECRYPT. This property is required only for asymmetric CMKs. You can't change the KeyUsage value after the CMK is created.
 */
export type KeyUsage = (typeof KeyUsage)[keyof typeof KeyUsage];
