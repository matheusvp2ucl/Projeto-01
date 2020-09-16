using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;


// class DaoTags{

//   public static void InsertTags( List<> objeto){
//     FileStream arq = new FileStream("tags.txt", FileMode.Create);
//     BinaryFormatter serial = new BinaryFormatter();
//     serial.Serialize(arq, objeto);
//     arq.Close();
//   }

  public static List<> SelectAllTags(){
    List<Pessoa> info = new List<Pessoa>();
    FileStream arq = new FileStream("tags.txt", FileMode.Open);
    if( arq.Length == 0 ){
      return info;
    }
    BinaryFormatter serial = new BinaryFormatter();
    info = ( List<Pessoa> ) serial.Deserialize(arq);
    arq.Close();
    return info;
  }

//   public void DeleteTags(int idTag ){

//   }

// }