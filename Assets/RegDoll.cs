using UnityEngine;

[RequireComponent(typeof(Move))]
public class RegDoll : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _allRigidBody;
    private Animator _animator;
    private Move _movePlayer;
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _movePlayer = GetComponent<Move>();

        IsKinimatic(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            IsKinimatic(false);
    }
    public void Active()
    {
        IsKinimatic(false);
    }
    private void IsKinimatic(bool state)
    {
        for (int i = 0; i < _allRigidBody.Length; i++)
        {
            _allRigidBody[i].isKinematic = state;
        }
        _animator.enabled = state;
        _movePlayer.enabled = state;
    }
}
