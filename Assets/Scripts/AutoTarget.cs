using UnityEngine;

public class AutoTarget : MonoBehaviour
{
    public Transform Target;

    private void Update()
    {
        transform.LookAt(Target);
    }

}
