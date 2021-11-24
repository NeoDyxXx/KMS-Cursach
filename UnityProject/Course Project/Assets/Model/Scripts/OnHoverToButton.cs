using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

public class OnHoverToButton : EventTrigger
{
	GameObject changeColorObject;
	Transform transformCamera;
	List<Renderer> gameObjectsIntoInstall;
	List<Color> materials;
	GameObject camera;
	bool move = false;
	float speed = 0.04f;
	float offset = 0;

	void Start()
	{
		changeColorObject = GameObject.Find(this.name.Split('B')[0]);
		transformCamera = GameObject.Find("cameraPos" + this.name.Split('B')[0]).GetComponent<Transform>();
		camera = GameObject.Find("Main Camera");
		gameObjectsIntoInstall = new List<Renderer>(changeColorObject.GetComponentsInChildren<Renderer>() as Renderer[]);
		materials = gameObjectsIntoInstall.Select(item => item.material.color).ToList();
	}

	void FixedUpdate()
	{
		if (move)
		{
			offset += speed;
			camera.transform.position = Vector3.Lerp(camera.transform.position, transformCamera.position, offset);
			camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, transformCamera.rotation, offset);

			if (offset >= 1)
			{
				move = false;
				offset = 0;
			}
		}
	}

	public override void OnPointerClick(PointerEventData eventData)
	{
		move = true;
	}

	public override void OnPointerEnter(PointerEventData data)
	{
		foreach(var item in gameObjectsIntoInstall)
		{
			item.material.color = Color.black * 0.3f;
		}
	}

	public override void OnPointerExit(PointerEventData eventData)
	{
		for (int i = 0; i < gameObjectsIntoInstall.Count; i++)
		{
			gameObjectsIntoInstall[i].material.color = materials[i];
		}
	}
}
