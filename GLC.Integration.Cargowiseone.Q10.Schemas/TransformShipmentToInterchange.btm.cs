namespace GLC.Integration.Cargowiseone.Q10.Schemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange))]
    public sealed class TransformShipmentToInterchange : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:UniversalShipment"" />
  </xsl:template>
  <xsl:template match=""/ns0:UniversalShipment"">
    <!--Test Value-->
    <!--<xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;GLCTRN&quot;)"" />  
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;GLCGDSTRN&quot;)"" /> 
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;OnAll&quot;)"" /> 
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;eAdaptor&quot;)"" /> 
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;GLCTRNLAX&quot;)"" />-->
    <!--Prod Value-->
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;GLCLAX&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;GLCGDSLAX&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;OnAll&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;eAdaptor&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;GLCGDSLAX&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:UniversalInterchange>
      <ns0:Header>
        <ns0:SenderID>
          <xsl:value-of select=""$var:v1"" />
        </ns0:SenderID>
        <ns0:RecipientID>
          <xsl:value-of select=""$var:v2"" />
        </ns0:RecipientID>
        <ns0:Acknowledgement>
          <ns0:Required>
            <xsl:value-of select=""$var:v3"" />
          </ns0:Required>
          <ns0:Channel>
            <xsl:value-of select=""$var:v4"" />
          </ns0:Channel>
          <ns0:RecipientID>
            <xsl:value-of select=""$var:v2"" />
          </ns0:RecipientID>
          <ns0:ContextCollection>
            <ns0:Context>
              <ns0:Type>MESSAGE_SOURCE</ns0:Type>
              <ns0:Value>Q10</ns0:Value>
            </ns0:Context>
            <ns0:Context>
              <ns0:Type>MESSAGE_IDENTIFIER</ns0:Type>
              <ns0:Value>Q10_EDI940</ns0:Value>
            </ns0:Context>
            <ns0:Context>
              <ns0:Type>MESSAGE_DATETIME</ns0:Type>
              <ns0:Value>
                <xsl:value-of select=""$var:v7""/>
              </ns0:Value>
            </ns0:Context>
            <ns0:Context>
              <ns0:Type>PO_NUMBER</ns0:Type>
              <ns0:Value>
                <xsl:value-of select=""ns0:Shipment/ns0:Order/ns0:OrderNumber/text()"" />
              </ns0:Value>
            </ns0:Context>
            <ns0:Context>
              <ns0:Type>CLIENT_REFERENCE</ns0:Type>
              <ns0:Value>
                <xsl:value-of select=""ns0:Shipment/ns0:Order/ns0:ClientReference/text()"" />
              </ns0:Value>
            </ns0:Context>
          </ns0:ContextCollection>
        </ns0:Acknowledgement>
      </ns0:Header>
      <xsl:element name=""Body"">
        <xsl:text disable-output-escaping=""yes""></xsl:text>
        <xsl:copy-of select=""/*[local-name()='UniversalShipment' and namespace-uri()='http://www.cargowise.com/Schemas/Universal/2011/11']"" />
        <xsl:text disable-output-escaping=""yes""></xsl:text>
      </xsl:element>
    </ns0:UniversalInterchange>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
public string StringConcat(string param0){   return param0;}public string DateCurrentDateTime(){DateTime dt = DateTime.Now;string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);string retval = curdate + ""T"" + curtime;return retval;}
]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalInterchange";
                return _TrgSchemas;
            }
        }
    }
}
