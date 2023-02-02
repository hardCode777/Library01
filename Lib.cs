using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;


namespace Library
{
    public class Lib
    {
        public BindingList<Record> Records { get; set; }
        public BindingList <Book> Books { get; set; }
        public BindingList <Reader> Readers { get; set; }
        public BindingList <Author> Authors { get; set; }
        public Lib()
        {
            Records = new BindingList <Record> ();
            Books = new BindingList <Book>();
            Readers = new BindingList <Reader>();
            Authors = new BindingList <Author>();
        }

    }
    public class XMLFile
    {
        XmlSerializer serializer;
        public string file = " ";
        public XMLFile(string file)
        {
            serializer = new XmlSerializer(typeof (Lib));
            this.file = file;
        }
        public void Serialize(Lib lib)
        {
            using
                FileStream fileStrem = new FileStream(file, FileMode.Create);
                serializer.Serialize(fileStrem, lib);
        }
        public Lib DeSerialize()
        {
            try
            {
                using
                    FileStream fileStream = new FileStream(file, FileMode.Open);
                return (Lib)serializer.Deserialize(fileStream);
            }
            catch (Exception)
            {
                return new Lib();
            }
        }

    }
    public class Record
    {
        public int Id { get; set; }
        public Reader Reader { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }

    }
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author;
    }
    public class Reader
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
