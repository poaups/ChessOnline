using System.Collections;
using System.Data;
using UnityEngine;

public class LocalManagerPiece : MonoBehaviour
{
    [SerializeField] private PieceData pieceData;
    [SerializeField] private Vector2Int currentPos;
    private PieceMovement movementSystem;

    public void LocalStart()
    {
        movementSystem = GetComponent<PieceMovement>();
    }

    public void OnSelect()
    {
        print("Je suis " + gameObject.name + " a la pos : " + currentPos);
        movementSystem.StartCoroutine(movementSystem.UpMovement());
    }
}
