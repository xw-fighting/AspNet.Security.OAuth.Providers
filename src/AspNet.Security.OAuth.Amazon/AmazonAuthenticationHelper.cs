/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OAuth.Providers
 * for more information concerning the license and the contributors participating to this project.
 */

using JetBrains.Annotations;
using Newtonsoft.Json.Linq;

namespace AspNet.Security.OAuth.Amazon
{
    /// <summary>
    /// Contains static methods that allow to extract user's information from a <see cref="JObject"/>
    /// instance retrieved from Amazon after a successful authentication process.
    /// </summary>
    public static class AmazonAuthenticationHelper
    {
        /// <summary>
        /// Gets the email corresponding to the authenticated user.
        /// </summary>
        public static string GetEmail([NotNull] JObject user) => user.Value<string>("email");

        /// <summary>
        /// Gets the identifier corresponding to the authenticated user.
        /// </summary>
        public static string GetIdentifier([NotNull] JObject user) => user.Value<string>("user_id");

        /// <summary>
        /// Gets the name corresponding to the authenticated user.
        /// </summary>
        public static string GetName([NotNull] JObject user) => user.Value<string>("name");

        /// <summary>
        /// Gets the postal code corresponding to the authenticated user.
        /// </summary>
        public static string GetPostalCode([NotNull] JObject user) => user.Value<string>("postal_code");
    }
}
