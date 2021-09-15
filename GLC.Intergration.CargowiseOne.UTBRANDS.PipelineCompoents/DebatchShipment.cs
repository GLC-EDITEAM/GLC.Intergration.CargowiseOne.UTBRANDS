using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.BizTalk.Component.Interop;
using Microsoft.BizTalk.Message.Interop;
using System.IO;
using System.Xml;

namespace GLC.Intergration.CargowiseOne.UTBRANDS.PipelineCompoents
{
    [Serializable]
    [ComponentCategory(CategoryTypes.CATID_PipelineComponent)]
    [ComponentCategory(CategoryTypes.CATID_Any)]
    [System.Runtime.InteropServices.Guid("B83AE1BA-F218-4557-A46B-51921C2A6A6B")]


    public class DebatchShipment : IBaseComponent, IComponent, IComponentUI
    {
        #region IBaseComponent

        /// <summary>
        /// Name of the component.
        /// </summary>
        //[Browsable(false)]
        public string Name
        {
            get { return "DebatchUTBShipment"; }
        }

        /// <summary>
        /// Version of the component.
        /// </summary>
        //[Browsable(false)]
        public string Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// Description of the component.
        /// </summary>
        // [Browsable(false)]
        public string Description
        {
            get { return "Debatch UTB Shipment"; }
        }

        #endregion
        #region IComponentUI
        public IntPtr Icon
        {
            get
            {
                return new System.IntPtr();
            }
        }

        public System.Collections.IEnumerator Validate(object projectSystem)
        {
            return null;
        }
        #endregion
        #region IComponent

        public Microsoft.BizTalk.Message.Interop.IBaseMessage Execute(Microsoft.BizTalk.Component.Interop.IPipelineContext pc, Microsoft.BizTalk.Message.Interop.IBaseMessage inmsg)
        {
            var shipcode = new List<string>();
            var ponum = new List<string>();
            IBaseMessageContext messageContext = inmsg.Context;
            Stream originalStream = inmsg.BodyPart.GetOriginalDataStream();
            StreamReader strmread = new StreamReader(originalStream);
            string data = strmread.ReadToEnd();
            DateTime strDateTime = new DateTime();
            strDateTime = DateTime.Now;
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(data);
            XmlNamespaceManager xmn = new XmlNamespaceManager(xdoc.NameTable);
            xmn.AddNamespace("xmlns2", "http://www.cargowise.com/Schemas/Universal/2011/11");

            XmlNodeList xmlnode = xdoc.SelectNodes("//xmlns2:Shipment", xmn);
            int cnt = 1;

            foreach (XmlNode node in xmlnode)
            {
                string strfinalxml = "<ns0:UniversalShipment xmlns:ns0='http://www.cargowise.com/Schemas/Universal/2011/11'>" + node.OuterXml + " </ns0:UniversalShipment>";
                string filepath = @"C:\UTB_Debatch\UTBFile_" + cnt + "_" + DateTime.Now.ToString("ddMMyyyyHHmmss") + ".xml";

                File.WriteAllText(filepath, strfinalxml);
                cnt = cnt + 1;
            }


            originalStream.Seek(0, SeekOrigin.Begin);
            inmsg.BodyPart.Data = originalStream;
            inmsg.Context = messageContext;
            return inmsg;
        }
        #endregion

    }
}

