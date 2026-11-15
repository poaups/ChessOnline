using UnityEngine;

public class InputPlayer : MonoBehaviour
{
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
                }
            }
        }
    }
}
