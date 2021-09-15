namespace GLC.Intergration.CargowiseOne.UTBRANDS.Pipelines
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class SendUTBShipment : Microsoft.BizTalk.PipelineOM.SendPipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>8c6b051c-0ff5-4fc2-9ae5-5016cb726282</CategoryId>  <FriendlyName>Transmit</FriendlyName"+
">  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Pre-Assemble\" minO"+
"ccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4101-4cce-4536-83fa-4a5040674ad6\" />      <Co"+
"mponents>        <Component>          <Name>GLC.Intergration.CargowiseOne.UTBRANDS.PipelineCompoents"+
".DebatchShipment,GLC.Intergration.CargowiseOne.UTBRANDS.PipelineCompoents, Version=1.0.0.0, Culture="+
"neutral, PublicKeyToken=171a46e7ea1c8102</Name>          <ComponentName>DebatchUTBShipment</Componen"+
"tName>          <Description>Debatch UTB Shipment</Description>          <Version>1.0</Version>     "+
"     <Properties />          <CachedDisplayName>DebatchUTBShipment</CachedDisplayName>          <Cac"+
"hedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage>   "+
"   <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Assemble\" minOccurs=\"0\" maxOccurs=\"1\" execM"+
"ethod=\"All\" stageId=\"9d0e4107-4cce-4536-83fa-4a5040674ad6\" />      <Components>        <Component>  "+
"        <Name>Microsoft.BizTalk.Component.XmlAsmComp,Microsoft.BizTalk.Pipeline.Components, Version="+
"3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35</Name>          <ComponentName>XML assembl"+
"er</ComponentName>          <Description>XML assembler component.</Description>          <Version>1."+
"0</Version>          <Properties>            <Property Name=\"EnvelopeDocSpecNames\">              <Va"+
"lue xsi:type=\"xsd:string\" />            </Property>            <Property Name=\"EnvelopeSpecTargetNam"+
"espaces\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property N"+
"ame=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\" />            </Property>        "+
"    <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xsi:type=\"xsd:string\" />     "+
"       </Property>            <Property Name=\"XmlAsmProcessingInstructions\" />            <Property "+
"Name=\"ProcessingInstructionsOptions\">              <Value xsi:type=\"xsd:int\">0</Value>            </"+
"Property>            <Property Name=\"ProcessingInstructionsScope\">              <Value xsi:type=\"xsd"+
":int\">0</Value>            </Property>            <Property Name=\"AddXmlDeclaration\">              <"+
"Value xsi:type=\"xsd:boolean\">true</Value>            </Property>            <Property Name=\"TargetCh"+
"arset\">              <Value xsi:type=\"xsd:string\" />            </Property>            <Property Nam"+
"e=\"TargetCodePage\">              <Value xsi:type=\"xsd:int\">0</Value>            </Property>         "+
"   <Property Name=\"PreserveBom\">              <Value xsi:type=\"xsd:boolean\">true</Value>            "+
"</Property>            <Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">"+
"EnvelopeSpecTargetNamespaces,DocumentSpecTargetNamespaces,TargetCodePage</Value>            </Proper"+
"ty>          </Properties>          <CachedDisplayName>XML assembler</CachedDisplayName>          <C"+
"achedIsManaged>true</CachedIsManaged>        </Component>      </Components>    </Stage>    <Stage> "+
"     <PolicyFileStage _locAttrData=\"Name\" _locID=\"3\" Name=\"Encode\" minOccurs=\"0\" maxOccurs=\"-1\" exec"+
"Method=\"All\" stageId=\"9d0e4108-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </St"+
"ages></Document>";
        
        private const string _versionDependentGuid = "de4b426a-17a7-412d-a7e2-4f64c07c98ea";
        
        public SendUTBShipment()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4101-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("GLC.Intergration.CargowiseOne.UTBRANDS.PipelineCompoents.DebatchShipment,GLC.Intergration.CargowiseOne.UTBRANDS.PipelineCompoents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=171a46e7ea1c8102");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties /></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e4107-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlAsmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeDocSpec"+
"Names\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"EnvelopeSpecTargetNam"+
"espaces\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecNames\">"+
"      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"DocumentSpecTargetNamespaces"+
"\">      <Value xsi:type=\"xsd:string\" />    </Property>    <Property Name=\"XmlAsmProcessingInstructio"+
"ns\" />    <Property Name=\"ProcessingInstructionsOptions\">      <Value xsi:type=\"xsd:int\">0</Value>  "+
"  </Property>    <Property Name=\"ProcessingInstructionsScope\">      <Value xsi:type=\"xsd:int\">0</Val"+
"ue>    </Property>    <Property Name=\"AddXmlDeclaration\">      <Value xsi:type=\"xsd:boolean\">true</V"+
"alue>    </Property>    <Property Name=\"TargetCharset\">      <Value xsi:type=\"xsd:string\" />    </Pr"+
"operty>    <Property Name=\"TargetCodePage\">      <Value xsi:type=\"xsd:int\">0</Value>    </Property> "+
"   <Property Name=\"PreserveBom\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <"+
"Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Doc"+
"umentSpecTargetNamespaces,TargetCodePage</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
