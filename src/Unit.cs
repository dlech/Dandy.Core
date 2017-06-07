using System;

namespace Core
{
    /// <summary>
    /// Type that indicates the absence of a specific value.
    /// </summary>
    /// <remarks>
    /// This type is used a a placeholder when a type is needed but
    /// no value exists or is needed. For example, since C# can't
    /// use <see cref="Void"/> as a type parameter, you can use this
    /// instead.
    /// </remarks>
    /// <example>
    /// This shows how <see cref="Unit"/> can be used where normally
    /// <see cref="void"/> is used.
    /// <code>
    /// class Example
    /// {
    ///     // C# has separate Action and Func&lt;T&gt; classes because Action
    ///     // returns void and Func&lt;T&gt; returns a type. However, using Unit
    ///     // we can make a Func&lt;T&gt; that is equivalent to Action.
    ///     Action func2 = () => doSomething();
    ///     Func&lt;Unit&gt; func1 = () => {
    ///         doSomething();
    ///         return Unit.Value;
    ///     };
    /// }
    /// </code>
    /// </example>
    public struct Unit
    {
        /// <summary>
        /// The only possible value of <see cref="Unit"/>.
        /// </summary>
        public static Unit Value => new Unit();
    }
}
