namespace GoodsFlow.Data.Local.Parser;

/// <summary>
/// Represents a possible string or number
/// </summary>
/// <param name="Value">Stored value or null</param>
public struct StringOrNo(string? Value = null)
{
    public string? Value = Value;

    /// <summary>
    /// Gets a number if it's stored, else 0
    /// </summary>
    /// <returns>The number stored or 0</returns>
    public int Number()
    {
        int.TryParse(Value, out int X);
        return X;
    }

    /// <summary>
    /// Gets a number if it's stored, else Default
    /// </summary>
    /// <param name="Default">Default expected value</param>
    /// <returns>Stored number or Default</returns>
    public int NumberOr(int Default)
    {
        if (int.TryParse(Value, out int X))
        {
            return X;
        }
        else
        {
            return Default;
        }
    }

    /// <summary>
    /// Returns a stored string or an empty one
    /// </summary>
    /// <returns>Stored string or empty string</returns>
    public override string ToString()
    {
        return Value ?? "";
    }

    /// <summary>
    /// Returns a stored string or Default
    /// </summary>
    /// <param name="Default">Default expected value</param>
    /// <returns>Stored string or default string</returns>
    public string ToString(string Default)
    {
        return Value ?? Default;
    }
}

public class FSSWriter {
    /// <summary>
	/// "Magic number" associated with an FSM binary
	/// </summary>
	public static byte[] Sign = [
        0x4D, 0x6F, 0x6F, 0x6E, 0x6C, 0x69, 0x74, 0x46, 0x53, 0x53, 0x69, 0x6C, 0x65
    ];

    /// <summary>
    /// Writes header into a FSM binary
    /// </summary>
    /// <param name="Fil">Binary writer of the FSM file</param>
    public static void WriteHeader(BinaryWriter Fil)
    {
        foreach (byte MagicNumber in Sign)
        {
            Fil.Write(MagicNumber);
        }
    }

    /// <summary>
    /// Saves a set of data into a FSM file
    /// </summary>
    /// <param name="Fil">Binary writer of the FSM file</param>
    /// <param name="Data">Data to write into the FSM file</param>
    public static void SaveDictionary(BinaryWriter Fil, Dictionary<string, StringOrNo> Data)
    {
        WriteHeader(Fil);

        foreach (KeyValuePair<string, StringOrNo> Item in Data)
        {
            bool IsNumber = int.TryParse(Item.Value.Value, out int X);

            // Block type
            Fil.Write(IsNumber ? (byte)0x01 : (byte)0x02);

            // Block name
            Fil.Write(Item.Key);

            // Block value
            if (IsNumber)
            {
                Fil.Write(X);
            }
            else
            {
                Fil.Write(Item.Value.ToString());
            }
        }

        // End of FSM
        Fil.Write((char)0x19);
    }
}
