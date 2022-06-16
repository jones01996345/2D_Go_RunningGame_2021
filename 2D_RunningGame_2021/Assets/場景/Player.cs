using UnityEngine;

public class Player : MonoBehaviour
{
    #region 欄位
    [Header("跑步速度"),Range(0,500)]
    public float speed=1.5f;
    [Header("跳的高度"), Range(0, 5000)]
    public int jump = 500;
    [Tooltip("儲存角色是否滑行")]
    public bool isSlide;
    [Tooltip("儲存角色是否死亡")]
    public bool isDead;

    public string parameterJump = "觸發跳躍";
    public string parameterSlide = "開關滑行";
    public string parameterDead = "觸發死亡";

    public KeyCode keyJump = KeyCode.Space;

    #endregion

    //public Transform traPlayer;

    private Rigidbody2D rig;
    [Header("跳躍段數最大值"),Range(0,5)]
    public int countJumpMax = 2;
    public int countJump;
    [Header("檢查地板位移")]
    public Vector3 v3GroudOffset;
    [Header("檢查地板尺寸")]
    public Vector3 v3GroudSize = Vector3.one;

    #region 事件
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

    #region 方法
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
