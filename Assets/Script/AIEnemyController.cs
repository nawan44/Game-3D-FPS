using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public AudioSource EnemyAudio;

public class AIEnemyController : MonoBehaviour
{
    // Start is called before the first frame update
void OnTriggerEnter(Collider col) {
    if (col.gameObject.CompareTag("Player")) {
        anim.SetBool("isAttack", true);
        anim.SetBool("isWalk", false);
        GiveDamage = true;
        EnemyAudio.Play();
    }
}
}
