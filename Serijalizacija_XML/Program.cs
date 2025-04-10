using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Serijalizacija_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("XmlDocument klasa");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.PreserveWhitespace = true;
            //xmlDoc.Load("filename.xml"); //čitanje iz datoteke
            //xmlDoc.LoadXml("neki xml string..."); //čitanje iz stringa...
            Osoba o = new Osoba()
            {
                Id = 1,
                Ime = "Marko",
                Prezime = "Marulić",
                DatumRodjenja = new DateTime(1812, 4, 21)
            };
            XmlNode rootNode = xmlDoc.CreateElement("osobe");
            xmlDoc.AppendChild(rootNode);

            XmlNode osobaNode = xmlDoc.CreateElement("osoba");

            XmlAttribute atribut = xmlDoc.CreateAttribute("datumrodjenja");
            atribut.Value = o.DatumRodjenja.ToShortDateString();
            osobaNode.Attributes.Append(atribut);

            XmlNode imeNode = xmlDoc.CreateElement("ime");
            imeNode.InnerText = o.Ime;
            osobaNode.AppendChild(imeNode);

            XmlNode prezimeNode = xmlDoc.CreateElement("prezime");
            prezimeNode.InnerText = o.Prezime;
            osobaNode.AppendChild(prezimeNode);

            rootNode.AppendChild(osobaNode);

            xmlDoc.Save("test.xml");

            xmlDoc = new XmlDocument();
            xmlDoc.Load("test.xml");

            XmlNodeList osobe = xmlDoc.SelectNodes("//osobe/osoba");
            foreach(XmlNode osoba in osobe)
            {
                Osoba xmlo = new Osoba();
                xmlo.DatumRodjenja = DateTime.Parse(osoba.Attributes["datumrodjenja"].Value);
                xmlo.Ime = osoba.ChildNodes[0].InnerText;
                xmlo.Prezime = osoba.ChildNodes[1].InnerText;

                Console.WriteLine(xmlo.Ime+" "+xmlo.Prezime+" "+xmlo.DatumRodjenja.ToShortDateString());
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("XmlWriter i XmlReader: ");

            XmlWriter writer = XmlWriter.Create("testrw.xml");

            writer.WriteStartDocument();
            writer.WriteStartElement("osobe");

            writer.WriteStartElement("osoba");
            writer.WriteAttributeString("datumrodjenja",o.DatumRodjenja.ToShortDateString());

            writer.WriteStartElement("ime");
            writer.WriteString(o.Ime);
            writer.WriteEndElement();

            writer.WriteStartElement("prezime");
            writer.WriteString(o.Prezime);
            writer.WriteEndElement();

            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Close();

            Osoba os = new Osoba();
            XmlReader reader = XmlReader.Create("testrw.xml");
            while (reader.Read())
            {
                if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "osoba"))
                {
                    if (reader.HasAttributes)
                    {
                        os.DatumRodjenja = DateTime.Parse(reader.GetAttribute("datumrodjenja"));
                    }
                    reader.Read();
                    if(reader.NodeType == XmlNodeType.Element && reader.Name == "ime")
                    {
                        os.Ime = reader.Value;
                    }
                    reader.Read();
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "prezime")
                    {
                        os.Prezime = reader.Value;
                    }

                    Console.WriteLine(os.Ime + " " + os.Prezime + " " + os.DatumRodjenja.ToShortDateString());
                }
            }
        }
    }
}
