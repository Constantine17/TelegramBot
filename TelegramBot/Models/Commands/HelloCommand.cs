using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Models.Commands
{
    public class HelloCommand : Command
    {
        public override string Name => "Hello";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messegeId = message.MessageId;

            await client.SendTextMessageAsync(chatId, "Hello!", replyToMessageId: messegeId);
        }
    }
}