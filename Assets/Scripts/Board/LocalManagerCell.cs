using TMPro;
using UnityEngine;

public class LocalManagerCell : MonoBehaviour
{
    public Vector2Int PosOfCell { get; set; }
    [SerializeField] private TextMeshPro txt;
    
    public void SetIndex(Vector2Int index)
    {
        PosOfCell = index;
        txt.text = index.ToString();
    }
}
