using System;

public class Telegram
{
    // Envio de mensagens de TEXTO
    public void EnviarMensagem(long numero, TextMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de texto para o número {numero}: {message.Conteudo}");
    }

    public void EnviarMensagem(string username, TextMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando mensagem de texto para o usuário @{username}: {message.Conteudo}");
    }

    // Envio de VÍDEO
    public void EnviarMensagem(long numero, VideoMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando vídeo para o número {numero} (arquivo: {message.Arquivo}, formato: {message.Formato}, duração: {message.Duracao}s)");
    }

    public void EnviarMensagem(string username, VideoMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando vídeo para o usuário @{username} (arquivo: {message.Arquivo}, formato: {message.Formato}, duração: {message.Duracao}s)");
    }

    // Envio de FOTO
    public void EnviarMensagem(long numero, PhotoMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando foto para o número {numero} (arquivo: {message.Arquivo}, formato: {message.Formato})");
    }

    public void EnviarMensagem(string username, PhotoMessage message)
    {
        Console.WriteLine($"[Telegr1am] Enviando foto para o usuário @{username} (arquivo: {message.Arquivo}, formato: {message.Formato})");
    }

    // Envio de ARQUIVO
    public void EnviarMensagem(long numero, FileMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando arquivo para o número {numero} (arquivo: {message.Arquivo}, formato: {message.Formato})");
    }

    public void EnviarMensagem(string username, FileMessage message)
    {
        Console.WriteLine($"[Telegram] Enviando arquivo para o usuário @{username} (arquivo: {message.Arquivo}, formato: {message.Formato})");
    }
}

