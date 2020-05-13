using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform parentTr;
    [SerializeField] int damage;

    private GameObject target;
    private Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        parentTr.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void SetSpeed(float s)
    {
        speed = s;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Defender")
        {
            // attack
            // 1. 
            // - target GameObject 변수에 저장을 한후,
            // - Animator Transition (Animation Clip을 바꿈 (Attack) )
            // - Attack Animation Clip에서 데미지를주는 함수를 Animation Event(분필모양)로 호출을 해요.
            // 장점 : 공격이 무조건 들어가게 됨.
            // 단점 : attack은 play가 됐는데, target 이 없을수있음 => 예외처리 필수

            target = other.gameObject;
            myAnim.SetBool("IsAttacking", true);
            SetSpeed(0f);

            // 2. 
            // - Lizard앞에 Collider를 설치하고, (Liazrd의 공격범위를 나타내는 Collider)
            // - Animator Transition (Animation Clip을 바꿈 (Attack) )
            // - Attack Animation Clip에서 데미지를주는 함수를 Animation Event(분필모양)로 호출을 해요.
            // 장점 : 리얼한 공격시스템을 구현할때는 이걸.
            // 단점 : 추가적인 Collider 설치 필요.
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject == target)
        {
            target = null;
        }
    }

    //Animation Event 
    public void Damage()
    {

        if(target != null)
        {
            target.GetComponent<Health>().GiveDamage(damage);
        }
        else
        {
            myAnim.SetBool("IsAttacking", false);
        }
        
    }
}
