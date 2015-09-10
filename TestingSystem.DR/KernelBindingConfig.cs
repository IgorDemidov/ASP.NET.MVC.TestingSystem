using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using TestingSystem.BLL;
using TestingSystem.BLL.Abstract;
using TestingSystem.DAL.Abstract;
using TestingSystem.DAL.AbstractRepositories;
using TestingSystem.DAL.Repositories;

namespace TestingSystem.DR
{
    public static class KernelBindingConfig
    {
        public static void Configurate(this IKernel kernel)
        {
            kernel.Bind<ITestingService>().To<TestingService>();
            kernel.Bind<IThemeRepository>().To<ThemeRepository>().WhenInjectedInto<TestingService>();
            kernel.Bind<IQuestionRepository>().To<QuestionRepository>().WhenInjectedInto<TestingService>();
            kernel.Bind<IAnswerRepository>().To<AnswerRepository>().WhenInjectedInto<TestingService>();
        }
    }
}
