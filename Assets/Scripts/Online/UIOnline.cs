using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using PlayerIOClient;

public class UIOnline : MonoBehaviour
{
	[SerializeField] private Ready ready;
	private Connection UiPioConnection;

    private void Start()
    {
		UiPioConnection = GameManager.insntace.pioconnection;

	}
    private List<Message> msgList = new List<Message>(); //  Messsage queue implementation
	void FixedUpdate()
	{
		foreach (Message m in msgList)
		{
			switch (m.Type)
			{
				case "BReady":
					print("BREADY CASE");
					ready.SetColorByIndex(m.GetInt(0));
					break;
			}
		}

		msgList.Clear();
	}

	public void ButtonColor(int index)
	{
		print("Send to server");
		print(UiPioConnection);
		UiPioConnection.Send("BReady", index);
	}

}
