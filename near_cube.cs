using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class near_cube : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	protected override void OnSelectEntered(SelectEnterEventArgs args)
	{
		Debug.Log("near_cube grabbed by ");
	}
}
