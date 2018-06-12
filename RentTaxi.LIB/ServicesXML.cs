using RentTaxi.AdminModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace RentTaxi.LIB
{
    public class ServicesXML
    {
        public ServicesXML()
        {

        }
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

        public bool GetUser(string login, string password)
        {
            return true;
        }

        public bool AddUser(TBL_User user, out string message)
        {
            try
            {

                XmlSerializer formater = new XmlSerializer(typeof(TBL_User));
                using (FileStream fs = new FileStream("user/" + user.UserName + ".xml", FileMode.OpenOrCreate))
                {
                    formater.Serialize(fs, user);
                }
                message = "Пользователь добавлен!";
                return true;
            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }

        }

        public List<TBL_User> getUser()
        {
            List<TBL_User> users = new List<TBL_User>();
            DirectoryInfo di = new DirectoryInfo("user");
            XmlSerializer formater = new XmlSerializer(typeof(TBL_User));
            foreach (FileInfo item in di.GetFiles())
            {
                using (FileStream fs = new FileStream(item.FullName, FileMode.Open))
                {
                    users.Add((TBL_User)formater.Deserialize(fs));
                }
                //
            }
            return users;
        }
    }
}

