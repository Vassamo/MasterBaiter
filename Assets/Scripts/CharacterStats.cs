using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currnetHealth { get; private set; }
   public Stat damage;
   public Stat armor;

    void Awake ()
    {
        currnetHealth = maxHealth;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }
    public void TakeDamage (int damage)
    {

        damage -= armor.GetValue();
        damage = Mathf.Clamp (damage, 0, int.MaxValue);    
        currnetHealth -= damage;
        Debug.Log(transform.name + "Takes" + damage + "damage.");

        if(currnetHealth <=0)
        {
            Die();
        }
    }
    public virtual void Die ()
    {
        Debug.Log(transform.name + "died");
    }

}
