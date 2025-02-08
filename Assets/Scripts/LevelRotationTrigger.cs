using UnityEngine;

public class LevelRotationTrigger : MonoBehaviour
{
    [SerializeField] private bool rotateRight;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            LevelRotator.rotateLevel?.Invoke(rotateRight);
        }
    }
}
