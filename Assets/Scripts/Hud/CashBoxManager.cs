using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CashBoxManager : MonoBehaviour {

	public Text CashField;
	
	// Update is called once per frame
	void Update () {
		CashField.text = "Rs. " + (int)Player.Default.Credits;
	}
}
