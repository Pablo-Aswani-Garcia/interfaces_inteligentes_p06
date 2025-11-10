using UnityEngine;

public class far_cube : UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    protected override void OnHoverEntered(UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs args) {
        Color newColor = new Color(Random.value, Random.value, Random.value);
        GetComponent<Renderer>().material.color = newColor;
        
    }
}
