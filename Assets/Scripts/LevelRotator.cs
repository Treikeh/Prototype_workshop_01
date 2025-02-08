using System;
using UnityEngine;

public class LevelRotator : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 5f;
    private Quaternion targetRotation;

    public static Action<bool> rotateLevel;


    void OnEnable()
    {
        rotateLevel += OnRotateLevel;
    }

    void OnDisable()
    {
        rotateLevel -= OnRotateLevel;
    }


    void Start()
    {
        targetRotation = transform.rotation;
    }


    void FixedUpdate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, rotationSpeed * Time.fixedDeltaTime);
    }


    void OnRotateLevel(bool right)
    {
        if (right)
        {
            targetRotation *= Quaternion.AngleAxis(-90f, transform.forward);
        }
        else
        {
            targetRotation *= Quaternion.AngleAxis(90f, transform.forward);
        }
    }
}
