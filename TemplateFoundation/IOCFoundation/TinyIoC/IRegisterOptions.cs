using System;
using System.Linq.Expressions;

namespace TemplateFoundation.IOCFoundation.TinyIoC
{
    public interface IRegisterOptions
    {
        IRegisterOptions AsSingleton();
        IRegisterOptions AsMultiInstance();
        IRegisterOptions WithWeakReference();
        IRegisterOptions WithStrongReference();
        IRegisterOptions UsingConstructor<TRegisterType>(Expression<Func<TRegisterType>> constructor);
    }
}