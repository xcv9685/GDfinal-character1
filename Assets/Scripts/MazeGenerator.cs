using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class MazeGenerator : MonoBehaviour
{
	public Camera begincamera;
	public BaseMaze maze;
	public int width = 10;
	public int height = 10;
	public int roomTestCount = 10;
	public bool playAnimation = true;
	public AlgorithmBase algorithm;
	private GameObject enemy,player,friend1,friend2;
	private int has_created;
	float timer= 0f;
	GameObject enemyspawn;
	float spawn_x,spawn_z;
	private RoomGenerator m_roomGenerator;
	public float castlex,castlez;
	void Start()
	{
		has_created = 0;
		algorithm = new BacktrackingAlgorithm (this);
		GenerateRoomAndMaze();
		/*spawn_x = UnityEngine.Random.Range (0, 30) * 10;
		spawn_z = UnityEngine.Random.Range (0, 30) * 10;
		if (Math.Abs (spawn_x - m_roomGenerator.room_object.transform.position.x) < 50 || Math.Abs (spawn_z - m_roomGenerator.room_object.transform.position.z) < 50) {
			spawn_x = UnityEngine.Random.Range (0, 30) * 10;
			spawn_z = UnityEngine.Random.Range (0, 30) * 10;
		}
		print (spawn_x);
		print (spawn_z);
		//enemyspawn = GameObject.Instantiate (Resources.Load ("Cell_06") as GameObject);
		//enemyspawn.transform.position = new Vector3 (spawn_x , 1f, spawn_z);*/
	}
	void Update(){
		/*timer += Time.deltaTime;
		if (timer > 10f && !algorithm.IsGenerating) {
			enemy = GameObject.Instantiate (Resources.Load ("knightprefab-maul") as GameObject);
			print (spawn_x);
			print (spawn_z);
			enemy.transform.position = new Vector3 (50, -1.0f, 50);
			//enemy.transform.position = new Vector3 (0, -1.0f, 0);
			print (enemy.transform.position);
			print ("create enemy f");
			timer = 0f;
		}*/
		if (!algorithm.IsGenerating && has_created==0) {
			enemy = GameObject.Instantiate (Resources.Load ("knightprefab-maul") as GameObject);
			enemy.transform.position = new Vector3 (40, -0.9f, 40);
			print ("create enemy f");
			player = GameObject.Instantiate (Resources.Load ("M3DFemale") as GameObject);
			player.transform.position = new Vector3 (m_roomGenerator.castle_x,m_roomGenerator.castle_y,m_roomGenerator.castle_z);
			has_created = 1;
			friend1 = GameObject.Instantiate (Resources.Load ("Friend") as GameObject);
			friend1.transform.position = new Vector3 (m_roomGenerator.castle_x,m_roomGenerator.castle_y,m_roomGenerator.castle_z-25);
			friend2 = GameObject.Instantiate (Resources.Load ("Friend") as GameObject);
			friend2.transform.position = new Vector3 (m_roomGenerator.castle_x-10,m_roomGenerator.castle_y,m_roomGenerator.castle_z-25);
			begincamera.gameObject.SetActive (false);
		}
	}
	/*private void SetupCamera()
	{
		Camera.main.transform.position = new Vector3 (width - 1, height - 1, -20) / 2;

		if(Screen.width > Screen.height)
		{
			float ratio = (float)Screen.width / Screen.height;

			if((float)width / height > ratio)
				Camera.main.orthographicSize = (float)width / 2 + 1;
			else
				Camera.main.orthographicSize = (float)height / 2 + 1;
		}
		else
		{
			float ratio = (float)Screen.height / Screen.width;

			if((float)height / width > ratio)
				Camera.main.orthographicSize = (float)height / 2 + 1;
			else
				Camera.main.orthographicSize = (float)width / 2 + 1;
		}
	}*/


	private void InitializeMaze()
	{
		//SetupCamera ();
		maze.InitializeMaze(width, height);
	}


	private bool IsGenerating()
	{
		if (null != algorithm && algorithm.IsGenerating)
		{
			return true;
		}

		return false;
	}


	public void GenerateMaze()
	{
		if(IsGenerating())
		{
			return;
		}

		StopGenerateMaze ();
		InitializeMaze ();
		StartGenerateMaze ();
	}


	public void GenerateRoom()
	{
		if(IsGenerating())
		{
			return;
		}

		InitializeMaze ();
		StartCreateRoom();
	}


	public void GenerateRoomAndMaze()
	{
		if(IsGenerating())
		{
			return;
		}

		//StopGenerateMaze();
		InitializeMaze();
		StartCreateRoom();
		StartGenerateMaze(m_roomGenerator.CreateDoors);
		castlex = m_roomGenerator.castle_x;
		castlez = m_roomGenerator.castle_z;
	}


	private void StartCreateRoom()
	{
		m_roomGenerator = new RoomGenerator(this, roomTestCount);
		m_roomGenerator.Generate ();
	}


	private void StartGenerateMaze(Action callback = null)
	{
		StartCoroutine(algorithm.Update(playAnimation, callback));
	}


	private void StopGenerateMaze()
	{
		//StopCoroutine(algorithm.Update(playAnimation));
	}
}