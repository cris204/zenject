using Zenject;
using UnityEngine;

public class SceneInstaller : MonoInstaller {

	[SerializeField]
	private GameObject bulletPrefab;

	[SerializeField]
	private GameObject asteroidPrefab;

	[SerializeField]
	private Fire fire;

	[SerializeField]
	private AsteroidsActive asteroidActive;
	public override void InstallBindings()
	{
		Container.Bind<BulletPool>().AsSingle();
		Container.Bind<Fire>().FromInstance(fire);
		Container.Bind<AsteroidsActive>().FromInstance(asteroidActive);
		Container.BindMemoryPool<BulletBehaviour, BulletBehaviour.Pool>().WithInitialSize(10).FromComponentInNewPrefab(bulletPrefab);
		Container.Bind<AsteoridsPool>().AsSingle();
		Container.BindMemoryPool<AsteroidsBehavoiur, AsteroidsBehavoiur.Poolito>().WithInitialSize(10).FromComponentInNewPrefab(asteroidPrefab).NonLazy();

	}

}
