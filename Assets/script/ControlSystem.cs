using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sw
{
    public class ControlSystem : MonoBehaviour
    {
        [SerializeField, Header("目標物件")]
        private Transform target;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            LookatTarget();
        }

        /// <summary>
        /// 面相目標
        /// </summary>
        private void LookatTarget()
        {
            transform.LookAt(target);//變形元件.面向(目標物件)
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);//x z軸歸0
        }
    }
}

