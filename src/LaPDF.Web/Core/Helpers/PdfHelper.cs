namespace LaPDF.Web.Core.Helpers;

public static class PdfHelper
{
    public static bool IsPdfFile(IFormFile file)
    {
        if (file == null || string.IsNullOrEmpty(file.FileName))
            return false;

        var extension = Path.GetExtension(file.FileName).ToLower();
        return extension == ".pdf";
    }

    public static bool IsPdfFile(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return false;

        var extension = Path.GetExtension(fileName).ToLower();
        return extension == ".pdf";
    }

    public static string GetFileSizeFormatted(long bytes)
    {
        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
        double len = bytes;
        int order = 0;
        
        while (len >= 1024 && order < sizes.Length - 1)
        {
            order++;
            len /= 1024;
        }
        
        return $"{len:0.##} {sizes[order]}";
    }

    public static bool IsFileSizeValid(long bytes, long maxSizeMB = 50)
    {
        var maxBytes = maxSizeMB * 1024 * 1024;
        return bytes <= maxBytes;
    }

    public static string GetFileExtension(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            return string.Empty;

        return Path.GetExtension(fileName).ToLower();
    }

    public static string GenerateUniqueFileName(string originalFileName)
    {
        var extension = GetFileExtension(originalFileName);
        var timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
        var guid = Guid.NewGuid().ToString("N").Substring(0, 8);
        
        return $"{timestamp}_{guid}{extension}";
    }
}