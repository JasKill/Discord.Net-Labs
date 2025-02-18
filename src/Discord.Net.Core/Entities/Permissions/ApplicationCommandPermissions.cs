namespace Discord
{
    /// <summary>
    ///     Application command permissions allow you to enable or disable commands for specific users or roles within a guild.
    /// </summary>
    public class ApplicationCommandPermission
    {
        /// <summary>
        ///     The id of the role or user.
        /// </summary>
        public ulong TargetId { get; }

        /// <summary>
        ///     The target of this permission.
        /// </summary>
        public PermissionTarget TargetType { get; }

        /// <summary>
        ///     <see langword="true"/> to allow, otherwise <see langword="false"/>.
        /// </summary>
        public bool Permission { get; }

        internal ApplicationCommandPermission() { }

        /// <summary>
        ///     Creates a new <see cref="ApplicationCommandPermission"/>.
        /// </summary>
        /// <param name="targetId">The id you want to target this permission value for.</param>
        /// <param name="targetType">The type of the <b>targetId</b> parameter.</param>
        /// <param name="allow">The value of this permission.</param>
        public ApplicationCommandPermission(ulong targetId, PermissionTarget targetType, bool allow)
        {
            this.TargetId = targetId;
            this.TargetType = targetType;
            this.Permission = allow;
        }

        /// <summary>
        ///     Creates a new <see cref="ApplicationCommandPermission"/> targeting <see cref="PermissionTarget.User"/>.
        /// </summary>
        /// <param name="target">The user you want to target this permission value for.</param>
        /// <param name="allow">The value of this permission.</param>
        public ApplicationCommandPermission(IUser target, bool allow)
        {
            this.TargetId = target.Id;
            this.Permission = allow;
            this.TargetType = PermissionTarget.User;
        }

        /// <summary>
        ///     Creates a new <see cref="ApplicationCommandPermission"/> targeting <see cref="PermissionTarget.Role"/>.
        /// </summary>
        /// <param name="target">The role you want to target this permission value for.</param>
        /// <param name="allow">The value of this permission.</param>
        public ApplicationCommandPermission(IRole target, bool allow)
        {
            this.TargetId = target.Id;
            this.Permission = allow;
            this.TargetType = PermissionTarget.Role;
        }
    }
}
