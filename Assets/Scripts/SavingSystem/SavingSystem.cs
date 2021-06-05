using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavingSystem 
{
    private const string saveFile = "Game";
    public static void Save(Game game) {
        string path = GetFilePath(saveFile);
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);
        GameData data = new GameData(game);
        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static GameData Load() {
        string path = GetFilePath(saveFile);

        if(File.Exists(path)) {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);
            GameData getData = formatter.Deserialize(stream) as GameData;

            stream.Close();
            return getData;
        } else {
            Debug.Log("There is no data in the path : " + path);
            return null;
        }

        
    }

    private static string GetFilePath(string saveFile) {
        return Path.Combine(Application.persistentDataPath, saveFile) + ".sav"; 
    }
}
