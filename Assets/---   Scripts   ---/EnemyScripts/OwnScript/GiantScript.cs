using UnityEngine;

namespace EnemyScripts.OwnScript
{
    public class GiantScript : MonoBehaviour, ICustomScript
    {
        private float speed;
        private float health;
        private float damage;
        private float hitTimeRange;
        private float attackRadius;
        private float knockBackPower;
        private bool isAttackinRange;
        private bool isItFly;
        private float suportArmor;
        
        public (float, float, float, float, float, float, bool, bool, float) OwnInformations()
        {
            speed = Random.Range(2.5f, 3.2f ); 
            health = Random.Range(100f, 140f);
            damage = Random.Range(15f, 18f);
            hitTimeRange = Random.Range(1.4f, 1.8f);
            attackRadius = Random.Range(2.5f, 3f);
            knockBackPower = Random.Range(1.2f, 1.4f);
            isAttackinRange = false;
            isItFly = false;
            suportArmor = 0;
            return (speed, health, damage, hitTimeRange, attackRadius, knockBackPower, isAttackinRange,isItFly, suportArmor);
        }
    }
}