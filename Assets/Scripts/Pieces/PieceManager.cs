using UnityEngine;
using System.Collections.Generic;
public class PieceManager : MonoBehaviour
{
    [SerializeField] private List<LocalManagerPiece> pieceList;

    void Start()
    {
        foreach (LocalManagerPiece manager in pieceList)
        {
            manager.LocalStart();
        }
    }

    public void UpdatePosition(GameObject obj, Vector3 position)
    {
        obj.transform.position = position;
    }

}
