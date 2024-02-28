using DeepFreeze___Cool_Storage_Designer.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DeepFreeze___Cool_Storage_Designer.Tools
{
	public static class CustomTool
	{
        public static string filePath = Application.StartupPath + @"\src\materials.mat";
        public static void SerializeObject(List<Material> materials)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Material>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, materials);
            }
        }
        public static List<Material> DeserializeObject(string filePath)
		{
            List<Material> materials;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Material>));
            using (Stream reader = new FileStream(filePath, FileMode.Open))
            {
                materials = (List<Material>)serializer.Deserialize(reader);
            }
            return materials;
        }
    }
}
