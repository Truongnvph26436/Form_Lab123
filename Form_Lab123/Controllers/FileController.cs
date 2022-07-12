using System.Xml.Serialization;

namespace Form_Lab123.Controllers
{
    internal class FileController
    {
        public List<T> ReadCarfromXML<T>(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        var lstCar = (List<T>)serializer.Deserialize(fs);
                        return lstCar;
                    }
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }

        public void SaveCarfromXML<T>(string path, T doituong)
        {
            if (File.Exists(path))
            {
                List<T> lstCar = ReadCarfromXML<T>(path);
                if (lstCar != null)
                {
                    lstCar.Add(doituong);
                    XmlSerializer xs = new XmlSerializer(typeof(List<T>));

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        xs.Serialize(sw, lstCar);
                        sw.Close();
                    }
                }
                else
                {
                    List<T> lstCars = new List<T>();
                    lstCars.Add(doituong);
                    XmlSerializer xs = new XmlSerializer(typeof(List<T>));

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        xs.Serialize(sw, lstCars);
                        sw.Close();
                    }
                }
            }
        }
    }
}