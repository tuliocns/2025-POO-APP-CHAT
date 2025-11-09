// Classe base para mensagens que contêm mídia (foto, vídeo, arquivo)
public class MediaMessage : MessageBase
{
    public string FileName { get; set; }  // Caminho ou nome do arquivo
    public string Format { get; set; }    // Ex: .jpg, .mp4, .pdf

    public MediaMessage(string message) : base(message) { }
}

// Mensagem de vídeo, inclui duração
public class VideoMessage : MediaMessage
{
    public int Duration { get; set; } // Duração em segundos

    public VideoMessage(string message) : base(message) { }
}

// Mensagem de foto
public class PhotoMessage : MediaMessage
{
    public PhotoMessage(string message) : base(message) { }
}

// Mensagem de arquivo (documentos, planilhas, etc.)
public class FileMessage : MediaMessage
{
    public FileMessage(string message) : base(message) { }
}
