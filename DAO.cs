using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


class DaoDispesas
{

    public static void InsertDispesas(List<Dispesa> objeto) {
        FileStream arq = new FileStream("./banco/dispesas.txt", FileMode.OpenOrCreate);
        BinaryFormatter serial = new BinaryFormatter();
        serial.Serialize(arq, objeto);
        arq.Close();
    }

    public static List<Dispesa> SelectAllDispesas() {
        List<Dispesa> info = new List<Dispesa>();
        FileStream arq = new FileStream("./banco/dispesas.txt", FileMode.OpenOrCreate);
        if (arq.Length == 0) {
            arq.Close();
            return info;
        }
        BinaryFormatter serial = new BinaryFormatter();
        info = (List<Dispesa>)serial.Deserialize(arq);
        arq.Close();
        return info;
    }

    public void DeleteDispesas(int pos) {
        List<Dispesa> info = SelectAllDispesas();
        info.RemoveAt(pos - 1);
        InsertDispesas(info);
    }

}

class DaoTags
{

    public static void InsertTags(List<Tag> objeto) {
        FileStream arq = new FileStream("./banco/tags.txt", FileMode.OpenOrCreate);
        BinaryFormatter serial = new BinaryFormatter();
        serial.Serialize(arq, objeto);
        arq.Close();
    }

    public static List<Tag> SelectAllTags() {
        List<Tag> info = new List<Tag>();
        FileStream arq = new FileStream("./banco/tags.txt", FileMode.OpenOrCreate);
        if (arq.Length == 0) {
            arq.Close();
            return info;
        }
        BinaryFormatter serial = new BinaryFormatter();
        info = (List<Tag>)serial.Deserialize(arq);
        arq.Close();
        return info;
    }

    public void DeleteTags(int pos) {
        List<Tag> info = SelectAllTags();
        info.RemoveAt(pos - 1);
        InsertTags(info);
    }

}

