using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour {

	private Item item;
	private string data;
	private GameObject tooltip;

	void Start () {
		tooltip = GameObject.Find ("Tooltip");
		tooltip.SetActive (false);

	}

	void Update ()
	{
	if (tooltip.activeSelf == true) 
		{
			//possibly needs to be removed (Optional)
			tooltip.transform.position = Input.mousePosition;
		}

	}

	public void Activate(Item item)
	{
		this.item = item;
		ConstructDataString ();
		tooltip.SetActive (true);
	}

	public void Deactivate()
	{
		tooltip.SetActive (false);
	}

	public void ConstructDataString()
	{
		//fill out tooltip - works, just is empty
		data = item.Title + "\n\n" + item.Description + "\n\n";
		tooltip.transform.GetChild (0).GetComponent<Text>().text = data;
	}
}
