// <copyright file="IUserService.cs" company="Ivan Paulovich">
// Copyright © Ivan Paulovich. All rights reserved.
// </copyright>

namespace Application.Services
{
    using Domain.Security;

    /// <summary>
    ///     User Service.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        ///     Gets the Current User.
        /// </summary>
        /// <returns>User.</returns>
        IUser GetCurrentUser();
    }
}
