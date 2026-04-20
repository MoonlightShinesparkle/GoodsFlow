using GoodsFlow.Data.Local.Parser;

namespace GoodsFlow.Data.Local;

/// <summary>
/// Service for creating and storing data into File Storage Medium (FSM) files
/// </summary>
public class FileStorageService {
    private static string RectifyPath(string Path)
    {
        if (!Path.EndsWith("fsm"))
        {
            if (!Path.EndsWith('.'))
            {
                Path += '.';
            }
            Path += "fsm";
        }

        return Path;
    }

    /// <summary>
    /// Opens or creates an FSM file
    /// </summary>
    /// <param name="Path">Path to the FSM file</param>
    /// <param name="Defaults">Default data to load when the file is created</param>
    /// <returns>An FSM access point</returns>
    public static FileStorageMedium OpenOrCreateFSM(string Path, Dictionary<string, StringOrNo> Defaults)
    {
        Path = RectifyPath(Path);
        FileStorageMedium Medium;
        if (File.Exists(Path))
        {
            Medium = new(Path);
            Medium.LoadFromFile();
        }
        else
        {
            Medium = new(Path, Defaults);
            Medium.SaveToFile();
        }

        return Medium;
    }

    /// <summary>
    /// Opens or creates an FSM file, loads default data if inexistant in opened FSM
    /// </summary>
    /// <remarks>
    /// * Rectifies types in StringOrNo items *
    /// </remarks>
    /// <param name="Path">Path to the FSM file</param>
    /// <param name="Defaults">Default data to load if missing</param>
    /// <returns>An FSM access point</returns>
    public static FileStorageMedium OpenFSMWithDefaults(string Path, Dictionary<string, StringOrNo> Defaults)
    {
        FileStorageMedium Medium = OpenOrCreateFSM(Path, Defaults);

        foreach (KeyValuePair<string, StringOrNo> Data in Defaults)
        {
            if (!Medium.Data.ContainsKey(Data.Key))
            {
                Medium[Data.Key] = Data.Value;
            }
            else
            {
                bool IsDefaultNumeric = int.TryParse(Data.Value.Value, out int _);
                bool IsDataNumeric = int.TryParse(Medium[Data.Key].Value, out int _);
                if (!(IsDefaultNumeric == IsDataNumeric))
                {
                    Medium[Data.Key] = Data.Value;
                }
            }
        }

        return Medium;
    }
}
