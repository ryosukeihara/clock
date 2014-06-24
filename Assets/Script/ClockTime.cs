using UnityEngine;
using System.Collections;
using System;

public class ClockTime : MonoBehaviour {

	[SerializeField]
	private UILabel dateTimeLabel;

	private DateTime dateTime;

	
	// Use this for initialization
	void Start () {

		dateTimeLabel = GameObject.Find("LabelDateTime").GetComponent<UILabel>();

		dateTime = new DateTime();

	}
	
	// Update is called once per frame
	void Update () {


		dateTimeLabel.text = DateTime.Now.ToString() +"  " ;

	}
}
