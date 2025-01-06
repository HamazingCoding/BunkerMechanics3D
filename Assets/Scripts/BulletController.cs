using UnityEngine;

public class BulletController : MonoBehaviour
{
    public bool Shoot;
    public ParticleSystem bullet;

    public float speed;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
