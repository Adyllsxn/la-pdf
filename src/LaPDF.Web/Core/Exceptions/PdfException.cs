namespace LaPDF.Web.Core.Exceptions;
public class PdfException : Exception
{
    public PdfException() { }
    
    public PdfException(string message) : base(message) { }
    
    public PdfException(string message, Exception innerException) 
        : base(message, innerException) { }
}

public class InvalidPdfException : PdfException
{
    public InvalidPdfException() { }
    
    public InvalidPdfException(string message) : base(message) { }
    
    public InvalidPdfException(string message, Exception innerException) 
        : base(message, innerException) { }
}

public class FileTooLargeException : PdfException
{
    public FileTooLargeException() { }
    
    public FileTooLargeException(string message) : base(message) { }
    
    public FileTooLargeException(string message, Exception innerException) 
        : base(message, innerException) { }
}

public class FileNotFoundException : PdfException
{
    public FileNotFoundException() { }
    
    public FileNotFoundException(string message) : base(message) { }
    
    public FileNotFoundException(string message, Exception innerException) 
        : base(message, innerException) { }
}