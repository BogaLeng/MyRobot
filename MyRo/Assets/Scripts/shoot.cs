using UnityEngine;

public class shoot : MonoBehaviour
{
        public GameObject bulletPrefab;//子弹预制体
        //public float fireRate=0.3f,nextFire=0.0f;//遗弃
        public static float heat = 4;
        public float nextDisHeat=0.0f,DisRate=1.0f;
        public float BulletSpeed = 30;
        private Vector3 boltPostion;
        private float countinousFire = 0.0f;
        public AudioClip shootClip;
        void Update()
        {
            Shoot();
            if (Time.time > nextDisHeat&&heat>=2)
            {
                nextDisHeat = DisRate + Time.time;
                heat -= 1;
                countinousFire = 0.0f;
            }
        }
        void Shoot()
        {
            if (Input.GetMouseButtonDown(0)&&heat<10) //如果按下鼠标左键，生成预制体
            {
                heat += 1;
                AudioManager.instance.AudioPlay(shootClip);
                boltPostion = transform.position;
                countinousFire+= 0.2f;
                boltPostion.y += countinousFire;
                GameObject bullet=Instantiate(bulletPrefab, boltPostion, transform.rotation); //生成预制体
                bullet.GetComponent<Rigidbody>().velocity=-bullet.transform.forward * BulletSpeed;
                Destroy(bullet, 2.5f);
            }
        }
}