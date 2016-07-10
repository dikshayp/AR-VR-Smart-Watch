using UnityEngine;
using System.Collections.Generic;
using Vuforia;

public class Button_Layout : MonoBehaviour, IVirtualButtonEventHandler
{
    private GameObject model1;
    private GameObject btn_2;
    // Use this for initialization
    void Start () {
        // Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterEventHandler(this);
        }
        model1 = transform.FindChild("TimeCube").gameObject;
        model1.SetActive(false);
        //btn_2 = transform.FindChild("cube2").gameObject;
    }

    /// Called when the virtual button has just been released:
    void IVirtualButtonEventHandler.OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        Debug.Log("Button released!");
    }

    /// Called when the virtual button has just been pressed:
    void IVirtualButtonEventHandler.OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        model1.SetActive(true);
        Debug.Log("Button Pressed!!!!!");
    }
}
