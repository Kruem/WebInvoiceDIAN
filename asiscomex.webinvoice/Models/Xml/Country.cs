﻿using System.Xml.Serialization;

namespace Asiscomex.Webinvoice.Models.Xml
{
    [XmlRoot(ElementName = "Country", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
    public class Country
    {
        [XmlElement(ElementName = "IdentificationCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public string IdentificationCode { get; set; }
        [XmlElement(ElementName = "Name", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public Name Name { get; set; }
    }
}
