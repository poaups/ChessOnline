using UnityEngine;
using System.Collections;
public class PieceMovement : MonoBehaviour
{
    [SerializeField] private float offset;
    [SerializeField] private float power;

    private GameManager gm;
    public IEnumerator UpMovement()
    {
        Vector3 finalPos = new Vector3(transform.position.x, transform.position.y + offset, transform.position.z);
        while (transform.position.y <= finalPos.y)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power);

            yield return null;
        }
    }

    public IEnumerator DownMovement()
    {
        Vector3 finalPos = new Vector3(transform.position.x, transform.position.y - offset, transform.position.z);
        while (transform.position.y >= finalPos.y)
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * power);

            yield return null;
        }
    }
}
