using AlterSpamTool.Model;

namespace AlterSpamTool.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AlterSpamToolDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AlterSpamToolDbContext context)
        {
            context.Senders.AddOrUpdate(
                s => s.Name,
                new Sender { Address = "address@yandex.ru", Name = "MainSender", Password = "P@ssW0rD" },
                new Sender { Address = "address@gmail.com", Name = "SecondarySender", Password = "Dr0Wss@P" },
                new Sender { Address = "address@mail.ru", Name = "AlternateSender", Password = "ss@PDr0W" },
                new Sender { Address = "address@inbox.ru", Name = "ReserveSender", Password = "W0rDP@ss" }
                );
        }
    }
}
