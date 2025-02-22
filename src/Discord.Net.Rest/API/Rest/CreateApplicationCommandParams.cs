using Discord.API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class CreateApplicationCommandParams
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("options")]
        public Optional<ApplicationCommandOption[]> Options { get; set; }
        [JsonProperty("default_permission")]
        public Optional<bool> DefaultPermission { get; set; }

        public CreateApplicationCommandParams (string name, string description, ApplicationCommandOption[] options = null)
        {
            Preconditions.SlashCommandName(name, nameof(name));
            Preconditions.SlashCommandDescription(description, nameof(description));

            Name = name;
            Description = description;
            if(options != null)
              Options = options;
        }
    }
}
