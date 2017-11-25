using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SerializationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person();
            me.FirstName = "Umberto";
            me.SecondName = "Ballestrazzi";

            Person mom = new Person();
            mom.FirstName = "myMom";
            mom.SecondName = "Ballestrazzi";
            mom.Dad = new Person { FirstName = "mygranpa", SecondName = "Ballestrazzi" };

            Person dad = new Person();
            dad.FirstName = "myDad";
            dad.SecondName = "Ballestrazzi";

            me.Dad = dad;
            me.Mom = mom;

            // Serializzazione - Viene utilizzato uno stream particolare (StringWriter)
            // che scrive una stringa in memoria che poi andiamo a stampare
            StringWriter stream = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            serializer.Serialize(stream, me);
            Console.Write(stream);
            Console.ReadLine();

        }
    }
}
