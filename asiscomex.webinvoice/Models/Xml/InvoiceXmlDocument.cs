using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    public abstract class InvoiceXmlDocument
    {
        public virtual string ToXml()
        {
            var xmlSerializer = new XmlSerializer(this.GetType());
            var stringWriter = new StringWriter();
            var writer = XmlWriter.Create(stringWriter);
            xmlSerializer.Serialize(writer, this);
            return stringWriter.ToString();
        }

        public virtual string ToBase64Xml()
        {
            var xml = ToXml();
            var base64Xml = Convert.ToBase64String(Encoding.UTF8.GetBytes(xml));
            return $"\"{base64Xml}\"";
        }
    }
}
