using Zenject;
using UnityEngine;

public class PlayerInstaller : MonoInstaller {

	[SerializeField]
	private PlayerController controller;

	[SerializeField]
	private Aiming aim;

	[SerializeField]
	private Life life;

	[SerializeField]
	private Score score;
		public override void InstallBindings()
		{
			Container.Bind<PlayerController>().FromInstance(controller);
			Container.Bind<Aiming>().FromInstance(aim);
			Container.Bind<Life>().FromInstance(life);
			Container.Bind<Score>().FromInstance(score);
			Container.BindInterfacesTo<PlayerControllerZenject>().AsSingle();
			Container.BindInterfacesTo<AimingZenject>().AsSingle();
			Container.BindInterfacesTo<LifeZenject>().AsSingle();
			Container.BindInterfacesTo<ScoreZenject>().AsSingle();

		}
}
