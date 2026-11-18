using UnityEngine;
using System.Collections.Generic;
public class InputPlayer : MonoBehaviour
{
    private LocalManagerPiece previousPiecesSelected;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                LocalManagerPiece dataPiece = hitInfo.collider.GetComponent<LocalManagerPiece>();
                if (dataPiece != null)
                {
                    dataPiece.OnSelect();
                    ResetPieceSelected();

                    previousPiecesSelected = dataPiece;
                }
            }
        }
    }


    void ResetPieceSelected()
    {
        if(previousPiecesSelected != null)
        {
            previousPiecesSelected.UnSelect();
        }
    }
}
