// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Attestation.Models.Api10
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Extensions;

    public partial class JsonWebKey :
        Microsoft.Azure.PowerShell.Cmdlets.Attestation.Models.Api10.IJsonWebKey,
        Microsoft.Azure.PowerShell.Cmdlets.Attestation.Models.Api10.IJsonWebKeyInternal
    {

        /// <summary>Backing field for <see cref="Alg" /> property.</summary>
        private string _alg;

        /// <summary>
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key. The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Alg { get => this._alg; set => this._alg = value; }

        /// <summary>Backing field for <see cref="Crv" /> property.</summary>
        private string _crv;

        /// <summary>The "crv" (curve) parameter identifies the curve type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Crv { get => this._crv; set => this._crv = value; }

        /// <summary>Backing field for <see cref="D" /> property.</summary>
        private string _d;

        /// <summary>RSA private exponent or ECC private key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string D { get => this._d; set => this._d = value; }

        /// <summary>Backing field for <see cref="Dp" /> property.</summary>
        private string _dp;

        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Dp { get => this._dp; set => this._dp = value; }

        /// <summary>Backing field for <see cref="Dq" /> property.</summary>
        private string _dq;

        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Dq { get => this._dq; set => this._dq = value; }

        /// <summary>Backing field for <see cref="E" /> property.</summary>
        private string _e;

        /// <summary>RSA public exponent, in Base64</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string E { get => this._e; set => this._e = value; }

        /// <summary>Backing field for <see cref="K" /> property.</summary>
        private string _k;

        /// <summary>Symmetric key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string K { get => this._k; set => this._k = value; }

        /// <summary>Backing field for <see cref="Kid" /> property.</summary>
        private string _kid;

        /// <summary>
        /// The "kid" (key ID) parameter is used to match a specific key. This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover. The structure of the "kid" value is
        /// unspecified. When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values. (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.) The "kid"
        /// value is a case-sensitive string.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Kid { get => this._kid; set => this._kid = value; }

        /// <summary>Backing field for <see cref="Kty" /> property.</summary>
        private string _kty;

        /// <summary>
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name. The "kty" value is a case-sensitive string.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Kty { get => this._kty; set => this._kty = value; }

        /// <summary>Backing field for <see cref="N" /> property.</summary>
        private string _n;

        /// <summary>RSA modulus, in Base64</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string N { get => this._n; set => this._n = value; }

        /// <summary>Backing field for <see cref="P" /> property.</summary>
        private string _p;

        /// <summary>RSA secret prime</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string P { get => this._p; set => this._p = value; }

        /// <summary>Backing field for <see cref="Q" /> property.</summary>
        private string _q;

        /// <summary>RSA secret prime, with p < q</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Q { get => this._q; set => this._q = value; }

        /// <summary>Backing field for <see cref="Qi" /> property.</summary>
        private string _qi;

        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Qi { get => this._qi; set => this._qi = value; }

        /// <summary>Backing field for <see cref="Use" /> property.</summary>
        private string _use;

        /// <summary>
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Use { get => this._use; set => this._use = value; }

        /// <summary>Backing field for <see cref="X" /> property.</summary>
        private string _x;

        /// <summary>X coordinate for the Elliptic Curve point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string X { get => this._x; set => this._x = value; }

        /// <summary>Backing field for <see cref="X5C" /> property.</summary>
        private string[] _x5C;

        /// <summary>
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280]. The certificate chain is
        /// represented as a JSON array of certificate value strings. Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string[] X5C { get => this._x5C; set => this._x5C = value; }

        /// <summary>Backing field for <see cref="Y" /> property.</summary>
        private string _y;

        /// <summary>Y coordinate for the Elliptic Curve point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Origin(Microsoft.Azure.PowerShell.Cmdlets.Attestation.PropertyOrigin.Owned)]
        public string Y { get => this._y; set => this._y = value; }

        /// <summary>Creates an new <see cref="JsonWebKey" /> instance.</summary>
        public JsonWebKey()
        {

        }
    }
    public partial interface IJsonWebKey :
        Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key. The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ""alg"" (algorithm) parameter identifies the algorithm intended for
        use with the key.  The values used should either be registered in the
        IANA ""JSON Web Signature and Encryption Algorithms"" registry
        established by [JWA] or be a value that contains a Collision-
        Resistant Name.",
        SerializedName = @"alg",
        PossibleTypes = new [] { typeof(string) })]
        string Alg { get; set; }
        /// <summary>The "crv" (curve) parameter identifies the curve type</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ""crv"" (curve) parameter identifies the curve type",
        SerializedName = @"crv",
        PossibleTypes = new [] { typeof(string) })]
        string Crv { get; set; }
        /// <summary>RSA private exponent or ECC private key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA private exponent or ECC private key",
        SerializedName = @"d",
        PossibleTypes = new [] { typeof(string) })]
        string D { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA Private Key Parameter",
        SerializedName = @"dp",
        PossibleTypes = new [] { typeof(string) })]
        string Dp { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA Private Key Parameter",
        SerializedName = @"dq",
        PossibleTypes = new [] { typeof(string) })]
        string Dq { get; set; }
        /// <summary>RSA public exponent, in Base64</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA public exponent, in Base64",
        SerializedName = @"e",
        PossibleTypes = new [] { typeof(string) })]
        string E { get; set; }
        /// <summary>Symmetric key</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Symmetric key",
        SerializedName = @"k",
        PossibleTypes = new [] { typeof(string) })]
        string K { get; set; }
        /// <summary>
        /// The "kid" (key ID) parameter is used to match a specific key. This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover. The structure of the "kid" value is
        /// unspecified. When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values. (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.) The "kid"
        /// value is a case-sensitive string.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ""kid"" (key ID) parameter is used to match a specific key.  This
        is used, for instance, to choose among a set of keys within a JWK Set
        during key rollover.  The structure of the ""kid"" value is
        unspecified.  When ""kid"" values are used within a JWK Set, different
        keys within the JWK Set SHOULD use distinct ""kid"" values.  (One
        example in which different keys might use the same ""kid"" value is if
        they have different ""kty"" (key type) values but are considered to be
        equivalent alternatives by the application using them.)  The ""kid""
        value is a case-sensitive string.",
        SerializedName = @"kid",
        PossibleTypes = new [] { typeof(string) })]
        string Kid { get; set; }
        /// <summary>
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name. The "kty" value is a case-sensitive string.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The ""kty"" (key type) parameter identifies the cryptographic algorithm
        family used with the key, such as ""RSA"" or ""EC"". ""kty"" values should
        either be registered in the IANA ""JSON Web Key Types"" registry
        established by [JWA] or be a value that contains a Collision-
        Resistant Name.  The ""kty"" value is a case-sensitive string.",
        SerializedName = @"kty",
        PossibleTypes = new [] { typeof(string) })]
        string Kty { get; set; }
        /// <summary>RSA modulus, in Base64</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA modulus, in Base64",
        SerializedName = @"n",
        PossibleTypes = new [] { typeof(string) })]
        string N { get; set; }
        /// <summary>RSA secret prime</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA secret prime",
        SerializedName = @"p",
        PossibleTypes = new [] { typeof(string) })]
        string P { get; set; }
        /// <summary>RSA secret prime, with p < q</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA secret prime, with p < q",
        SerializedName = @"q",
        PossibleTypes = new [] { typeof(string) })]
        string Q { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"RSA Private Key Parameter",
        SerializedName = @"qi",
        PossibleTypes = new [] { typeof(string) })]
        string Qi { get; set; }
        /// <summary>
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Use (""public key use"") identifies the intended use of
        the public key. The ""use"" parameter is employed to indicate whether
        a public key is used for encrypting data or verifying the signature
        on data. Values are commonly ""sig"" (signature) or ""enc"" (encryption).",
        SerializedName = @"use",
        PossibleTypes = new [] { typeof(string) })]
        string Use { get; set; }
        /// <summary>X coordinate for the Elliptic Curve point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"X coordinate for the Elliptic Curve point",
        SerializedName = @"x",
        PossibleTypes = new [] { typeof(string) })]
        string X { get; set; }
        /// <summary>
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280]. The certificate chain is
        /// represented as a JSON array of certificate value strings. Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The ""x5c"" (X.509 certificate chain) parameter contains a chain of one
        or more PKIX certificates [RFC5280].  The certificate chain is
        represented as a JSON array of certificate value strings.  Each
        string in the array is a base64-encoded (Section 4 of [RFC4648] --
        not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        The PKIX certificate containing the key value MUST be the first
        certificate.",
        SerializedName = @"x5c",
        PossibleTypes = new [] { typeof(string) })]
        string[] X5C { get; set; }
        /// <summary>Y coordinate for the Elliptic Curve point</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Attestation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Y coordinate for the Elliptic Curve point",
        SerializedName = @"y",
        PossibleTypes = new [] { typeof(string) })]
        string Y { get; set; }

    }
    internal partial interface IJsonWebKeyInternal

    {
        /// <summary>
        /// The "alg" (algorithm) parameter identifies the algorithm intended for
        /// use with the key. The values used should either be registered in the
        /// IANA "JSON Web Signature and Encryption Algorithms" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name.
        /// </summary>
        string Alg { get; set; }
        /// <summary>The "crv" (curve) parameter identifies the curve type</summary>
        string Crv { get; set; }
        /// <summary>RSA private exponent or ECC private key</summary>
        string D { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        string Dp { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        string Dq { get; set; }
        /// <summary>RSA public exponent, in Base64</summary>
        string E { get; set; }
        /// <summary>Symmetric key</summary>
        string K { get; set; }
        /// <summary>
        /// The "kid" (key ID) parameter is used to match a specific key. This
        /// is used, for instance, to choose among a set of keys within a JWK Set
        /// during key rollover. The structure of the "kid" value is
        /// unspecified. When "kid" values are used within a JWK Set, different
        /// keys within the JWK Set SHOULD use distinct "kid" values. (One
        /// example in which different keys might use the same "kid" value is if
        /// they have different "kty" (key type) values but are considered to be
        /// equivalent alternatives by the application using them.) The "kid"
        /// value is a case-sensitive string.
        /// </summary>
        string Kid { get; set; }
        /// <summary>
        /// The "kty" (key type) parameter identifies the cryptographic algorithm
        /// family used with the key, such as "RSA" or "EC". "kty" values should
        /// either be registered in the IANA "JSON Web Key Types" registry
        /// established by [JWA] or be a value that contains a Collision-
        /// Resistant Name. The "kty" value is a case-sensitive string.
        /// </summary>
        string Kty { get; set; }
        /// <summary>RSA modulus, in Base64</summary>
        string N { get; set; }
        /// <summary>RSA secret prime</summary>
        string P { get; set; }
        /// <summary>RSA secret prime, with p < q</summary>
        string Q { get; set; }
        /// <summary>RSA Private Key Parameter</summary>
        string Qi { get; set; }
        /// <summary>
        /// Use ("public key use") identifies the intended use of
        /// the public key. The "use" parameter is employed to indicate whether
        /// a public key is used for encrypting data or verifying the signature
        /// on data. Values are commonly "sig" (signature) or "enc" (encryption).
        /// </summary>
        string Use { get; set; }
        /// <summary>X coordinate for the Elliptic Curve point</summary>
        string X { get; set; }
        /// <summary>
        /// The "x5c" (X.509 certificate chain) parameter contains a chain of one
        /// or more PKIX certificates [RFC5280]. The certificate chain is
        /// represented as a JSON array of certificate value strings. Each
        /// string in the array is a base64-encoded (Section 4 of [RFC4648] --
        /// not base64url-encoded) DER [ITU.X690.1994] PKIX certificate value.
        /// The PKIX certificate containing the key value MUST be the first
        /// certificate.
        /// </summary>
        string[] X5C { get; set; }
        /// <summary>Y coordinate for the Elliptic Curve point</summary>
        string Y { get; set; }

    }
}