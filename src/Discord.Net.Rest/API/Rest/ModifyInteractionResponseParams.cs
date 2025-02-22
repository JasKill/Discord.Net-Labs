using Newtonsoft.Json;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    internal class ModifyInteractionResponseParams
    {
        [JsonProperty("content")]
        public Optional<string?> Content { get; set; }
        [JsonProperty("embeds")]
        public Optional<Embed[]?> Embeds { get; set; }
        [JsonProperty("allowed_mentions")]
        public Optional<AllowedMentions> AllowedMentions { get; set; }
        [JsonProperty("components")]
        public Optional<ActionRowComponent[]?> Components { get; set; }
    }
}
