using UnityEngine;

public class Player : MonoBehaviour
{
    #region ���
    [Header("�]�B�t��"),Range(0,500)]
    public float speed=1.5f;
    [Header("��������"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("�x�s����O�_�Ʀ�")]
    public bool isSlide;
    [Tooltip("�x�s����O�_���`")]
    public bool isDead;

    public string parameterJump = "Ĳ�o���D";
    public string parameterSlide = "�}���Ʀ�";
    public string parameterDead = "Ĳ�o���`";

    public KeyCode keyJump = KeyCode.Space;

    #endregion

    //public Transform traPlayer;

    private Rigidbody2D rig;
    [Header("���D�q�Ƴ̤j��"),Range(0,5)]
    public int countJumpMax = 2;
    public int countJump;
    [Header("�ˬd�a�O�첾")]
    public Vector3 v3GroudOffset;
    [Header("�ˬd�a�O�ؤo")]
    public Vector3 v3GroudSize = Vector3.one;

    #region �ƥ�
    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0.2f, 0.35f);
        Gizmos.DrawCube(transform.position + v3GroudOffset, v3GroudSize);
    }

    private void Update()
    {
        Run();
        Jump();
    }
    #endregion
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        countJump = countJumpMax;
    }

    #region ��k
    private void Run()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }

    private void Jump()
    {
        bool inputJump = Input.GetKeyDown(keyJump);

        if (inputJump&&countJump>0)
        {
            rig.AddForce(new Vector2(0, jump));
            countJump--;
        }
    }

    #endregion
}
