using System;
using Telegram.Bot;

namespace primerbot
{
    class Program
    {
        static ITelegramBotClient _botClient;
        static void Main(string[] args)
        {
            _botClient = new TelegramBotClient("1356479962:AAFaX0V4k3uC-9QaeIbyLcPIR9FixGAmNoc");
            var me = _botClient.GetMeAsync().Result;

            Console.WriteLine($"Hi, I am {me.Id} and my name is: {me.FirstName}");

            _botClient.OnMessage += _botClient_OnMessage;
            _botClient.StartReceiving();

            Console.WriteLine("Porfavor dime algo");

            Console.ReadKey();

            _botClient.StopReceiving();


        }

        private async static void _botClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if(e.Message.Text != null)
            {
                Console.WriteLine($"Mensaje recibido de parte de {e.Message.From.FirstName} {e.Message.From.LastName}");
                if(e.Message.Text.ToLower().Contains("mensaje"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $"Tú dijiste: {e.Message.Text}"
                    );
                } else if(e.Message.Text.ToLower().Contains("dan"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" Hola {e.Message.From.FirstName}, la campaña de Asesor DNA tiene hasta el momento 30 llamadas"
                    );
                } else if(e.Message.Text.ToLower().Contains("hola") || e.Message.Text.ToLower().Contains("dias") ||
                 e.Message.Text.ToLower().Contains("tardes") || (e.Message.Text.ToLower().Contains("buena") && e.Message.Text.ToLower().Contains("tarde")) ||
                  (e.Message.Text.ToLower().Contains("buenas") && e.Message.Text.ToLower().Contains("tardes")) || 
                  (e.Message.Text.ToLower().Contains("buenos") && e.Message.Text.ToLower().Contains("días")) ||
                   (e.Message.Text.ToLower().Contains("buenas") && e.Message.Text.ToLower().Contains("noches")) || 
                   (e.Message.Text.ToLower().Contains("buen") && e.Message.Text.ToLower().Contains("día")) || 
                   (e.Message.Text.ToLower().Contains("buen") && e.Message.Text.ToLower().Contains("día")) ||
                   (e.Message.Text.ToLower().Contains("buena") && e.Message.Text.ToLower().Contains("tarde")) || 
                   (e.Message.Text.ToLower().Contains("buena") && e.Message.Text.ToLower().Contains("noche")) ||
                   (e.Message.Text.ToLower().Contains("bonita") && e.Message.Text.ToLower().Contains("noche")) ||
                   (e.Message.Text.ToLower().Contains("bonita") && e.Message.Text.ToLower().Contains("tarde")) ||
                   (e.Message.Text.ToLower().Contains("bonito") && e.Message.Text.ToLower().Contains("día")) ||
                   (e.Message.Text.ToLower().Contains("bonito") && e.Message.Text.ToLower().Contains("dia")))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" Hola, {e.Message.From.FirstName}. ¿Cómo puedo ayudarte?"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("service") || e.Message.Text.ToLower().Contains("desk") || e.Message.Text.ToLower().Contains("estatus") || e.Message.Text.ToLower().Contains("general") ||
                e.Message.Text.ToLower().Contains("campañas") || e.Message.Text.ToLower().Contains("status") ||
                e.Message.Text.ToLower().Contains("service"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que el Service Desk"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 1000\n"+
                        " Llamadas Atendidas: 900\n"+
                        " Llamadas Atendidas antes de 20 seg: 900\n"+
                        " Llamadas Abandonadas: 1000\n"+
                        " %ABA: 10%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("gracias") || e.Message.Text.ToLower().Contains("tks") || e.Message.Text.ToLower().Contains("bye") || (e.Message.Text.ToLower().Contains("adiós")) || (e.Message.Text.ToLower().Contains("adios")))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" Muchas gracias, {e.Message.From.FirstName}. Estoy para apoyarte con gusto"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("cyc") || e.Message.Text.ToLower().Contains("credito") || e.Message.Text.ToLower().Contains("crédito"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de Crédito y Cobranza"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("tiendas") || e.Message.Text.ToLower().Contains("ventas") || e.Message.Text.ToLower().Contains("elektra"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de Tiendas Elektra"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("canales") || e.Message.Text.ToLower().Contains("terceros"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de Canales de Terceros"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("herramientas"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de Herramientas"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("hardware"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de Hardware"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("presta"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de PrestaPrenda"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("afore"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de AFORE"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("cmas"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de CMAS"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 100\n"+
                        " Llamadas Atendidas: 99\n"+
                        " Llamadas Atendidas antes de 20 seg: 90\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 1%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("oui"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, Te comento que la campaña de OUI"+
                        " a nivel general ha recibido\n"+
                        " Llamadas Entrantes: 10\n"+
                        " Llamadas Atendidas: 9\n"+
                        " Llamadas Atendidas antes de 20 seg: 9\n"+
                        " Llamadas Abandonadas: 1\n"+
                        " %ABA: 10%\n"+
                        " %SL: 90%\n"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("peñafiel"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" Carlos Peñafiel!, actualmente es el jefe de base de conocimientos"
                    );                    
                } else if((e.Message.Text.ToLower().Contains("apoyarme") && e.Message.Text.ToLower().Contains("quisieras")) || (e.Message.Text.ToLower().Contains("podrías") && e.Message.Text.ToLower().Contains("apoyarme")) || (e.Message.Text.ToLower().Contains("apoyarme") && e.Message.Text.ToLower().Contains("podrias")) || (e.Message.Text.ToLower().Contains("necesito") && e.Message.Text.ToLower().Contains("ayuda")) || (e.Message.Text.ToLower().Contains("quisiera") && e.Message.Text.ToLower().Contains("ayuda")) || (e.Message.Text.ToLower().Contains("apoyo") || e.Message.Text.ToLower().Contains("ayuda")) || e.Message.Text.ToLower().Contains("ayúdame") || e.Message.Text.ToLower().Contains("ayudame") || e.Message.Text.ToLower().Contains("apoyame"))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $"¿Cómo puedo ayudarte?"
                    );                    
                } else if((e.Message.Text.ToLower().Contains("víctor")) && (e.Message.Text.ToLower().Contains("montes")) || ((e.Message.Text.ToLower().Contains("victor")) && (e.Message.Text.ToLower().Contains("montes"))))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $"Actualmente es el gerente del Service Desk"
                    );                    
                }  else if(e.Message.Text.ToLower().Contains("slv") ||
                 (e.Message.Text.ToLower().Contains("nivel") && e.Message.Text.ToLower().Contains("servicio")) || 
                 (e.Message.Text.ToLower().Contains("service") && e.Message.Text.ToLower().Contains("level")) || 
                 (e.Message.Text.ToLower().Contains("sl") ))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, En este momento, el nivel de servicio a nivel general es: "+
                        " %SL: 90%\n"
                    );                    
                }  else if(e.Message.Text.ToLower().Contains("aba") || 
                (e.Message.Text.ToLower().Contains("abandono") && e.Message.Text.ToLower().Contains("general")) ||
                (e.Message.Text.ToLower().Contains("llamadas") && e.Message.Text.ToLower().Contains("perdidas")) ||
                (e.Message.Text.ToLower().Contains("abandono") || e.Message.Text.ToLower().Contains("perdidas")))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, En este momento, el porcentaje abandono a nivel general es: "+
                        " %ABA: 4%\n"+
                        "Esto porque se han perdido:\n"+
                        "Llamadas abandonadas: 234"
                    );                    
                } else if(e.Message.Text.ToLower().Contains("ocupacion") || 
                (e.Message.Text.ToLower().Contains("ocupacion") && e.Message.Text.ToLower().Contains("general")) ||
                (e.Message.Text.ToLower().Contains("occ") || e.Message.Text.ToLower().Contains("occy")) ||
                (e.Message.Text.ToLower().Contains("ocupación") && e.Message.Text.ToLower().Contains("general")) ||
                 (e.Message.Text.ToLower().Contains("ocupación") || e.Message.Text.ToLower().Contains("occ")))
                {
                    await _botClient.SendTextMessageAsync(
                        chatId: e.Message.Chat.Id,
                        text: $" {e.Message.From.FirstName}, En este momento, el porcentaje abandono a nivel general es: "+
                        " %ABA: 4%\n"+
                        "Esto porque se han perdido:\n"+
                        "Llamadas abandonadas: 234"
                    );                    
                }       
            }
        }
    }
}
