using UnityEngine;

public class END : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("Finish")) GameManager.Instance.GetEnd(false);
            else GameManager.Instance.GetEnd(true);
        }
    }
}
