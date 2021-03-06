using System;

using Autofac.Extras.IocManager;

namespace Stove.Events.Bus.Handlers.Internals
{
    /// <summary>
    ///     This event handler is an adapter to be able to use an action as <see cref="IEventHandler{TEvent}" />
    ///     implementation.
    /// </summary>
    /// <typeparam name="TEvent">Event type</typeparam>
    internal class ActionEventHandler<TEvent> : IEventHandler<TEvent>, ITransientDependency
    {
        /// <summary>
        ///     Creates a new instance of <see cref="ActionEventHandler{TEvent}" />.
        /// </summary>
        /// <param name="handler">Action to handle the event</param>
        public ActionEventHandler(Action<TEvent, Headers> handler)
        {
            Action = handler;
        }

        /// <summary>
        ///     Action to handle the event.
        /// </summary>
        public Action<TEvent, Headers> Action { get; }

        public void Handle(TEvent @event, Headers headers)
        {
            Action(@event, headers);
        }
    }
}
