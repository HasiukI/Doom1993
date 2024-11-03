using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private EnemyScript _enemyData;

    private float _health;
    private float _damage;
    private float _attackSpeed;
    private float _attackRenge;

    private bool _canAttack = true;

    private void Awake()
    {
        _health = _enemyData.Health;
        _damage = _enemyData.Damage;
        _attackRenge = _enemyData.AttackRenge;
        _attackSpeed = _enemyData.AttackSpeed;
    }

    public void Update()
    {
        if(Vector3.Distance(transform.position, Player.Instance.transform.position) <= _attackRenge)
        {
            if (_canAttack && Player.Instance.IsAlive)
            {
                StartCoroutine(AttackDelay());
                Player.Instance.TakeDamage(_damage);
            }
                
        }


    }

    private IEnumerator AttackDelay()
    {
        _canAttack = false;
        yield return new WaitForSeconds(_attackRenge);
        _canAttack = true;
    }

    private void Die()
    {
        if (_health <= 0f)
        {
            gameObject.SetActive(false);
        }
    }

    public void TakeDamage(float damage)
    {
        if (damage<0)
        {
            return;
        }

        _health -= damage;

        Die();
    }
}
