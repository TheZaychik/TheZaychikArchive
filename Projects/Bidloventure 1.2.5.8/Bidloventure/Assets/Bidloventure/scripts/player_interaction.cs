using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;

public class player_interaction : MonoBehaviour
{
	//places
	public bool Levels = false;
	//UI bool

	public bool[] Levels_status;
	public float QuestTaken = 0;


	Transform pl;
	// coords
	public Vector3 coords;
	// Use this for initialization
	void Start()
	{
		pl = GetComponent<Transform>();
		Levels_status = new bool[3];
		LoadData();
		if (Levels)
		{
			pl.position = coords;
			Levels = false;
		}
		SaveData();
	}
	// Update is called once per frame
	void Update()
	{
		
	}


	public void LoadData()
	{
		using (StreamReader file = new StreamReader("BidloventureDat.txt"))
		{
			for (Int32 i = 0; i < Levels_status.Length; i++)
			{
				Levels_status[i] = Convert.ToBoolean(file.ReadLine());
			}
			coords.x = Convert.ToSingle(file.ReadLine());
			coords.y = Convert.ToSingle(file.ReadLine());
			Levels = Convert.ToBoolean(file.ReadLine());
			QuestTaken = Convert.ToSingle(file.ReadLine());
		}
	}
	public void SaveData()
	{
		using (StreamWriter file = new StreamWriter("BidloventureDat.txt"))
		{
			for (Int32 i = 0; i < Levels_status.Length; i++)
			{
				file.WriteLine(Levels_status[i]);
			}
			file.WriteLine(coords.x);
			file.WriteLine(coords.y);
			file.WriteLine(Levels);
			file.WriteLine(QuestTaken);
		}
	}

}