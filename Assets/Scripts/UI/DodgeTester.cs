using UnityEngine;

public class DodgeTester : MonoBehaviour
{
    public MobileInputVisualizer input;

    public void DodgeLeft()
    {
        input.SetState("Dodge Left");
        Debug.Log("left");
    }

    public void DodgeRight()
    {
        input.SetState("Dodge Right");
        Debug.Log("right");
    }
}
