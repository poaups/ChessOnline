using TMPro;
using UnityEngine;

public class LocalManagerCell : MonoBehaviour
{
    public Vector2Int PosOfCell { get; set; }
    [SerializeField] private TextMeshPro txt;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void SetIndex(Vector2Int index)
    {
        PosOfCell = index;
        txt.text = index.ToString();
    }

    public void Hover()
    {
        animator.Play("HoverCell");
    }
    public void UnHover()
    {
        animator.Play("UnHoverCell");
    }
}
