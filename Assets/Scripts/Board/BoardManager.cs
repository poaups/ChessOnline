using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager instance;
    [SerializeField] private int size;
    [SerializeField] private float offsetX;
    [SerializeField] private float offsetY;
    
    [SerializeField] private GameObject prefab;
    [SerializeField] private Transform spawnPoint;

    public LocalManagerCell[,] cells { get; set; }
 
    private Vector3 spawn;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        cells =  new LocalManagerCell[size + 1,size + 1];
        spawn = spawnPoint.position;

        for (int i = 1; i <= size; i++)
        {
            for(int j = 1; j <= size; j++)
            {
                GameObject cell = Instantiate(prefab);
                cell.transform.position = new Vector3(spawn.x, spawn.y, spawn.z + (offsetX * j));
                cell.transform.SetParent(spawnPoint);
                cell.GetComponent<LocalManagerCell>().SetIndex(new Vector2Int(i, j));

                cells[i, j] = cell.GetComponent<LocalManagerCell>(); 
            }   

            spawn.x = spawnPoint.position.x + (offsetY * i);
        }
    }

    public LocalManagerCell GetCell(Vector2Int caseToSet)
    {
        return cells[caseToSet.x, caseToSet.y];
    }


}
