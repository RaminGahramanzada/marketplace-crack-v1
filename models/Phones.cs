namespace marketplace_crack_v1.models;

public class Phones : Products
{
    public int Id { get; set; }
    public string ScreenSize { get; set; }
    public string InternalMemory { get; set; }
    public string OperatingMemory { get; set; }
    public string MainCamera { get; set; }
    public string FaceCamera { get; set; }
    public short NumberOfSimCards { get; set; }
    public string ProcessorName { get; set; }
    
}