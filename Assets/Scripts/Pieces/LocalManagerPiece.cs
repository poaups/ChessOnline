using System.Collections;
using UnityEngine;

public class LocalManagerPiece : MonoBehaviour
{
    private PieceMovement movementSystem;

    public void LocalStart()
    {
        movementSystem = GetComponent<PieceMovement>();
    }

    public void OnSelect()
    {
        movementSystem.StartCoroutine(movementSystem.UpMovement());
    }
}
