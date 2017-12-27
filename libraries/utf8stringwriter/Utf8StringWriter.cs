using System.Text;
using System.IO;

namespace Libraries.utf8stringwriter
{

    /// <summary>
    ///  Use UTF8 encoding by default
    /// </summary>
    /// <seealso cref="https://stackoverflow.com/questions/3862063/serializing-an-object-as-utf-8-xml-in-net"/>
    public class Utf8StringWriter : StringWriter
    {

        public override Encoding Encoding => Encoding.UTF8;

    }

}
