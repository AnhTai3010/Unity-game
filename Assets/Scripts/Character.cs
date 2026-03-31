using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Serialization;

public class Character : MonoBehaviour
{
    [SerializeField] Transform gun;
    [SerializeField]  Transform sword;
    [SerializeField]private float _speed=5f;
    private float _currentSwordAngle;
    private float _currentGunAngle;
    [SerializeField] private float _radiusGun = 5f;
    [SerializeField] private float _radiusSword = 3f;
    [SerializeField] private float _circleGunSpeed = 3f;
    [SerializeField] private float _circleSwordSpeed = 3f;

    private Vector3 move=Vector3.zero;
    [SerializeField]private Animator animator;
    [SerializeField]private SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // _radius = Vector3.Distance(transform.position,gun.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        move = Vector3.zero;
        if (Keyboard.current.wKey.isPressed)
            //transform.position+= Vector3.up*Time.deltaTime * _speed;
            move = Vector3.up*Time.deltaTime * _speed;
        if (Keyboard.current.sKey.isPressed)
            //transform.position += -Vector3.up*Time.deltaTime * _speed;
            move = -Vector3.up*Time.deltaTime * _speed;
        if (Keyboard.current.aKey.isPressed)
            //transform.position += -Vector3.right*Time.deltaTime * _speed;
        {
            spriteRenderer.flipX = true;
            move = -Vector3.right*Time.deltaTime * _speed;
        }
        if (Keyboard.current.dKey.isPressed)
            //transform.position += Vector3.right*Time.deltaTime * _speed;
        {
            spriteRenderer.flipX = false;
            move = Vector3.right * Time.deltaTime * _speed;
        }
        transform.position += move;
        if (move!=Vector3.zero)
        {
            animator.SetBool("IsMove",true);
        }
        else
        {
            animator.SetBool("IsMove",false);
        }
        //Spin
        _currentGunAngle+=Time.deltaTime*_circleGunSpeed;
        _currentSwordAngle+=Time.deltaTime*_circleSwordSpeed;
        Vector2 a = new Vector2(Mathf.Sin(_currentGunAngle), Mathf.Cos(_currentGunAngle)) *_radiusGun;
        Vector2 b = new Vector2(Mathf.Sin(_currentSwordAngle), Mathf.Cos(_currentSwordAngle)) *_radiusSword;
        gun.transform.position = Vector3.ProjectOnPlane(a,Vector3.forward)+transform.position;
        sword.transform.position = Vector3.ProjectOnPlane(b,Vector3.forward)+transform.position;
        
        
        
        Vector3 dirSword = (sword.transform.position-transform.position).normalized;
        float angleSword = Mathf.Atan2(dirSword.y, dirSword.x) * Mathf.Rad2Deg;
        sword.rotation = Quaternion.Euler(0, 0, angleSword - 90f);
        
        Vector3 dirAxe = (gun.transform.position-transform.position).normalized;
        float angleAxe = Mathf.Atan2(dirAxe.y, dirAxe.x) * Mathf.Rad2Deg;
        gun.rotation = Quaternion.Euler(0, 0, angleAxe - 90f);
        
        

    }
}
