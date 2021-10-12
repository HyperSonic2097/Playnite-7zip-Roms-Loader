using Playnite.SDK;
using Playnite.SDK.Events;
using Playnite.SDK.Models;
using Playnite.SDK.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SevenZipRomsLoader
{
    public class SevenZipRomsLoader : Plugin
    {
        private static readonly ILogger logger = LogManager.GetLogger();

        private SevenZipRomsLoaderSettings settings { get; set; }

        public override Guid Id { get; } = Guid.Parse("f6755ec1-f0ef-4d54-9502-79fa4aa861fb");

        public SevenZipRomsLoader(IPlayniteAPI api) : base(api)
        {
            settings = new SevenZipRomsLoaderSettings(this);
        }

        public override void OnGameInstalled(OnGameInstalledEventArgs args)
        {
            base.OnGameInstalled(args);
        }

        public override void OnLibraryUpdated(OnLibraryUpdatedEventArgs args)
        {
            base.OnLibraryUpdated(args);
        }

        public override ISettings GetSettings(bool firstRunSettings)
        {
            return settings;
        }

        public override UserControl GetSettingsView(bool firstRunSettings)
        {
            return new SevenZipRomsLoaderSettingsView();
        }

        public override void OnGameStarting(OnGameStartingEventArgs args)
        {
            base.OnGameStarting(args);
        }

        public override void OnGameStarted(OnGameStartedEventArgs args)
        {
            base.OnGameStarted(args);
        }

        public override void OnGameStopped(OnGameStoppedEventArgs args)
        {
            base.OnGameStopped(args);
        }

        public override void OnGameUninstalled(OnGameUninstalledEventArgs args)
        {
            base.OnGameUninstalled(args);
        }

        public override void OnGameSelected(OnGameSelectedEventArgs args)
        {
            base.OnGameSelected(args);
        }

        public override void OnApplicationStarted(OnApplicationStartedEventArgs args)
        {
            base.OnApplicationStarted(args);
        }

        public override void OnApplicationStopped(OnApplicationStoppedEventArgs args)
        {
            base.OnApplicationStopped(args);
        }
    }
}