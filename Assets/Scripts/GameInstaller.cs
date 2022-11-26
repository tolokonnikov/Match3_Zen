using Zenject;

public class GameInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<Game>().AsSingle();

        Container.BindFactory<RedJevel, RedJevel.Factory>().WhenInjectedInto<JewelFactory>();
        Container.BindFactory<BlueJevel, BlueJevel.Factory>().WhenInjectedInto<JewelFactory>();
        Container.BindFactory<PurpleJevel, PurpleJevel.Factory>().WhenInjectedInto<JewelFactory>();
        Container.BindFactory<GreenJevel, GreenJevel.Factory>().WhenInjectedInto<JewelFactory>();
        Container.BindFactory<YellowJevel, YellowJevel.Factory>().WhenInjectedInto<JewelFactory>();

        Container.Bind<JewelFactory>().AsSingle();
        Container.Bind<JewelViewFactory>().AsSingle();
    }
}