namespace ECMS.DTO;

public class AreaResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
}