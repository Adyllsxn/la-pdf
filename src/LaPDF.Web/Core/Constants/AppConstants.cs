namespace LaPDF.Web.Core.Constants;
public static class AppConstants
{
    public const string AppName = "LaPDF";
    public const string AppVersion = "1.0.0";
    
    public const int DefaultMaxFileSizeMB = 50;
    public const int DefaultMaxPagesToProcess = 100;
    public const int DefaultMaxFilesToMerge = 10;
    
    public const string DefaultDateFormat = "yyyy-MM-dd HH:mm:ss";
    public const string DefaultFileExtension = ".pdf";
    
    public static readonly string[] AllowedExtensions = { ".pdf" };
    
    public static readonly string[] SizeUnits = { "B", "KB", "MB", "GB", "TB" };
    
    public static class ErrorMessages
    {
        public const string FileNotFound = "Arquivo não encontrado";
        public const string InvalidPdf = "Arquivo PDF inválido";
        public const string FileTooLarge = "Arquivo excede o tamanho máximo permitido";
        public const string NoFileSelected = "Nenhum arquivo foi selecionado";
        public const string ProcessingError = "Erro ao processar o arquivo";
        public const string MergeError = "Erro ao mesclar os arquivos";
        public const string SplitError = "Erro ao dividir o arquivo";
        public const string ConvertError = "Erro ao converter o arquivo";
    }
    
    public static class SuccessMessages
    {
        public const string FileCompressed = "Arquivo comprimido com sucesso";
        public const string FileMerged = "Arquivos mesclados com sucesso";
        public const string FileSplit = "Arquivo dividido com sucesso";
        public const string FileConverted = "Arquivo convertido com sucesso";
    }
}