using System;

namespace Abp.Dependency
{
    /// <summary>
    ///此接口用于包装是从IOC容器解析的对象。
    ///它继承了<see cref="IDisposable.Dispose"/>，这样解析的对象可以很容易地释放出来。
    ///在<see cref="IDisposable.Dispose"/>方法， <see cref="IIocResolver.Release"/>被称为处置的对象。
    /// </summary>
    /// <typeparam name="T">Type of the object</typeparam>
    public interface IDisposableDependencyObjectWrapper<out T> : IDisposable
    {
        /// <summary>
        /// The resolved object.
        /// </summary>
        T Object { get; }
    }

    /// <summary>
    ///此接口用于包装是从IOC容器解析的对象。
    ///它继承了<see cref="IDisposable"/>，这样解析的对象可以很容易地释放出来。
    ///在<see cref="IDisposable.Dispose"/>方法，<see cref="IIocResolver.Release"/>被称为处置的对象。
    ///这是<see cref="IDisposableDependencyObjectWrapper{T}"/>接口不通用版本。
    /// </summary>
    public interface IDisposableDependencyObjectWrapper : IDisposableDependencyObjectWrapper<object>
    {

    }
}