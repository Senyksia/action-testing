namespace InfiniteFriends
{
    /// <summary>
    /// The main metadata of the plugin.
    /// This information is used for BepInEx plugin metadata.
    /// </summary>
    internal static class PluginInfo
    {
        /// <summary>
        /// Human-readable name of the plugin. In general, it should be short and concise.
        /// This is the name that is shown to the users who run BepInEx and to modders that inspect BepInEx logs. 
        /// </summary>
        public const string PLUGIN_NAME = "InfiniteFriends";

        public const string PLUGIN_SHORT_NAME = "IF";

        /// <summary>
        /// Unique ID of the plugin.
        /// This must be a unique string that contains only characters a-z, 0-9 underscores (_) and dots (.)
        /// Prefer using the reverse domain name notation: https://eqdn.tech/reverse-domain-notation/
        ///
        /// When creating Harmony patches, prefer using this ID for Harmony instances as well.
        /// </summary>
        public const string PLUGIN_ID = "com.senyksia.spiderheck.infinitefriends";

        /// <summary>
        /// Version of the plugin. Must be in form <major>.<minor>.<build>.<revision>.
        /// Major and minor versions are mandatory, but build and revision can be left unspecified.
        /// </summary>
        public const string PLUGIN_VERSION = "0.1.0";
    }
}
