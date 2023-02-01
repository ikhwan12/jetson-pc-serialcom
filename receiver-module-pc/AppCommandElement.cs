using System.Configuration;
using System.Xml;

namespace SerialReader
{
    public class AppCommandElement : ConfigurationSection
    {
        public string InnerText { get; private set; }
        protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
        {
            InnerText = reader.ReadElementContentAsString();
        }
    }
}
