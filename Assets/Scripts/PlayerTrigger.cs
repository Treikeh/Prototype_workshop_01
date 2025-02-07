using UnityEngine;
using UnityEngine.Events;

public class PlayerTrigger : MonoBehaviour
{
    [SerializeField] private UnityEvent playercolided;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playercolided.Invoke();
        }
    }
}
