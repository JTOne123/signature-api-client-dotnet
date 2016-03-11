﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class error {
    
    private string errorcodeField;
    
    private string errormessageField;
    
    private string errortypeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("error-code")]
    public string errorcode {
        get {
            return this.errorcodeField;
        }
        set {
            this.errorcodeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("error-message")]
    public string errormessage {
        get {
            return this.errormessageField;
        }
        set {
            this.errormessageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("error-type")]
    public string errortype {
        get {
            return this.errortypeField;
        }
        set {
            this.errortypeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class signature {
    
    private signaturestatus statusField;
    
    private string personalidentificationnumberField;
    
    private string xadesurlField;
    
    /// <remarks/>
    public signaturestatus status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("personal-identification-number")]
    public string personalidentificationnumber {
        get {
            return this.personalidentificationnumberField;
        }
        set {
            this.personalidentificationnumberField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("xades-url")]
    public string xadesurl {
        get {
            return this.xadesurlField;
        }
        set {
            this.xadesurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="signature-status", Namespace="http://signering.posten.no/schema/v1")]
public enum signaturestatus {
    
    /// <remarks/>
    WAITING,
    
    /// <remarks/>
    REJECTED,
    
    /// <remarks/>
    CANCELLED,
    
    /// <remarks/>
    EXPIRED,
    
    /// <remarks/>
    SIGNED,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class signatures {
    
    private signature[] signatureField;
    
    private string padesurlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature")]
    public signature[] signature {
        get {
            return this.signatureField;
        }
        set {
            this.signatureField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pades-url")]
    public string padesurl {
        get {
            return this.padesurlField;
        }
        set {
            this.padesurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class availability {
    
    private System.DateTime activationtimeField;
    
    private bool activationtimeFieldSpecified;
    
    private long availablesecondsField;
    
    private bool availablesecondsFieldSpecified;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("activation-time")]
    public System.DateTime activationtime {
        get {
            return this.activationtimeField;
        }
        set {
            this.activationtimeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool activationtimeSpecified {
        get {
            return this.activationtimeFieldSpecified;
        }
        set {
            this.activationtimeFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("available-seconds")]
    public long availableseconds {
        get {
            return this.availablesecondsField;
        }
        set {
            this.availablesecondsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool availablesecondsSpecified {
        get {
            return this.availablesecondsFieldSpecified;
        }
        set {
            this.availablesecondsFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class document {
    
    private string titleField;
    
    private string descriptionField;
    
    private string hrefField;
    
    private string mimeField;
    
    /// <remarks/>
    public string title {
        get {
            return this.titleField;
        }
        set {
            this.titleField = value;
        }
    }
    
    /// <remarks/>
    public string description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string href {
        get {
            return this.hrefField;
        }
        set {
            this.hrefField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string mime {
        get {
            return this.mimeField;
        }
        set {
            this.mimeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class sender {
    
    private string organizationnumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("organization-number")]
    public string organizationnumber {
        get {
            return this.organizationnumberField;
        }
        set {
            this.organizationnumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://signering.posten.no/schema/v1")]
public partial class signer {
    
    private string personalidentificationnumberField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("personal-identification-number")]
    public string personalidentificationnumber {
        get {
            return this.personalidentificationnumberField;
        }
        set {
            this.personalidentificationnumberField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="exit-urls", Namespace="http://signering.posten.no/schema/v1")]
public partial class exiturls {
    
    private string completionurlField;
    
    private string rejectionurlField;
    
    private string errorurlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("completion-url")]
    public string completionurl {
        get {
            return this.completionurlField;
        }
        set {
            this.completionurlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("rejection-url")]
    public string rejectionurl {
        get {
            return this.rejectionurlField;
        }
        set {
            this.rejectionurlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("error-url")]
    public string errorurl {
        get {
            return this.errorurlField;
        }
        set {
            this.errorurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("direct-signature-job-request", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class directsignaturejobrequest {
    
    private string referenceField;
    
    private exiturls exiturlsField;
    
    /// <remarks/>
    public string reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("exit-urls")]
    public exiturls exiturls {
        get {
            return this.exiturlsField;
        }
        set {
            this.exiturlsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("direct-signature-job-manifest", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class directsignaturejobmanifest {
    
    private signer signerField;
    
    private sender senderField;
    
    private document documentField;
    
    /// <remarks/>
    public signer signer {
        get {
            return this.signerField;
        }
        set {
            this.signerField = value;
        }
    }
    
    /// <remarks/>
    public sender sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    public document document {
        get {
            return this.documentField;
        }
        set {
            this.documentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("direct-signature-job-response", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class directsignaturejobresponse {
    
    private long signaturejobidField;
    
    private string redirecturlField;
    
    private string statusurlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature-job-id")]
    public long signaturejobid {
        get {
            return this.signaturejobidField;
        }
        set {
            this.signaturejobidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("redirect-url")]
    public string redirecturl {
        get {
            return this.redirecturlField;
        }
        set {
            this.redirecturlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("status-url")]
    public string statusurl {
        get {
            return this.statusurlField;
        }
        set {
            this.statusurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("direct-signature-job-status-response", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class directsignaturejobstatusresponse {
    
    private long signaturejobidField;
    
    private directsignaturejobstatus statusField;
    
    private string confirmationurlField;
    
    private string xadesurlField;
    
    private string padesurlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature-job-id")]
    public long signaturejobid {
        get {
            return this.signaturejobidField;
        }
        set {
            this.signaturejobidField = value;
        }
    }
    
    /// <remarks/>
    public directsignaturejobstatus status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("confirmation-url")]
    public string confirmationurl {
        get {
            return this.confirmationurlField;
        }
        set {
            this.confirmationurlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("xades-url")]
    public string xadesurl {
        get {
            return this.xadesurlField;
        }
        set {
            this.xadesurlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("pades-url")]
    public string padesurl {
        get {
            return this.padesurlField;
        }
        set {
            this.padesurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="direct-signature-job-status", Namespace="http://signering.posten.no/schema/v1")]
public enum directsignaturejobstatus {
    
    /// <remarks/>
    SIGNED,
    
    /// <remarks/>
    REJECTED,
    
    /// <remarks/>
    FAILED,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("portal-signature-job-request", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class portalsignaturejobrequest {
    
    private string referenceField;
    
    /// <remarks/>
    public string reference {
        get {
            return this.referenceField;
        }
        set {
            this.referenceField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("portal-signature-job-manifest", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class portalsignaturejobmanifest {
    
    private signer[] signersField;
    
    private sender senderField;
    
    private document documentField;
    
    private availability availabilityField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
    public signer[] signers {
        get {
            return this.signersField;
        }
        set {
            this.signersField = value;
        }
    }
    
    /// <remarks/>
    public sender sender {
        get {
            return this.senderField;
        }
        set {
            this.senderField = value;
        }
    }
    
    /// <remarks/>
    public document document {
        get {
            return this.documentField;
        }
        set {
            this.documentField = value;
        }
    }
    
    /// <remarks/>
    public availability availability {
        get {
            return this.availabilityField;
        }
        set {
            this.availabilityField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("portal-signature-job-response", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class portalsignaturejobresponse {
    
    private long signaturejobidField;
    
    private string cancellationurlField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature-job-id")]
    public long signaturejobid {
        get {
            return this.signaturejobidField;
        }
        set {
            this.signaturejobidField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cancellation-url")]
    public string cancellationurl {
        get {
            return this.cancellationurlField;
        }
        set {
            this.cancellationurlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://signering.posten.no/schema/v1")]
[System.Xml.Serialization.XmlRootAttribute("portal-signature-job-status-change-response", Namespace="http://signering.posten.no/schema/v1", IsNullable=false)]
public partial class portalsignaturejobstatuschangeresponse {
    
    private long signaturejobidField;
    
    private portalsignaturejobstatus statusField;
    
    private string confirmationurlField;
    
    private string cancellationurlField;
    
    private signatures signaturesField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("signature-job-id")]
    public long signaturejobid {
        get {
            return this.signaturejobidField;
        }
        set {
            this.signaturejobidField = value;
        }
    }
    
    /// <remarks/>
    public portalsignaturejobstatus status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("confirmation-url")]
    public string confirmationurl {
        get {
            return this.confirmationurlField;
        }
        set {
            this.confirmationurlField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("cancellation-url")]
    public string cancellationurl {
        get {
            return this.cancellationurlField;
        }
        set {
            this.cancellationurlField = value;
        }
    }
    
    /// <remarks/>
    public signatures signatures {
        get {
            return this.signaturesField;
        }
        set {
            this.signaturesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(TypeName="portal-signature-job-status", Namespace="http://signering.posten.no/schema/v1")]
public enum portalsignaturejobstatus {
    
    /// <remarks/>
    PARTIALLY_COMPLETED,
    
    /// <remarks/>
    COMPLETED,
}
