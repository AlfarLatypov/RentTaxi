using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RentTaxi.LIB
{
   public class ServicesXML
    {
       public string path { get; set; }
        public ServicesXML(string path)
        {
            this.path = path;
        }

        public void l(string path)
        {

           
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {



            }
        }

      public XmlDocument GetDocument()
        { 
            XmlDocument xmlDoc = new XmlDocument();
            //проверить есть ли документ
            FileInfo info = new FileInfo(path);
            //если есть загрузить и вернуть
            if (info.Exists)
            {
                xmlDoc.Load(path);
            }
            else
            {
                //если нет то создать, создать корневой элемент и вернуть
                XmlElement root = xmlDoc.CreateElement("Users");
                xmlDoc.AppendChild(root);
                xmlDoc.Save(path);

            }
            return xmlDoc;
        }

        public XmlElement GetUser(string login, string password)
        {

            return null;
        }

    }
}
