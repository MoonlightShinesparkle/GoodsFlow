using GoodsFlow.Data.Local.Parser;

namespace GoodsFlow.Data.Local;

/// <summary>
/// Access point into an FSM file
/// </summary>
public class FileStorageMedium(string Path) {
    public readonly string Path = Path;
    public readonly Dictionary<string, StringOrNo> Data = new();

    /// <summary>
    /// Quick access point into Data
    /// </summary>
    /// <param name="index">Name of the data to handle</param>
    /// <returns>index within Data</returns>
    public StringOrNo this[string index]
    {
        get { return Data[index]; }
        set { Data[index] = value; }
    }

    /// <summary>
    /// Creates a FSM access point, overwriting with default data
    /// </summary>
    /// <param name="Path">Path pointing towards the FSM file</param>
    /// <param name="Defaults">Default data to load into the file</param>
    public FileStorageMedium(string Path, Dictionary<string, StringOrNo> Defaults) : this(Path)
    {
        foreach (KeyValuePair<string, StringOrNo> Value in Defaults)
        {
            Data[Value.Key] = Value.Value;
        }
    }

    public void SetValue(string Index, string Value)
    {
        this[Index] = new StringOrNo(Value);
    }

    public void SetValue(string Index, int Value)
    {
        SetValue(Index, Value.ToString());
    }

    public void LoadFromFile()
    {
        if (File.Exists(Path))
        {
            FileStream Opened = File.Open(Path, FileMode.Open);
            BinaryReader Reader = new(Opened);

            Dictionary<string, StringOrNo> NewData = FSSReader.ReadFSM(Reader);
            Data.Clear();

            foreach (KeyValuePair<string, StringOrNo> Obj in NewData)
            {
                Data[Obj.Key] = Obj.Value;
            }

            Reader.Dispose();
            Opened.Dispose();
        }
        else
        {
            throw new FileNotFoundException();
        }
    }

    public void SaveToFile()
    {
        FileStream Opened = File.Open(Path, FileMode.Create);
        BinaryWriter Writer = new(Opened);

        FSSWriter.SaveDictionary(Writer, Data);

        Writer.Dispose();
        Opened.Dispose();
    }
}
