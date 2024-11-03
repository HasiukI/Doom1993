using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private float _health;
    [SerializeField] private Weapon _startWeapon;

    private List<Weapon> _weapons = new List<Weapon>();

    private int _weaponIndex;

    private bool _isAlive;
    public bool IsAlive => _isAlive;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance == this)
        {
            Destroy(gameObject);
        }
       
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _isAlive = true;
        _weaponIndex = 0;
        _weapons.Add(_startWeapon);
    }

    private void Update()
    {
        ChangeWeapon();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out PickUpWeapon weapon))
        {
            _weapons.Add(weapon.WeaponToPickUp());
            weapon.PickUp();
        }
    }

    private void ChangeWeapon()
    {

        if (_weapons.Count <= 1) return;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _weapons[_weaponIndex].Drop();

            ++_weaponIndex;

            if (_weaponIndex >= _weapons.Count) 
                _weaponIndex = 0;


            _weapons[_weaponIndex].PickUp();
        }
    }

    public void TakeDamage(float damage)
    {
        if(damage <= 0)
        {
            return;
        }

        _health -= damage;

        Die();
    }

    private void Die()
    {
        if(_health <= 0f)
        {
            Camera.main.transform.parent = null;
            gameObject.SetActive(false);
            _isAlive = true;
        }
        
    }
}
