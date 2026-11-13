using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Ready : MonoBehaviour
{
    public GameObject Button1;
    public GameObject Button2;

    public TextMeshProUGUI txt;

    int playerReady = 0;



    public void ButtonReady(GameObject self, int index)
    {
        self.GetComponent<Button>().image.color = Color.green;
        playerReady++;
        UpdatePlayerReady();
    }

    void UpdatePlayerReady()
    {
        txt.text = playerReady.ToString() + "/2"; 
    }

}
