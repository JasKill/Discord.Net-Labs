using Discord.WebSocket;
using System;
using System.Threading.Tasks;

namespace Discord.SlashCommands
{
    /// <summary>
    /// Base class for creating TypeReaders. <see cref="SlashCommandService"/> uses TypeReaders to interface with Slash Command parameters
    /// </summary>
    public abstract class TypeReader
    {
        /// <summary>
        /// Will be used to search for alternative TypeReaders whenever the Command Service encounters an unknown parameter type
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public abstract bool CanConvertTo (Type type);

        /// <summary>
        /// Will be used to get the Application Command Option type
        /// </summary>
        /// <returns>The option type</returns>
        public abstract ApplicationCommandOptionType GetDiscordType ();

        /// <summary>
        /// Will be used to read the incoming payload before executing the method body
        /// </summary>
        /// <param name="context">Command exexution context</param>
        /// <param name="option">Recieved option payload</param>
        /// <param name="services">Service provider that will be used to initialize the command module</param>
        /// <returns>The result of the read process</returns>
        public abstract Task<TypeReaderResult> ReadAsync (ISlashCommandContext context, SocketSlashCommandDataOption option, IServiceProvider services);

        /// <summary>
        /// Will be used to manipulate the outgoing command option, before the command gets registered to Discord
        /// </summary>
        /// <param name="properties"></param>
        public virtual void Write(ApplicationCommandOptionProperties properties) { }
    }

    /// <inheritdoc/>
    public abstract class TypeReader<T> : TypeReader
    {
        public sealed override bool CanConvertTo (Type type) =>
            typeof(T).IsAssignableFrom(type);
    }
}
