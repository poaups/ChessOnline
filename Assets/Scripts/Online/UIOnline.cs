//using UnityEngine;
//using System.Collections;
//using System.Collections.Generic;
//using PlayerIOClient;

//public class UIOnline : MonoBehaviour
//{
//	[SerializeField] private Ready ready;
//	private Connection UiPioConnection;

//    public void LocalStart()
//    {
//		//print("iic");
//		//print(UiPioConnection);
//		//print(GameManager.insntace.GetConnection());
//		//UiPioConnection = GameManager.insntace.GetConnection();
//		//print(UiPioConnection);

//	}
//    private List<Message> msgList = new List<Message>(); //  Messsage queue implementation
//	void FixedUpdate()
//	{
//		//foreach (Message m in msgList)
//		//{
//		//	switch (m.Type)
//		//	{
//		//		case "BReady":
//		//			print("BREADY CASE");
//		//			ready.SetColorByIndex(m.GetInt(0));
//		//			break;
//		//	}
//		//}

//		//msgList.Clear();
//	}

//	//public void ButtonColor(int index)
//	//{
//	//	//print("Send to server");
//	//	//print(UiPioConnection);
//	//	//GameManager.insntace.pioconnection.Send("BReady", index);
//	//}

//}
