// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>ImportChecker</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>False</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace ImportChecker
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;


    public partial class importchecker
    {

        private List<ImportedLibrary> libraryField;

        public importchecker()
        {
            this.libraryField = new List<ImportedLibrary>();
        }

        public List<ImportedLibrary> library
        {
            get
            {
                return this.libraryField;
            }
            set
            {
                this.libraryField = value;
            }
        }
    }

    public partial class ImportedLibrary
    {

        private List<ImportedType> typeField;

        private string nameField;

        private string fullnameField;

        public ImportedLibrary()
        {
            this.typeField = new List<ImportedType>();
        }

        public List<ImportedType> type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public string fullname
        {
            get
            {
                return this.fullnameField;
            }
            set
            {
                this.fullnameField = value;
            }
        }
    }

    public partial class ImportedType
    {

        private List<ImportedMember> membersField;

        private List<ImplementedMember> implementedField;

        private string nameField;

        private ElementType kindField;

        private bool kindFieldSpecified;

        public ImportedType()
        {
            this.implementedField = new List<ImplementedMember>();
            this.membersField = new List<ImportedMember>();
        }

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("member", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<ImportedMember> members
        {
            get
            {
                return this.membersField;
            }
            set
            {
                this.membersField = value;
            }
        }

        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("member", Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public List<ImplementedMember> implemented
        {
            get
            {
                return this.implementedField;
            }
            set
            {
                this.implementedField = value;
            }
        }

        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public ElementType kind
        {
            get
            {
                return this.kindField;
            }
            set
            {
                this.kindField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool kindSpecified
        {
            get
            {
                return this.kindFieldSpecified;
            }
            set
            {
                this.kindFieldSpecified = value;
            }
        }
    }

    public partial class ImportedMember
    {

        private string signatureField;

        private string nameField;

        private ElementType kindField;

        private bool kindFieldSpecified;

        public string signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        public ElementType kind
        {
            get
            {
                return this.kindField;
            }
            set
            {
                this.kindField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool kindSpecified
        {
            get
            {
                return this.kindFieldSpecified;
            }
            set
            {
                this.kindFieldSpecified = value;
            }
        }
    }

    public enum ElementType
    {

        /// <remarks/>
        method,

        /// <remarks/>
        field,
    }

    public partial class ImplementedMember
    {

        private string signatureField;

        private string nameField;

        public string signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
}