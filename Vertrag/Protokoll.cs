using System;
using System.IO;
using System.Text;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Xml;

namespace Prototype
{
    public class Protokoll
    {
        private static string ipadress = "192.168.0.95"; //192.168.0.95
        private static int port = 8001; //8001

        private static string XmltoString(XmlDocument doc)
        {
            StringBuilder sb = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "  ",
                NewLineChars = "\r\n",
                NewLineHandling = NewLineHandling.Replace
            };
            settings.OmitXmlDeclaration = true;
            using (XmlWriter writer = XmlWriter.Create(sb, settings))
            {
                doc.Save(writer);
            }

            return sb.ToString();
        }
        private static void SendBytes(string data, Stream nwstream) //adjusts bytes to protocoll
        {
            byte[] ba = Encoding.UTF8.GetBytes(data);
            byte[] bstart = BitConverter.GetBytes(Convert.ToInt16(ba.Length));
            byte eot = 0x04;
            //Adjust Bytes to Protocoll
        for (int i = 0; i < bstart.Length; i++) //message length
            {
                nwstream.WriteByte(bstart[i]);
            }

            for (int i = 0; i < ba.Length; i++) //message length
            {
                nwstream.WriteByte(ba[i]);
            }

            nwstream.WriteByte(eot); //Message Endoftransmission
        }

        private static string sendtoServer(string xmldata)
        {
            TcpClient tcpclnt = new TcpClient();
            tcpclnt.Connect(ipadress, port);
            Stream nwstream = tcpclnt.GetStream();
            SendBytes(xmldata, nwstream);
            StreamReader nwreader = new StreamReader(nwstream, Encoding.UTF8);
            String response;
            try
            {
                response = nwreader.ReadToEnd();
            }
            finally
            {
                nwreader.Close();
            }

            tcpclnt.Close();
            return response;
        }

        public static void BookData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.filepathSend + "cmdbook.txt");
            XmlNode nod1 = doc.SelectSingleNode("CMD_BOOK/TRANS_ID");
            nod1.FirstChild.Value = Guid.NewGuid().ToString();
            XmlNode nod2 = doc.SelectSingleNode("CMD_BOOK/FOREIGNSYSTEM");
            nod2.FirstChild.Value = Program.foreignsystem.ToString();
            string xmldata = XmltoString(doc);
            string response = sendtoServer(xmldata);
            String pathtofile = Program.filepathResponse + "responsecmdbook.txt";
            File.WriteAllText(@pathtofile, response);
        }

        public static void getNameData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.filepathSend + "getname.txt"); //getname //send
            XmlNode nod2 = doc.SelectSingleNode("CMD_GET_CARDINFO/FOREIGNSYSTEM");
            nod2.FirstChild.Value = Program.foreignsystem.ToString();
            string xmldata = XmltoString(doc);
            string response = sendtoServer(xmldata);
            String pathtofile = Program.filepathResponse + "responsegetname.txt";
            File.WriteAllText(pathtofile, response);
        }

        public static void SaldoData()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Program.filepathSend + "saldo.txt");
            XmlNode nod2 = doc.SelectSingleNode("CMD_GET_CARDINFO/FOREIGNSYSTEM");
            nod2.FirstChild.Value = Program.foreignsystem.ToString();
            string xmldata = XmltoString(doc);
            string response = sendtoServer(xmldata);
            String pathtofile = Program.filepathResponse + "responsesaldo.txt";
            File.WriteAllText(pathtofile, response);
        }
    }
}