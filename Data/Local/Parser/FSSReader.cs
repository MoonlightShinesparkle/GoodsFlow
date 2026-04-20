namespace GoodsFlow.Data.Local.Parser;

public class FSSReader {
    /// <summary>
	/// Checks if binary stream contents are part of an FSM file
	/// </summary>
	/// <remarks>
	/// * Advances position *
	/// </remarks>
	/// <param name="Fil">Binary reader to possible FSM</param>
	/// <returns>Whether or not the signature was found</returns>
	public static bool IsFSM(BinaryReader Fil)
    {
        bool Viable = true;

        try
        {
            for (int i = 0; i < FSSWriter.Sign.Length; i++)
            {
                byte SignByte = FSSWriter.Sign[i];
                byte Readed = Fil.ReadByte();

                if (SignByte != Readed)
                {
                    Viable = false;
                    break;
                }
            }
        }
        catch (Exception)
        {
            Viable = false;
        }

        return Viable;
    }

    /// <summary>
    /// Reads an FSM block and stores its data within Data
    /// </summary>
    /// <remarks>
    /// * Advances position *
    /// </remarks>
    /// <param name="Fil">Binary reader of FSM file</param>
    /// <param name="Data">Dictionary to insert data into</param>
    public static void ReadBlock(BinaryReader Fil, Dictionary<string, StringOrNo> Data)
    {
        byte Type = Fil.ReadByte();
        string Index = Fil.ReadString();
        StringOrNo Value = new();

        switch (Type)
        {
            case 0x01:
                Value.Value = Fil.ReadInt32().ToString();
                break;
            case 0x02:
                Value.Value = Fil.ReadString();
                break;
        }

        Data[Index] = Value;
    }

    /// <summary>
    /// Returns an FSM file's contents within a dictionary
    /// </summary>
    /// <param name="Fil">Binary reader from the FSM file</param>
    /// <returns>Dictionary with parsed data</returns>
    /// <exception cref="ArgumentException"></exception>
    public static Dictionary<string, StringOrNo> ReadFSM(BinaryReader Fil)
    {
        Dictionary<string, StringOrNo> Values = new();

        if (!IsFSM(Fil))
        {
            throw new ArgumentException("Provided reader is not part of an FSM file");
        }

        while ((char)Fil.PeekChar() != (char)0x19)
        {
            ReadBlock(Fil, Values);
        }

        return Values;
    }
}
