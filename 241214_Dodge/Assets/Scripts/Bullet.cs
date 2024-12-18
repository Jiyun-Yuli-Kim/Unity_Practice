using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Range(5,35)]
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private float _bulletDamage;

    private PlayerController _player;

    void Awake()
    {
        //_player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            _player = other.gameObject.GetComponent<PlayerController>();
            _player.GetDamage(_bulletDamage);
            GameManager.Instance.Score -= 10;
        }

        GameManager.Instance.Score += 5;
        Destroy(gameObject,0.5f);
    }

    public float GetSpeed()
    {
        return _bulletSpeed;
    }

}
