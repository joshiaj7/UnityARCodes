/*
Scene		: Brosur_Test
Component	: BrosurTarget
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;


public class vButtonScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject vButton;

	// Use this for initialization
	void Start () {
        vButton = GameObject.Find("vButton360");
        vButton.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
	}

    public void OnButtonPressed (VirtualButtonAbstractBehaviour vb)
    {
        SceneManager.LoadScene("360_Test", LoadSceneMode.Single);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {

    }
}
