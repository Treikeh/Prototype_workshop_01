using UnityEngine;

public class LevelRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    private Quaternion targetRotation;


    void Start()
    {
        targetRotation = transform.rotation;
    }


    void FixedUpdate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
    }


    public void RotateLevelLeft()
    {
        targetRotation *= Quaternion.AngleAxis(90f, transform.forward);
    }


    public void RotateLevelRight()
    {
        targetRotation *= Quaternion.AngleAxis(-90f, transform.forward);
    }
}
