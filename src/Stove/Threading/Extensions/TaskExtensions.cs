﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Stove.Threading.Extensions
{
    /// <summary>
    ///     Represents extensions on Tasks.
    /// </summary>
    public static class TaskExtensions
    {
        /// <summary>
        ///     ConfigureAwait(false)
        /// </summary>
        public static ConfiguredTaskAwaitable NotOnCapturedContext(this Task task)
        {
            return task.ConfigureAwait(false);
        }

        /// <summary>
        ///     ConfigureAwait(false)
        /// </summary>
        public static ConfiguredTaskAwaitable<T> NotOnCapturedContext<T>(this Task<T> task)
        {
            return task.ConfigureAwait(false);
        }
    }
}
