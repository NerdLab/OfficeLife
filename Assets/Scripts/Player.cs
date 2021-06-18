using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    public int _playerLives = 3;
    public int _PlayerHealth = 100;
    
    [SerializeField]
    private float _speed = 8.0f;
    [SerializeField]
    public GameObject _PlayerPrefab;

    private Animator _animator;
    private Vector2 _LastDirection;
    private bool _isMoving;

    private BoxCollider2D _boxCollider;
    private RaycastHit2D _hit;
    Rigidbody2D _rigid;
    public int _PlayerDamage;


    // Use this for initialization
    void Start () {
        _PlayerPrefab.SetActive(true);
        transform.position = new Vector3(0, 0, 0);
        _animator = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider2D>();
        _rigid = GetComponent<Rigidbody2D>();
        _rigid.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Movement();
    }

    private void Movement()
    {
        float _horizontalInput = Input.GetAxisRaw("Horizontal");
        float _verticalInput = Input.GetAxisRaw("Vertical");
        _isMoving = false;

        //check to see if character is moving
        if (_horizontalInput < 0 || _horizontalInput > 0)
        {
            //PlayerCollisionDetecton();
            //_hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0, new Vector2(_horizontalInput, 0), Mathf.Abs(_horizontalInput * Time.deltaTime), LayerMask.GetMask("BlockingLayer"));
           
            transform.Translate(Vector3.right * _speed * _horizontalInput * Time.deltaTime);
            _isMoving = true;
            _LastDirection = new Vector2(_horizontalInput, 0f);
        }
        if (_verticalInput < 0 || _verticalInput > 0)
        {
            // PlayerCollisionDetecton();
         
          //  _hit = Physics2D.BoxCast(transform.position, _boxCollider.size, 0, new Vector2(0, _verticalInput), Mathf.Abs(_verticalInput * Time.deltaTime), LayerMask.GetMask("BlockingLayer"));
            transform.Translate(Vector3.up * _speed * _verticalInput * Time.deltaTime);
            _isMoving = true;
            _LastDirection = new Vector2(0f, _verticalInput);
        }
        _animator.SetFloat("XSpeed", _horizontalInput);
        _animator.SetFloat("YSpeed", _verticalInput);
        _animator.SetFloat("LastX", _LastDirection.x);
        _animator.SetFloat("LastY", _LastDirection.y);
        _animator.SetBool("PlayerWalking", _isMoving);
    }

}
