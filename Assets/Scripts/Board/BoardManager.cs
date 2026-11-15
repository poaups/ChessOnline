using UnityEngine;

public class BoardManager : MonoBehaviour
{
    [SerializeField] private int size;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;

    private Vector3 spawn;
    private void Start()
    {
        spawn = spawnPoint.position;

        for (int i = 1; i <= size; i++)
        {
            for(int j = 1; j <= size; j++)
            {
                GameObject cell = Instantiate(prefab);
                cell.transform.position = new Vector3(spawn.x, spawn.y, spawn.z + (offsetX * j));
                cell.transform.SetParent(spawnPoint);
                cell.GetComponent<LocalManagerCell>().SetIndex(new Vector2Int(i, j));   

            }   

            spawn.x = spawnPoint.position.x + (offsetY * i);
        }
    }
}
