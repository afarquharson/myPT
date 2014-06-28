using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace myPT.Core.Implementation.Model
{
    public class Writer : IDataWriter
    {
        FileStream Stream;
        BinaryFormatter Formatter;

        public void Write<TData>(string fileName, TData data)
        {
            if (File.Exists(fileName)) File.Delete(fileName);//TODO use Append or CreateNew when appropriate instead of rewriting
            Stream = File.Create(fileName);
            Formatter = new BinaryFormatter();
            Formatter.Serialize(Stream, data);
            Stream.Close();
        }

        public TData Read<TData>(string fileName)
        {
            Stream = File.OpenRead(fileName);
            Formatter = new BinaryFormatter();
            TData data = (TData)Formatter.Deserialize(Stream);
            Stream.Close();
            return data;
        }
    }
}
