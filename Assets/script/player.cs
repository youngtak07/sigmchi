using UnityEngine;

public class player : MonoBehaviour
{
    public float jumpForce = 5.0f;
    // Rigidbody2D 컴포넌트를 저장할 변수
    private Rigidbody2D rb;

    void Start()
    {
        // 시작 시 Rigidbody2D 컴포넌트를 가져와서 rb 변수에 할당
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 스페이스바를 눌렀을 때 오브젝트가 점프할 수 있는지 확인
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 점프 함수 호출
            Jump();
        }
    }

    void Jump()
    {
        // 오브젝트에 점프 힘을 적용하여 수직 방향으로 띄움
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
}