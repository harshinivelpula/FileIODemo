using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIODemo
{
     class XMLSerialization
    {
        public void SerializeXml()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"E\ExampleForXml.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2015, 12, 31);
            orderForm.OrderDate = dt2;
            ser.Serialize(fileStream, orderForm);
        }

     }
    public class OrderForm
    {
        public DateTime OrderDate;
    }
}
