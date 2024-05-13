using UnityEditor.VersionControl;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer armRenderer;
    [SerializeField]
    private Transform armPivot;
    [SerializeField]
    private SpriteRenderer characterRenderer1;
    [SerializeField]
    private SpriteRenderer characterRenderer2;

    private TopDownController controller;



    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer1.flipX = Mathf.Abs(rotZ) > 90f;
        characterRenderer2.flipX = Mathf.Abs(rotZ) > 90f;


        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
