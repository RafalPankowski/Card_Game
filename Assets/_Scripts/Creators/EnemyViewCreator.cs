using UnityEngine;

public class EnemyViewCreator : Singleton<EnemyViewCreator>
{
    [SerializeField] private EnemyView enemyViewPrefarb;

    public EnemyView CreateEnemyView(EnemyData enemyData,Vector3 position, Quaternion rotation)
    {
        EnemyView enemyView = Instantiate(enemyViewPrefarb,position,rotation);
        enemyView.Setup(enemyData);
        return enemyView;
    }
}
