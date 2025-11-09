// See https://aka.ms/new-console-template for more information
Console.WriteLine("***Organizador de Envio de Mensagens***\n");

Console.WriteLine("Para qual canal você quer enviar mensagem?");
Console.WriteLine("1. WhatsApp");
Console.WriteLine("2. Telegram");
Console.WriteLine("3. Instagram");
Console.WriteLine("4. Facebook");

int canal = 0;
string resposta = Console.ReadLine();
if (!int.TryParse(resposta, out canal))
{
    Console.WriteLine("Opção inválida");
    return;
}

// Criando mensagens de exemplo
TextMessage messageBase = new TextMessage("Olá! Esta é uma mensagem de teste.");
VideoMessage video = new VideoMessage("Olá! Este é um vídeo de teste.");

// Escolhendo o canal e enviando
if (canal == 1)
{
    var whats = new WhatsApp();
    whats.EnviarMensagem("12345678", messageBase);
    whats.EnviarMensagem("87654321", video);
}
else if (canal == 2)
{
    var telegram = new Telegram();
    telegram.EnviarMensagem(12345678, messageBase);
    telegram.EnviarMensagem("usuario_telegram", video);
}
else if (canal == 3)
{
    var insta = new Instagram();
    insta.EnviarMensagem("usuario_insta", messageBase);
    insta.EnviarMensagem("usuario_insta", video);
}
else if (canal == 4)
{
    var facebook = new Facebook();
    facebook.EnviarMensagem("usuario_fb", messageBase);
    facebook.EnviarMensagem("usuario_fb", video);
}
else
{
    Console.WriteLine("Opção inválida");
}

// Finalização estética
Console.WriteLine("\nMensagem enviada com sucesso!");
Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadKey();
