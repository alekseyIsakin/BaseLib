using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseLib
{
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
        public readonly Func<AbstrPageEl> BaseConstruct;
        public readonly Func<AbstrPageEl, AbstrUIBase> BaseUIConstruct;
        public readonly Func<System.Xml.XmlNode, AbstrPageEl> XMLLoader;
        public readonly Func<AbstrPageEl, System.Xml.XmlDocument, System.Xml.XmlElement> XMLWriter;
        
        public ExternalLibData(int id, string name,
            Func<AbstrPageEl> BaseConstruct,
            Func<AbstrPageEl, AbstrUIBase> BaseUIConstruct,
            Func<System.Xml.XmlNode, AbstrPageEl> XMLLoader,
            Func<AbstrPageEl, System.Xml.XmlDocument, System.Xml.XmlElement> XMLWriter)
        {
            this.id = id;
            this.name = name;
            this.BaseConstruct = BaseConstruct;
            this.BaseUIConstruct = BaseUIConstruct;
            this.XMLLoader = XMLLoader;
            this.XMLWriter = XMLWriter;
        }
    }
}
