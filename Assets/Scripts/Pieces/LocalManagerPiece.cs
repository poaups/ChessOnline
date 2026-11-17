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
        HoverPossibleWay();
        movementSystem.StartCoroutine(movementSystem.UpMovement());
    }

    public void UnSelect()
    {
        movementSystem.StartCoroutine(movementSystem.DownMovement());

        foreach (Vector2Int pos in pieceData.Movements)
        {
            Vector2Int way = new Vector2Int(currentPos.x + pos.x, currentPos.y + pos.y);
            LocalManagerCell managerOfCell = BoardManager.instance.GetCell(way);
            managerOfCell.UnHover();
        }
    }

    void HoverPossibleWay()
    {
        foreach(Vector2Int pos in pieceData.Movements)
        {
            Vector2Int way = new Vector2Int(currentPos.x + pos.x, currentPos.y + pos.y);
            LocalManagerCell managerOfCell = BoardManager.instance.GetCell(way);
            managerOfCell.Hover();
        }
        
    }
}
