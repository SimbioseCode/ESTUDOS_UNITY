using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectle : MonoBehaviour
{
    public GameObject tower;
    public GameObject target;
    public float speed = 10f;
    private float towerX;
    private float targetX;

    private float dist;
    private float nextX;
    private float baseY;
    private float height;
    // Start is called before the first frame update
    void Start()
    {
        tower = GameObject.FindGameObjectWithTag("Tower");
        target = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        towerX = tower.transform.position.x;
        targetX = tower.transform.position.x;

        dist = targetX - towerX;
        nextX = Mathf.MoveTowards(transform.position.x, targetX, speed * Time.deltaTime);
        baseY = Mathf.Lerp(tower.transform.position.y, target.transform.position.y, (nextX - towerX) / dist);
        height = 2 * (nextX - towerX) * (nextX - targetX) / (-0.25f * dist * dist);

        Vector3 movePostion = new Vector3(nextX, baseY +height, transform.position.z);
        transform.rotation = LookAtTarger(movePostion - transform.position);
        transform.position = movePostion;   

        if(transform.position == target.transform.position)
        {
            Destroy(gameObject);
        }
    }

    public static Quaternion LookAtTarger(Vector2 rotation)
    {
        return Quaternion.Euler(0,0, Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg);
    }
}
