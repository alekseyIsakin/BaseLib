using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseLib
{
    public delegate AbstrPageEl BaseConstruct();
    public delegate AbstrPageEl BaseUIConstruct(AbstrUIBase);
    public delegate System.Xml.XmlNode BaseXMLLoader(AbstrPageEl);
    public delegate AbstrPageEl BaseXMLWriter(System.Xml.XmlDocument, System.Xml.XmlElement);

    public class ExternalLib 
    {
        protected List<ExternalLibData> listELD = new List<ExternalLibData>();

        public virtual List<ExternalLibData> getListElements()
        { return listELD; }
    }

    public sealed class ExternalLibData
    {
        public readonly int id;
        public readonly string name;
        public readonly BaseConstruct Construct;
        public readonly BaseUIConstruct UIConstruct;
        public readonly BaseXMLLoader XMLLoader;
        public readonly BaseXMLWriter XMLWriter;
        
        public ExternalLibData(int id, string name, 
            BaseConstruct construct,
            BaseUIConstruct uiConstruct,
            BaseXMLLoader xmlLoader,
            BaseXMLWriter xmlWriter)
           
        {
            this.id = id;
            this.name = name;
            this.Construct = construct;
            this.UIConstruct = uiConstruct;
            this.XMLLoader = xmlLoader;
            this.XMLWriter = xmlWriter;
        }
    }
}
