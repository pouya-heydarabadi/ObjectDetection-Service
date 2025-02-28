namespace ObjectDetectionService.Dtos;

public sealed record ImageToTextFileRequest
{
    public IFormFile file { get; set; }
    public string query { get; set; }
}