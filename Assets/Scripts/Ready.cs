using TMPro;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
	[SerializeField] private List<GameObject> allButtons = new List<GameObject>();
	[SerializeField] private TextMeshProUGUI txt;
    //[SerializeField] private UIOnline uiOnline;
    [SerializeField] private GameManager gm;

    int playerReady = 0;

    public void ButtonReady(int indexButton)
    {
        Debug.Log("ButtonReady");
        gm.ButtonColor(indexButton);
    }

    void UpdatePlayerReady()
    {
        txt.text = playerReady.ToString() + "/2"; 
    }

    public void SetColorByIndex(int index)
    {
        print("SetColorByIndex");
        allButtons[index].GetComponent<Button>().image.color = Color.green;

        playerReady++;
        UpdatePlayerReady();
    }

}
