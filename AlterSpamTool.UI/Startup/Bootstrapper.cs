using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlterSpamTool.DataAccess;
using AlterSpamTool.UI.Data;
using AlterSpamTool.UI.View;
using AlterSpamTool.UI.ViewModel;
using Autofac;

namespace AlterSpamTool.UI.Startup
{
    /// <summary>
    /// Загрузчик
    /// </summary>
    public class Bootstrapper
    {
        /// <summary>
        /// Регистрация сервисов
        /// </summary>
        /// <returns></returns>
        public IContainer Bootstrap()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AlterSpamToolDbContext>().AsSelf();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<EditPanelViewModel>().AsImplementedInterfaces();

            builder.RegisterType<LookupDataService>().AsImplementedInterfaces();
            builder.RegisterType<SenderDataService>().As<ISenderDataService>();

            return builder.Build();
        }
    }
}
