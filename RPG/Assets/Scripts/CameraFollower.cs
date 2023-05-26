using UnityEngine;
using static EnemyTrigger;
using static DialogueManager;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Transform target2;
    [SerializeField] private Vector3 offset = new Vector3(0f, 0f, -10f);

    private bool isFollowingTarget2 = false;
    private bool isWaitingToSwitchBack = false;
    private float waitTime = 0.2f;
    private float timer = 0f;

    private void LateUpdate()
    {
        if (StopTriggerEnemy)
        {
            if (!isWaitingToSwitchBack)
            {
                isWaitingToSwitchBack = true;
                timer = 0f;
            }

            timer += Time.deltaTime;
            if (timer >= waitTime)
            {
                isFollowingTarget2 = false;
                isWaitingToSwitchBack = false;
            }
        }
        else if (TriggerTriggerEnemy == true)
        {
            isFollowingTarget2 = true;
        }

        if (isFollowingTarget2 && target2 != null)
        {
            transform.position = target2.position + offset;
        }
        else if (target != null)
        {
            transform.position = target.position + offset;
        }
    }
}
