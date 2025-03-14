using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_script : MonoBehaviour
{
    public string tag_name;
    private Transform playerTransform;
    private Rigidbody2D rigidBody;

    private void Awake()
    {
        playerTransform = GameObject.Find(tag_name).transform;
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector2 direction = playerTransform.position - transform.position;
        direction = direction.normalized;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
            Destroy(gameObject);
    }
}