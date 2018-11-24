using System;
using FractalPainting.App.Fractals;
using FractalPainting.Infrastructure.Common;
using FractalPainting.Infrastructure.Custom;
using FractalPainting.Infrastructure.Injection;
using FractalPainting.Infrastructure.UiActions;
using Ninject;

namespace FractalPainting.App.Actions
{

    public class DragonFractalAction : IUiAction
    {
        private readonly IDragonPointersFactory dragonPointersFactory;
        private readonly Func<DragonSettings> createSettings;

        public DragonFractalAction(IDragonPointersFactory dragonPointersFactory
        , Func<DragonSettings> createSettings)
        {
            this.dragonPointersFactory = dragonPointersFactory;
            this.createSettings = createSettings;
        }

        public string Category => "Фракталы";
        public string Name => "Дракон";
        public string Description => "Дракон Хартера-Хейтуэя";

        public void Perform()
        {
            var dragonSettings = createSettings();
            // редактируем настройки:
            SettingsForm.For(dragonSettings).ShowDialog();
            // создаём painter с такими настройками

            dragonPointersFactory.CreateDragonPointer(dragonSettings).Paint();
        }
        
    }
}