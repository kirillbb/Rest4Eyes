using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rest4Eyes
{
    internal static class Notification
    {
        public static void Hello()
        {
            new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Приложение Rest4Eyes запущено в системном трее!")
                    .AddText("Настройте свой таймер, пока мы не научили эту железяку запоминать ваши предпочтения :)")
                    .AddInlineImage(new Uri(@"C:\Users\Kirill\source\repos\Rest4Eyes\media\eye.ico"))
                    .Show();
        }

        public  static void SaveSuccesed()
        {
            new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9813)
                    .AddText("Настройки сохранены!")
                    .AddInlineImage(new Uri(@"C:\Users\Kirill\source\repos\Rest4Eyes\media\eye.ico"))
                    .Show();
        }
        public static void Error()
        {
            new ToastContentBuilder()
                    .AddArgument("action", "viewConversation")
                    .AddArgument("conversationId", 9800)
                    .AddText("Упс! Что-то пошло не так!")
                    .AddText("Возможно, где-то ошибка")
                    .Show();
        }
        public static void TimeToRest()
        {
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Пора отдохнуть!")
                .AddText("")
                .AddInlineImage(new Uri(@"C:\Users\Kirill\source\repos\Rest4Eyes\media\eye.ico"))
                .Show();
        }

        public static void TimeToWork()
        {
            new ToastContentBuilder()
                       .AddArgument("action", "viewConversation")
                       .AddArgument("conversationId", 9813)
                       .AddText("Вперёд к работе!")
                       .AddText("её ж должен кто-то работать??")
                       .AddInlineImage(new Uri(@"C:\Users\Kirill\source\repos\Rest4Eyes\media\eye2.ico"))
                       .Show();
        }
    }
}
