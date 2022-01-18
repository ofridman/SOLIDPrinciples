using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartObj : MonoBehaviour , IPart  
{
	#region PROPERTIES

	public string PartId
	{
		get { return partId; }
		set { partId = value; }
	}

	public string PartName
	{
		get { return partName; }
		set { partName = value; }
	}

	public string TooltipInformation
	{
		get { return tooltipInformation; }
		set { tooltipInformation = value; }
	}

	public Sprite PartImage
	{
		get { return partImage; }
		set { partImage = value; }
	}

	public GameObject PartModel
	{
		get { return partModel; }
		set { partModel = value; }
	}
	public AnimationClip AnimClip
	{
		get { return animClip; }
		set { animClip = value; }
	}

	#endregion PROPERTIES

	#region SerializeField

	[Header("Parts Data")]
	[SerializeField]
	private string partId;

	[SerializeField]
	private string partName;

	[SerializeField]
	private string tooltipInformation;

	[SerializeField]
	private Sprite partImage;

	[SerializeField]
	private GameObject partModel;

	[SerializeField]
	private AnimationClip animClip;

	#endregion SerializeField

	#region Private Variables

	private Vector3 _initPos;
	private Vector3 _initRot;

	#endregion Private Variables

	#region Functions

	public void PlayAnimation()
	{
		Debug.Log("Playing Animation -> " + partId);
	}

	#endregion Functions

}
