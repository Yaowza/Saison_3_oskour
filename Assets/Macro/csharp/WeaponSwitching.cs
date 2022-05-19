using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public int selectedWeapon = 0;

    [SerializeField] private List<GameObject> _weapons;

    // Start is called before the first frame update
    private void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    private void Update()
    {
        int previousSelectedWeapon = selectedWeapon;
        

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >= 2)
        {
            selectedWeapon = 1;
        }

        if (previousSelectedWeapon != selectedWeapon)
        {
            SelectWeapon();
        }
       
        
    }

    private void SelectWeapon()
    {
        /*foreach (Transform weapon in transform)
        {
            int i = 0;
            if (i == selectedWeapon)
                    weapon.gameObject.SetActive(true);
                else
                    weapon.gameObject.SetActive(false);
                i++;
            
        }*/

        _weapons.ForEach(w => w.SetActive(false));
        _weapons[selectedWeapon].SetActive(true);
    }
}
