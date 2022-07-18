using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    //public NavMeshAgent agent;

    public Transform player;

    public LayerMask Ground, Player;

    ////States
    public float detectionRange;

    ////Shooting
    //public GameObject bullet;
    //public Transform bulletspawnpoint;
    //public float shootTimer;
    //private float defTimer;
    //private bool allowFire = false;

    private void Awake()
    {
        player = GameObject.Find("Player").transform;
        //agent = GetComponent<NavMeshAgent>();
    }

    //private void AttackPlayer()
    //{
    //    //stop the enemy from moving
    //    agent.SetDestination(transform.position);

    //    //look at player
    //    transform.LookAt(player);
    //    //var q = Quaternion.LookRotation(player.position - transform.position);
    //    //transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 2 * Time.deltaTime);

    //    //shoot at player
    //    shootTimer -= Time.deltaTime;
    //    if (shootTimer <= 0)
    //    {
    //        allowFire = true;
    //    }
    //    if (allowFire)
    //    {
    //        Instantiate(bullet, bulletspawnpoint.position, bulletspawnpoint.rotation);
    //        allowFire = false;
    //        shootTimer = defTimer;
    //    }
    //}

    //private void Start()
    //{
    //    defTimer = shootTimer;
    //}

    private void Update()
    {
        float calcDistance = Vector3.Distance(transform.position, player.transform.position);
        if (calcDistance <= detectionRange) transform.LookAt(player);
    }
}
