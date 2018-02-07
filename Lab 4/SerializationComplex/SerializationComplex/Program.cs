using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SerializationComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] num1 = s.Split(' ');
            string[] n1 = num1[0].Split('/');
            string[] n2 = num1[1].Split('/');

            int i1 = int.Parse(n1[0]);
            int i2 = int.Parse(n1[1]);
            int i3 = int.Parse(n2[0]);
            int i4 = int.Parse(n2[1]);

            Complex c1 = new Complex(i1, i2);
            Complex c2 = new Complex(i3, i4);
            Complex mul = c1 * c2;
            Complex div = c1 / c2;
            Complex sum = c1 + c2;
            Complex sub = c1 - c2;

            //XML Serialization:
            FileStream fs = new FileStream(@"D:\data1.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            try
            {
                xs.Serialize(fs, mul);
                xs.Serialize(fs, div);
                xs.Serialize(fs, sum);
                xs.Serialize(fs, sub);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

            //XML Deserialization:
            fs = new FileStream(@"D:\data1.xml", FileMode.Open, FileAccess.Read);

            try
            {
                Complex c = xs.Deserialize(fs) as Complex;

                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                Console.WriteLine("The XML file is deserialized!");
            }
            finally
            {
                fs.Close();
            }


            //BinaryFormatter Serialization:

            fs = new FileStream(@"D:\data2.txt", FileMode.Create, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                bf.Serialize(fs, mul);
                bf.Serialize(fs, div);
                bf.Serialize(fs, sum);
                bf.Serialize(fs, sub);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }

            //BinaryFormatter Deserialization:
            fs = new FileStream(@"D:\data2.txt", FileMode.Open, FileAccess.Read);

            try
            {
                mul = bf.Deserialize(fs) as Complex;

                Console.WriteLine(mul);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                fs.Close();
            }
            Console.ReadKey();
        }
    }
}



